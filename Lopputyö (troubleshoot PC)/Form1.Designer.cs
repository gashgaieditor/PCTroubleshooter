namespace PCTroubleshooter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnDoesNotStart = new System.Windows.Forms.Button();
            this.btnOverheats = new System.Windows.Forms.Button();
            this.btnIsSlow = new System.Windows.Forms.Button();
            this.btnNoInternet = new System.Windows.Forms.Button();
            this.btnNoDisplay = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerYes = new System.Windows.Forms.Button();
            this.btnAnswerNo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnResultBack = new System.Windows.Forms.Button();
            this.btnidontknow = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.btnHistory);
            this.panelMainMenu.Controls.Add(this.lbltitle);
            this.panelMainMenu.Controls.Add(this.btnDoesNotStart);
            this.panelMainMenu.Controls.Add(this.btnOverheats);
            this.panelMainMenu.Controls.Add(this.btnIsSlow);
            this.panelMainMenu.Controls.Add(this.btnNoInternet);
            this.panelMainMenu.Controls.Add(this.btnNoDisplay);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(816, 499);
            this.panelMainMenu.TabIndex = 0;
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbltitle.Location = new System.Drawing.Point(150, 40);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(500, 60);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "PC TROUBLESHOOTER";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoesNotStart
            // 
            this.btnDoesNotStart.Location = new System.Drawing.Point(290, 150);
            this.btnDoesNotStart.Name = "btnDoesNotStart";
            this.btnDoesNotStart.Size = new System.Drawing.Size(220, 40);
            this.btnDoesNotStart.TabIndex = 1;
            this.btnDoesNotStart.Text = "Tietokone ei käynnisty";
            this.btnDoesNotStart.UseVisualStyleBackColor = true;
            this.btnDoesNotStart.Click += new System.EventHandler(this.btnDoesNotStart_Click);
            // 
            // btnOverheats
            // 
            this.btnOverheats.Location = new System.Drawing.Point(290, 200);
            this.btnOverheats.Name = "btnOverheats";
            this.btnOverheats.Size = new System.Drawing.Size(220, 40);
            this.btnOverheats.TabIndex = 2;
            this.btnOverheats.Text = "Tietokone ylikuumenee";
            this.btnOverheats.UseVisualStyleBackColor = true;
            this.btnOverheats.Click += new System.EventHandler(this.btnOverheats_Click);
            // 
            // btnIsSlow
            // 
            this.btnIsSlow.Location = new System.Drawing.Point(290, 250);
            this.btnIsSlow.Name = "btnIsSlow";
            this.btnIsSlow.Size = new System.Drawing.Size(220, 40);
            this.btnIsSlow.TabIndex = 3;
            this.btnIsSlow.Text = "Tietokone on hidas";
            this.btnIsSlow.UseVisualStyleBackColor = true;
            this.btnIsSlow.Click += new System.EventHandler(this.btnIsSlow_Click);
            // 
            // btnNoInternet
            // 
            this.btnNoInternet.Location = new System.Drawing.Point(290, 300);
            this.btnNoInternet.Name = "btnNoInternet";
            this.btnNoInternet.Size = new System.Drawing.Size(220, 40);
            this.btnNoInternet.TabIndex = 4;
            this.btnNoInternet.Text = "Ei internetyhteyttä";
            this.btnNoInternet.UseVisualStyleBackColor = true;
            this.btnNoInternet.Click += new System.EventHandler(this.btnNoInternet_Click);
            // 
            // btnNoDisplay
            // 
            this.btnNoDisplay.Location = new System.Drawing.Point(290, 350);
            this.btnNoDisplay.Name = "btnNoDisplay";
            this.btnNoDisplay.Size = new System.Drawing.Size(220, 40);
            this.btnNoDisplay.TabIndex = 5;
            this.btnNoDisplay.Text = "Näyttöön ei tule kuvaa";
            this.btnNoDisplay.UseVisualStyleBackColor = true;
            this.btnNoDisplay.Click += new System.EventHandler(this.btnNoDisplay_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.btnidontknow);
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Controls.Add(this.btnAnswerYes);
            this.panelQuestion.Controls.Add(this.btnAnswerNo);
            this.panelQuestion.Controls.Add(this.btnBack);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(816, 499);
            this.panelQuestion.TabIndex = 1;
            this.panelQuestion.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblQuestion.Location = new System.Drawing.Point(53, 67);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(700, 80);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Kysymys";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnAnswerYes
            // 
            this.btnAnswerYes.Location = new System.Drawing.Point(290, 180);
            this.btnAnswerYes.Name = "btnAnswerYes";
            this.btnAnswerYes.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerYes.TabIndex = 1;
            this.btnAnswerYes.Text = "Kyllä";
            this.btnAnswerYes.UseVisualStyleBackColor = true;
            this.btnAnswerYes.Click += new System.EventHandler(this.btnVastaus1_Click);
            // 
            // btnAnswerNo
            // 
            this.btnAnswerNo.Location = new System.Drawing.Point(410, 180);
            this.btnAnswerNo.Name = "btnAnswerNo";
            this.btnAnswerNo.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerNo.TabIndex = 2;
            this.btnAnswerNo.Text = "Ei";
            this.btnAnswerNo.UseVisualStyleBackColor = true;
            this.btnAnswerNo.Click += new System.EventHandler(this.btnVastaus2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Takaisin päävalikkoon";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.lblProblem);
            this.panelAnswer.Controls.Add(this.lblSolution);
            this.panelAnswer.Controls.Add(this.btnResultBack);
            this.panelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswer.Location = new System.Drawing.Point(0, 0);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(816, 499);
            this.panelAnswer.TabIndex = 2;
            this.panelAnswer.Visible = false;
            this.panelAnswer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnswer_Paint);
            // 
            // lblProblem
            // 
            this.lblProblem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProblem.Location = new System.Drawing.Point(12, 60);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(776, 87);
            this.lblProblem.TabIndex = 0;
            this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProblem.Click += new System.EventHandler(this.lblProblem_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSolution.Location = new System.Drawing.Point(150, 130);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(500, 150);
            this.lblSolution.TabIndex = 1;
            this.lblSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResultBack
            // 
            this.btnResultBack.Location = new System.Drawing.Point(12, 22);
            this.btnResultBack.Name = "btnResultBack";
            this.btnResultBack.Size = new System.Drawing.Size(200, 35);
            this.btnResultBack.TabIndex = 2;
            this.btnResultBack.Text = "Takaisin päävalikkoon";
            this.btnResultBack.UseVisualStyleBackColor = true;
            this.btnResultBack.Click += new System.EventHandler(this.btnTulosTakaisin_Click);
            // 
            // btnidontknow
            // 
            this.btnidontknow.Location = new System.Drawing.Point(352, 240);
            this.btnidontknow.Name = "btnidontknow";
            this.btnidontknow.Size = new System.Drawing.Size(100, 40);
            this.btnidontknow.TabIndex = 4;
            this.btnidontknow.Text = "En tiedä";
            this.btnidontknow.UseVisualStyleBackColor = true;
            this.btnidontknow.Click += new System.EventHandler(this.btnidontknow_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(331, 419);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(132, 40);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Historia";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(816, 499);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelAnswer);
            this.Controls.Add(this.panelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PC Troubleshooter";
            this.panelMainMenu.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button btnNoDisplay;
        private System.Windows.Forms.Button btnNoInternet;
        private System.Windows.Forms.Button btnIsSlow;
        private System.Windows.Forms.Button btnOverheats;
        private System.Windows.Forms.Button btnDoesNotStart;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerNo;
        private System.Windows.Forms.Button btnAnswerYes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.Button btnResultBack;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Button btnidontknow;
        private System.Windows.Forms.Button btnHistory;
    }
}