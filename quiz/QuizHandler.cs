using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class QuizHandler
    {
        private Panel QuestionPanel;
        private TableLayoutPanel AnswerTable;
        private List<RadioButton> Answers;
        private Label qDescription;
        private int AnswerCount;
        private Quiz ActiveQuiz;

        protected Button SubmitButton;

        public delegate void QuizFinishedAction(string prompt);
        protected QuizFinishedAction WhenFinished;

        /// <param name="questionPanel"><c>Control</c> that the questions should be added to.</param>
        /// <param name="answerCount">Maximum number of permitted answers.</param>
        /// <param name="finished">Delegate to be called when the quiz is finished.</param>
        public QuizHandler(Panel questionPanel, int answerCount, QuizFinishedAction finished)
        {
            QuestionPanel = questionPanel;
            AnswerCount = answerCount;

            AnswerTable = (TableLayoutPanel)QuestionPanel.Controls.Find("AnswerTable", false)[0];
            qDescription = (Label)QuestionPanel.Controls.Find("qDescription", false)[0];
            SubmitButton = (Button)QuestionPanel.Controls.Find("Check", false)[0];

            Button Check = (Button)QuestionPanel.Controls.Find("Check", false)[0];
            Check.Click += new EventHandler(CheckCorrectAnswer);

            InitializeAnswerTable();
            InitializeTimer();

            WhenFinished = finished;
        }

        /// <summary>
        /// Prepare the panel containing the answers. 
        /// </summary>
        private void InitializeAnswerTable()
        {
            Answers = new();

            for (int i = 0; i < AnswerCount; i++)
            {
                var created = new RadioButton();

                created.AutoSize = true;
                created.Dock = DockStyle.Fill;
                created.Location = new Point(3, 3 + 53 * i);
                created.Name = "option1";
                created.Size = new Size(425, 47);
                created.TabIndex = 1;
                created.TabStop = true;
                created.Text = "answer_" + (char)('a' + i);
                created.UseVisualStyleBackColor = true;
                created.Enabled = false;
                created.Visible = false;

                AnswerTable.Controls.Add(created, 0, i);

                Answers.Add(created);
            }
        }

        /// <summary>
        /// Begins the quiz by show the question Panel to the user.
        /// </summary>
        /// <param name="quiz"></param>
        public void QuizStarted(Quiz quiz)
        {
            ActiveQuiz = quiz;
            QuestionPanel.Show();

            UpdateQuestion();
        }

        /// <summary>
        /// Show current question to the user.
        /// </summary>
        private void UpdateQuestion()
        {
            Question current = ActiveQuiz.CurrentQuestion;

            qDescription.Text = current.Description;

            for (int i = 0; i < AnswerCount; i++)
            {
                string ind = "answer_" + (char)('a' + i);
                string answerText = current.Answers[ind];

                if (answerText != null)
                {
                    Answers[i].Text = answerText;
                    Answers[i].Enabled = true;
                    Answers[i].Visible = true;
                }
                else
                {
                    Answers[i].Text = "";
                    Answers[i].Enabled = false;
                    Answers[i].Visible = false;
                }
            }

            UpdateQuestionCounter();
        }

        private void UpdateQuestionCounter()
        {
            Label label = (Label)QuestionPanel.Controls.Find("Counter", false)[0];

            label.Text = string.Format("{0} out of {1}", ActiveQuiz.CurrentQuestionNumber, ActiveQuiz.QuestionCount);
        }

        /// <summary>
        /// Checks which radio button has been checked by the user.
        /// </summary>
        /// <returns>Index of the button, starting with 0.</returns>
        /// <exception cref="NoRadioButtonChecked">No choice has been made by the user.</exception>
        private int GetRadioButtonChecked()
        {
            for (int i = 0; i < AnswerCount; i++)
            {
                if (Answers[i].Checked)
                    return i;
            }

            throw new NoRadioButtonChecked("No button has been checked");
        }

        private void CheckCorrectAnswer(object sender, EventArgs e)
        {
            if (sender is Button submitButton)
            {
                int choice = GetRadioButtonChecked();

                bool correct = ActiveQuiz.CheckAnswer(choice);

                if (correct)
                {
                    submitButton.BackColor = Color.ForestGreen;

                    //CorrectAnswers++;
                }
                else
                {
                    submitButton.BackColor = Color.DarkRed;
                }

                NextQuestionTimer.Enabled = true;
                NextQuestionTimer.Start();
            }
        }

        private static string PromptTemplate = "You got {0} out of {1} correct!";

        private void FinishQuiz()
        {
            string messagePrompt = string.Format(PromptTemplate, ActiveQuiz.CorrectAnswerCount, ActiveQuiz.QuestionCount);

            WhenFinished(messagePrompt);
        }

        private System.Windows.Forms.Timer NextQuestionTimer;
        /// <summary>
        /// Start the timer that changes the SubmitButton color for <c>interval</c>ms and shows the next question.
        /// </summary>
        private void InitializeTimer()
        {
            NextQuestionTimer = new()
            {
                Enabled = false,
                Interval = 1000
            };

            NextQuestionTimer.Tick += (s, e) =>
            {
                NextQuestionTimer.Enabled = false;
                NextQuestionTimer.Stop();
                if (ActiveQuiz != null)
                {
                    bool result = ActiveQuiz.NextQuestion();

                    if (result)
                    {
                        UpdateQuestion();

                        SubmitButton.BackColor = Form1.ButtonBackColor;
                    }
                    else FinishQuiz();
                }

            };
        }
    }
}
