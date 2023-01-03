using System.Text.RegularExpressions;

namespace quiz
{
    public delegate void QuizStarted(Quiz startedQuiz);

    public partial class Form1 : Form
    {
        Quiz? MainQuiz;
        
        private Difficulty _chosenDifficulty;
        protected QuizHandler Handler;
        protected Dictionary<string, Panel> Panels;
        public static Color ButtonBackColor = Color.FromArgb(170, 170, 170);

        protected Difficulty ChosenDifficulty
        {
            get => _chosenDifficulty;
            set
            {
                var buttons = Extensions.GetAllControlsOfType<Button>(MainMenu, false);
                var rx = new Regex(@"(?:difficulty;)(\d+)", RegexOptions.IgnoreCase);

                foreach (Button button in buttons)
                {
                    if (button.Tag == null)
                        continue;

                    var match = rx.Match((string)button.Tag!);

                    if (match.ToString() == "")
                        continue;

                    var tag = int.Parse(match.Groups[1].Captures[0].Value);

                    if (tag == (int)_chosenDifficulty)
                    {
                        Extensions.Highlight(button, false);
                    }
                    else if (tag == (int)value)
                    {
                        Extensions.Highlight(button, true);
                    }
                }

                _chosenDifficulty = value;
            }
        }
        private int _chosenQuestionCount;
        protected int ChosenQuestionCount
        {
            get => _chosenQuestionCount;
            set
            {
                var buttons = Extensions.GetAllControlsOfType<Button>(MainMenu, false);
                var rx = new Regex(@"(?:questionCount;)(\d+)", RegexOptions.IgnoreCase);

                foreach (Button button in buttons)
                {
                    if (button.Tag == null)
                        continue;

                    var match = rx.Match((string)button.Tag!);

                    if (match.ToString() == "")
                        continue;

                    var tag = int.Parse(match.Groups[1].Captures[0].Value);

                    if (tag == _chosenQuestionCount)
                    {
                        Extensions.Highlight(button, false);
                    }
                    else if (tag == value)
                    {
                        Extensions.Highlight(button, true);
                    }
                }

                _chosenQuestionCount = value;
            }
        }

        public event QuizStarted QuizEvent;

        public Form1()
        {
            InitializeComponent();
            InitializePanels();
            //TODO: Dynamically generate difficulty buttons based on the Enum

            ChosenDifficulty = Difficulty.Medium;
            ChosenQuestionCount = 10;

            Handler = new(Questions, AnswerCount, QuizFinished);
            QuizEvent += Handler.QuizStarted;

            foreach (Button button in Extensions.GetAllControlsOfType<Button>(this, true))
            {
                if (button.Tag == null || (string)button.Tag == "")
                {
                    button.BackColor = ButtonBackColor;
                }
            }
        }
        /// <summary>
        /// Maximum number of answers that a question can have.
        /// </summary>
        public static int AnswerCount = 6;

        private void InitializePanels()
        {
            Panels = new();

            foreach (Control control in Controls)
            { 
                if (control is Panel)
                {
                    control.Size = Size;
                    control.Location = new(0);
                    control.Hide();

                    Panels.Add(control.Name, (Panel)control);
                }
            }

            MainMenu.Show();
        }

        /// <summary>
        /// Begin the quiz.
        /// </summary>
        private void StartQuiz(object sender, EventArgs e)
        {
            MainQuiz = new(ChosenQuestionCount, ChosenDifficulty);

            ShowPanels(Extensions.Panels.Questions);
            QuizEvent.Invoke(MainQuiz);
        }

        [Obsolete("Call ShowPanels instead.")]
        private void ChangeDifficulty(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var d = int.Parse((string)(sender as Button)!.Tag);
                ChosenDifficulty = (Difficulty)d;
            }
        }

        /// <summary>
        /// Show argument-specified panel(s) and hide the others.
        /// </summary>
        /// <param name="panel">Panel(s) to show.</param>
        public void ShowPanels(Extensions.Panels panel)
        {
            foreach (Enum value in Enum.GetValues(typeof(Extensions.Panels)))
            {
                if (panel.HasFlag(value))
                {
                    Panels[value.ToString()].Show();
                }
                else
                {
                    Panels[value.ToString()].Hide();
                }

            }
        }

        /// <summary>
        /// Handle Main Menu buttons related to quiz settings.
        /// </summary>
        /// <exception cref="IncorrectTagException"></exception>
        private void HandleSettingsClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var control = (sender as Control)!;

                var t = (string)control.Tag;
                string[] tag = t.Split(";");

                switch (tag[0])
                {
                    case "difficulty":
                        ChosenDifficulty = (Difficulty)int.Parse(tag[1]);
                        break;
                    case "questionCount":
                        ChosenQuestionCount = int.Parse(tag[1]);
                        break;
                    case "category":
                        // TODO: Implement category selection
                        break;
                    default:
                        throw new IncorrectTagException("Unknown tag name");
                }
            }
        }


        /// <summary>
        /// Loads the result page with the achieved score.
        /// </summary>
        /// <param name="messagePrompt">Message to display on the result screen.</param>
        /// <exception cref="ControlNotFoundException">Label of given name could not be found in the results panel.</exception>
        public void QuizFinished(string messagePrompt)
        {
            ShowPanels(Extensions.Panels.QuizSummary);

            // TODO: Exception handling
            var panel = Panels[Extensions.Panels.QuizSummary.ToString()];
            var result = panel.Controls.Find("ScoreLabel", false);

            Label label;
            if (result != null)
            {
                label = (Label)result[0];
            }
            else
            {
                throw new ControlNotFoundException("panel.Controls does not contain ScoreLabel Control");
            }

            label.Text = messagePrompt;
        }

        /// <summary>
        /// Reset the application state back to the Main Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            ShowPanels(Extensions.Panels.MainMenu);

            MainQuiz = null;
        }
    }
}