namespace Program_2
{
    partial class Program2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program2));
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.classStandingGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationButton = new System.Windows.Forms.Button();
            this.classStandingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(323, 20);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(123, 26);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(23, 19);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(294, 36);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Please enter the first letter of your last name:";
            // 
            // classStandingGroupBox
            // 
            this.classStandingGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classStandingGroupBox.Controls.Add(this.seniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.juniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.classStandingGroupBox.Controls.Add(this.freshmanRadioButton);
            this.classStandingGroupBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classStandingGroupBox.Location = new System.Drawing.Point(56, 64);
            this.classStandingGroupBox.Name = "classStandingGroupBox";
            this.classStandingGroupBox.Size = new System.Drawing.Size(349, 161);
            this.classStandingGroupBox.TabIndex = 2;
            this.classStandingGroupBox.TabStop = false;
            this.classStandingGroupBox.Text = "Please select your class standing:";
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(18, 129);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(283, 23);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.Text = "Senior (90+ hours not including Spring 2015)";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(18, 97);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(281, 23);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.Text = "Junior (60+ hours not including Spring 2015)";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(18, 64);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(312, 23);
            this.sophomoreRadioButton.TabIndex = 1;
            this.sophomoreRadioButton.Text = "Sophomore (30+ hours not including Spring 2015)";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Checked = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(18, 31);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(272, 23);
            this.freshmanRadioButton.TabIndex = 0;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman (<30 hours prior to Spring 2015)";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.registrationButton.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Location = new System.Drawing.Point(92, 244);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(126, 54);
            this.registrationButton.TabIndex = 4;
            this.registrationButton.Text = "Find registration date and time";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 310);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.classStandingGroupBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.DoubleBuffered = true;
            this.Name = "Program2";
            this.Text = "Program 2";
            this.classStandingGroupBox.ResumeLayout(false);
            this.classStandingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.GroupBox classStandingGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.Button registrationButton;
    }
}

