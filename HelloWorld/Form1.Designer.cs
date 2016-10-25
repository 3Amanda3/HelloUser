namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.rdbFrench = new System.Windows.Forms.RadioButton();
            this.rdbSpanish = new System.Windows.Forms.RadioButton();
            this.grbLanguage = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDisplayDays = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAgeDisplay = new System.Windows.Forms.Button();
            this.grbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 283);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(345, 196);
            this.lblResult.TabIndex = 2;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(29, 116);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(153, 13);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "What language do you speak?";
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Location = new System.Drawing.Point(35, 19);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rdbEnglish.TabIndex = 5;
            this.rdbEnglish.TabStop = true;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            this.rdbEnglish.CheckedChanged += new System.EventHandler(this.rdbEnglish_CheckedChanged);
            // 
            // rdbFrench
            // 
            this.rdbFrench.AutoSize = true;
            this.rdbFrench.Location = new System.Drawing.Point(35, 42);
            this.rdbFrench.Name = "rdbFrench";
            this.rdbFrench.Size = new System.Drawing.Size(58, 17);
            this.rdbFrench.TabIndex = 6;
            this.rdbFrench.TabStop = true;
            this.rdbFrench.Text = "French";
            this.rdbFrench.UseVisualStyleBackColor = true;
            this.rdbFrench.CheckedChanged += new System.EventHandler(this.rdbFrench_CheckedChanged);
            // 
            // rdbSpanish
            // 
            this.rdbSpanish.AutoSize = true;
            this.rdbSpanish.Location = new System.Drawing.Point(35, 65);
            this.rdbSpanish.Name = "rdbSpanish";
            this.rdbSpanish.Size = new System.Drawing.Size(63, 17);
            this.rdbSpanish.TabIndex = 7;
            this.rdbSpanish.TabStop = true;
            this.rdbSpanish.Text = "Spanish";
            this.rdbSpanish.UseVisualStyleBackColor = true;
            this.rdbSpanish.CheckedChanged += new System.EventHandler(this.rdbSpanish_CheckedChanged);
            // 
            // grbLanguage
            // 
            this.grbLanguage.Controls.Add(this.rdbEnglish);
            this.grbLanguage.Controls.Add(this.rdbSpanish);
            this.grbLanguage.Controls.Add(this.rdbFrench);
            this.grbLanguage.Location = new System.Drawing.Point(32, 152);
            this.grbLanguage.Name = "grbLanguage";
            this.grbLanguage.Size = new System.Drawing.Size(200, 100);
            this.grbLanguage.TabIndex = 8;
            this.grbLanguage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "What is your name?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // lblDisplayDays
            // 
            this.lblDisplayDays.Location = new System.Drawing.Point(346, 152);
            this.lblDisplayDays.Name = "lblDisplayDays";
            this.lblDisplayDays.Size = new System.Drawing.Size(229, 128);
            this.lblDisplayDays.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(376, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 15;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(373, 29);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(110, 13);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Please enter your age";
            // 
            // btnAgeDisplay
            // 
            this.btnAgeDisplay.Location = new System.Drawing.Point(376, 105);
            this.btnAgeDisplay.Name = "btnAgeDisplay";
            this.btnAgeDisplay.Size = new System.Drawing.Size(107, 24);
            this.btnAgeDisplay.TabIndex = 17;
            this.btnAgeDisplay.Text = "Click to find out!";
            this.btnAgeDisplay.UseVisualStyleBackColor = true;
            this.btnAgeDisplay.Click += new System.EventHandler(this.btnAgeDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 622);
            this.Controls.Add(this.btnAgeDisplay);
            this.Controls.Add(this.lblDisplayDays);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grbLanguage);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbLanguage.ResumeLayout(false);
            this.grbLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.RadioButton rdbFrench;
        private System.Windows.Forms.RadioButton rdbSpanish;
        private System.Windows.Forms.GroupBox grbLanguage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDisplayDays;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAgeDisplay;
    }
}

