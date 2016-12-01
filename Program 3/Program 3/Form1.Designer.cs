namespace Program_3
{
    partial class program_3_form
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
            this.classStandingGroupBox = new System.Windows.Forms.GroupBox();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeButton = new System.Windows.Forms.Button();
            this.regTimeLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.classStandingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classStandingGroupBox
            // 
            this.classStandingGroupBox.Controls.Add(this.freshmanRadioButton);
            this.classStandingGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.classStandingGroupBox.Controls.Add(this.juniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.seniorRadioButton);
            this.classStandingGroupBox.Location = new System.Drawing.Point(56, 12);
            this.classStandingGroupBox.Name = "classStandingGroupBox";
            this.classStandingGroupBox.Size = new System.Drawing.Size(200, 119);
            this.classStandingGroupBox.TabIndex = 0;
            this.classStandingGroupBox.TabStop = false;
            this.classStandingGroupBox.Text = "Class Standing:";
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(9, 93);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadioButton.TabIndex = 3;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(9, 68);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadioButton.TabIndex = 2;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(9, 44);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioButton.TabIndex = 1;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(9, 20);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioButton.TabIndex = 0;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 145);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(129, 145);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 2;
            // 
            // findRegTimeButton
            // 
            this.findRegTimeButton.BackColor = System.Drawing.Color.Silver;
            this.findRegTimeButton.Location = new System.Drawing.Point(106, 180);
            this.findRegTimeButton.Name = "findRegTimeButton";
            this.findRegTimeButton.Size = new System.Drawing.Size(96, 38);
            this.findRegTimeButton.TabIndex = 3;
            this.findRegTimeButton.Text = "Find Registration Time";
            this.findRegTimeButton.UseVisualStyleBackColor = false;
            this.findRegTimeButton.Click += new System.EventHandler(this.findRegTimeButton_Click);
            // 
            // regTimeLabel
            // 
            this.regTimeLabel.Location = new System.Drawing.Point(12, 232);
            this.regTimeLabel.Name = "regTimeLabel";
            this.regTimeLabel.Size = new System.Drawing.Size(113, 32);
            this.regTimeLabel.TabIndex = 4;
            this.regTimeLabel.Text = "Your earliest registration time is:";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(115, 232);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(145, 32);
            this.outputLabel.TabIndex = 5;
            // 
            // program_3_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(310, 273);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.regTimeLabel);
            this.Controls.Add(this.findRegTimeButton);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.classStandingGroupBox);
            this.Name = "program_3_form";
            this.Text = "Program 3";
            this.classStandingGroupBox.ResumeLayout(false);
            this.classStandingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox classStandingGroupBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeButton;
        private System.Windows.Forms.Label regTimeLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
    }
}

