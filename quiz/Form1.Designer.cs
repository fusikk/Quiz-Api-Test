namespace quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qDescription = new System.Windows.Forms.Label();
            this.AnswerTable = new System.Windows.Forms.TableLayoutPanel();
            this.Check = new System.Windows.Forms.Button();
            this.Questions = new System.Windows.Forms.Panel();
            this.Counter = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.Length2 = new System.Windows.Forms.Button();
            this.Length0 = new System.Windows.Forms.Button();
            this.Length1 = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Difficulty2 = new System.Windows.Forms.Button();
            this.Difficulty0 = new System.Windows.Forms.Button();
            this.Difficulty1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.QuizSummary = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Questions.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.QuizSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // qDescription
            // 
            this.qDescription.AutoSize = true;
            this.qDescription.Location = new System.Drawing.Point(25, 29);
            this.qDescription.Name = "qDescription";
            this.qDescription.Size = new System.Drawing.Size(38, 15);
            this.qDescription.TabIndex = 0;
            this.qDescription.Text = "label1";
            // 
            // AnswerTable
            // 
            this.AnswerTable.ColumnCount = 1;
            this.AnswerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AnswerTable.Location = new System.Drawing.Point(25, 73);
            this.AnswerTable.Name = "AnswerTable";
            this.AnswerTable.RowCount = 6;
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AnswerTable.Size = new System.Drawing.Size(425, 319);
            this.AnswerTable.TabIndex = 2;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.DimGray;
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(651, 388);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(137, 51);
            this.Check.TabIndex = 3;
            this.Check.Text = "button1";
            this.Check.UseVisualStyleBackColor = false;
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.Counter);
            this.Questions.Controls.Add(this.AnswerTable);
            this.Questions.Controls.Add(this.Check);
            this.Questions.Controls.Add(this.qDescription);
            this.Questions.Location = new System.Drawing.Point(12, 68);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(800, 450);
            this.Questions.TabIndex = 4;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("WarHeliosCondCBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Counter.Location = new System.Drawing.Point(559, 399);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(86, 23);
            this.Counter.TabIndex = 6;
            this.Counter.Text = "{} out of {}";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainMenu.Controls.Add(this.Length2);
            this.MainMenu.Controls.Add(this.Length0);
            this.MainMenu.Controls.Add(this.Length1);
            this.MainMenu.Controls.Add(this.LengthLabel);
            this.MainMenu.Controls.Add(this.button5);
            this.MainMenu.Controls.Add(this.Difficulty2);
            this.MainMenu.Controls.Add(this.Difficulty0);
            this.MainMenu.Controls.Add(this.Difficulty1);
            this.MainMenu.Controls.Add(this.label1);
            this.MainMenu.Controls.Add(this.Title);
            this.MainMenu.Location = new System.Drawing.Point(29, 44);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(892, 349);
            this.MainMenu.TabIndex = 5;
            // 
            // Length2
            // 
            this.Length2.BackColor = System.Drawing.Color.DarkGreen;
            this.Length2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Length2.FlatAppearance.BorderSize = 3;
            this.Length2.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Length2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Length2.Location = new System.Drawing.Point(438, 238);
            this.Length2.Name = "Length2";
            this.Length2.Size = new System.Drawing.Size(70, 70);
            this.Length2.TabIndex = 9;
            this.Length2.Tag = "questionCount;15";
            this.Length2.Text = "15";
            this.Length2.UseVisualStyleBackColor = false;
            this.Length2.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // Length0
            // 
            this.Length0.BackColor = System.Drawing.Color.DarkGreen;
            this.Length0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Length0.FlatAppearance.BorderSize = 3;
            this.Length0.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Length0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Length0.Location = new System.Drawing.Point(286, 238);
            this.Length0.Name = "Length0";
            this.Length0.Size = new System.Drawing.Size(70, 70);
            this.Length0.TabIndex = 8;
            this.Length0.Tag = "questionCount;5";
            this.Length0.Text = "5";
            this.Length0.UseVisualStyleBackColor = false;
            this.Length0.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // Length1
            // 
            this.Length1.BackColor = System.Drawing.Color.DarkGreen;
            this.Length1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Length1.FlatAppearance.BorderSize = 3;
            this.Length1.Font = new System.Drawing.Font("Miriam Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Length1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Length1.Location = new System.Drawing.Point(362, 238);
            this.Length1.Name = "Length1";
            this.Length1.Size = new System.Drawing.Size(70, 70);
            this.Length1.TabIndex = 7;
            this.Length1.Tag = "questionCount;10";
            this.Length1.Text = "10";
            this.Length1.UseVisualStyleBackColor = false;
            this.Length1.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // LengthLabel
            // 
            this.LengthLabel.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LengthLabel.Location = new System.Drawing.Point(300, 189);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(200, 46);
            this.LengthLabel.TabIndex = 6;
            this.LengthLabel.Text = "Number of Questions";
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Miriam Libre", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(324, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Start quiz";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.StartQuiz);
            // 
            // Difficulty2
            // 
            this.Difficulty2.BackColor = System.Drawing.Color.DarkGreen;
            this.Difficulty2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Difficulty2.FlatAppearance.BorderSize = 3;
            this.Difficulty2.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Difficulty2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Difficulty2.Location = new System.Drawing.Point(438, 116);
            this.Difficulty2.Name = "Difficulty2";
            this.Difficulty2.Size = new System.Drawing.Size(70, 70);
            this.Difficulty2.TabIndex = 4;
            this.Difficulty2.Tag = "difficulty;2";
            this.Difficulty2.Text = "Hard";
            this.Difficulty2.UseVisualStyleBackColor = false;
            this.Difficulty2.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // Difficulty0
            // 
            this.Difficulty0.BackColor = System.Drawing.Color.DarkGreen;
            this.Difficulty0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Difficulty0.FlatAppearance.BorderSize = 3;
            this.Difficulty0.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Difficulty0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Difficulty0.Location = new System.Drawing.Point(286, 116);
            this.Difficulty0.Name = "Difficulty0";
            this.Difficulty0.Size = new System.Drawing.Size(70, 70);
            this.Difficulty0.TabIndex = 3;
            this.Difficulty0.Tag = "difficulty;0";
            this.Difficulty0.Text = "Easy";
            this.Difficulty0.UseVisualStyleBackColor = false;
            this.Difficulty0.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // Difficulty1
            // 
            this.Difficulty1.BackColor = System.Drawing.Color.DarkGreen;
            this.Difficulty1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Difficulty1.FlatAppearance.BorderSize = 3;
            this.Difficulty1.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Difficulty1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Difficulty1.Location = new System.Drawing.Point(362, 116);
            this.Difficulty1.Name = "Difficulty1";
            this.Difficulty1.Size = new System.Drawing.Size(70, 70);
            this.Difficulty1.TabIndex = 2;
            this.Difficulty1.Tag = "difficulty;1";
            this.Difficulty1.Text = "Medium";
            this.Difficulty1.UseVisualStyleBackColor = false;
            this.Difficulty1.Click += new System.EventHandler(this.HandleSettingsClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("WarHeliosCondCBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(300, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 100);
            this.Title.TabIndex = 0;
            this.Title.Text = "TechQuiz";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizSummary
            // 
            this.QuizSummary.Controls.Add(this.button1);
            this.QuizSummary.Controls.Add(this.ScoreLabel);
            this.QuizSummary.Controls.Add(this.label2);
            this.QuizSummary.Location = new System.Drawing.Point(3, 82);
            this.QuizSummary.Name = "QuizSummary";
            this.QuizSummary.Size = new System.Drawing.Size(797, 468);
            this.QuizSummary.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Miriam Libre", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(300, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reset);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("WarHeliosCondCBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(268, 109);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(266, 100);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Your score: {0} out of {1}";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("WarHeliosCondCBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quiz finished!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("WarHeliosCondCBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(622, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Powered by QuizApi\r\nhttps://quizapi.io/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuizSummary);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.MainMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.QuizSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label qDescription;
        private TableLayoutPanel AnswerTable;
        private Button Check;
        private Panel Questions;
        private Panel MainMenu;
        private Label Title;
        private Label label1;
        private Button Difficulty2;
        private Button Difficulty0;
        private Button Difficulty1;
        private Button button5;
        private Button Length2;
        private Button Length0;
        private Button Length1;
        private Label LengthLabel;
        private Label Counter;
        private Panel QuizSummary;
        private Button button1;
        private Label ScoreLabel;
        private Label label2;
        private Label label3;
    }
}