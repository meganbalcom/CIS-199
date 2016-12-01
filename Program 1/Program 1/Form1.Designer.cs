namespace Program_1
{
    partial class program1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program1Form));
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.totalSqFtOutputLabel = new System.Windows.Forms.Label();
            this.numberGallonsLabel = new System.Windows.Forms.Label();
            this.numberGallonsOutputLabel = new System.Windows.Forms.Label();
            this.hoursLaborLabel = new System.Windows.Forms.Label();
            this.hoursLaborOutputLabel = new System.Windows.Forms.Label();
            this.costPaintLabel = new System.Windows.Forms.Label();
            this.costPaintOutputLabel = new System.Windows.Forms.Label();
            this.costLaborLabel = new System.Windows.Forms.Label();
            this.costLaborOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.gallonPriceInputTextBox = new System.Windows.Forms.TextBox();
            this.gallonPriceInputLabel = new System.Windows.Forms.Label();
            this.coatsDesiredTextBox = new System.Windows.Forms.TextBox();
            this.coatsDesiredLabel = new System.Windows.Forms.Label();
            this.sqftInputTextBox = new System.Windows.Forms.TextBox();
            this.sqftInputLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.BackColor = System.Drawing.Color.FloralWhite;
            this.calculateCostButton.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCostButton.Location = new System.Drawing.Point(244, 264);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(150, 37);
            this.calculateCostButton.TabIndex = 0;
            this.calculateCostButton.Text = "Calculate Cost";
            this.calculateCostButton.UseVisualStyleBackColor = false;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.BackColor = System.Drawing.Color.FloralWhite;
            this.clearInputButton.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputButton.Location = new System.Drawing.Point(213, 307);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(88, 28);
            this.clearInputButton.TabIndex = 1;
            this.clearInputButton.Text = "Clear";
            this.clearInputButton.UseVisualStyleBackColor = false;
            this.clearInputButton.Click += new System.EventHandler(this.clearInputButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(342, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalSqFtLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSqFtLabel.Location = new System.Drawing.Point(371, 20);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(103, 15);
            this.totalSqFtLabel.TabIndex = 9;
            this.totalSqFtLabel.Text = "Total square feet:";
            // 
            // totalSqFtOutputLabel
            // 
            this.totalSqFtOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.totalSqFtOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutputLabel.Location = new System.Drawing.Point(480, 20);
            this.totalSqFtOutputLabel.Name = "totalSqFtOutputLabel";
            this.totalSqFtOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.totalSqFtOutputLabel.TabIndex = 10;
            // 
            // numberGallonsLabel
            // 
            this.numberGallonsLabel.AutoSize = true;
            this.numberGallonsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberGallonsLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberGallonsLabel.ForeColor = System.Drawing.Color.Black;
            this.numberGallonsLabel.Location = new System.Drawing.Point(370, 66);
            this.numberGallonsLabel.Name = "numberGallonsLabel";
            this.numberGallonsLabel.Size = new System.Drawing.Size(110, 15);
            this.numberGallonsLabel.TabIndex = 11;
            this.numberGallonsLabel.Text = "Number of gallons:";
            // 
            // numberGallonsOutputLabel
            // 
            this.numberGallonsOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.numberGallonsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberGallonsOutputLabel.Location = new System.Drawing.Point(480, 63);
            this.numberGallonsOutputLabel.Name = "numberGallonsOutputLabel";
            this.numberGallonsOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.numberGallonsOutputLabel.TabIndex = 12;
            // 
            // hoursLaborLabel
            // 
            this.hoursLaborLabel.AutoSize = true;
            this.hoursLaborLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursLaborLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLaborLabel.Location = new System.Drawing.Point(386, 106);
            this.hoursLaborLabel.Name = "hoursLaborLabel";
            this.hoursLaborLabel.Size = new System.Drawing.Size(88, 15);
            this.hoursLaborLabel.TabIndex = 13;
            this.hoursLaborLabel.Text = "Hours of labor:";
            // 
            // hoursLaborOutputLabel
            // 
            this.hoursLaborOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.hoursLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLaborOutputLabel.Location = new System.Drawing.Point(480, 104);
            this.hoursLaborOutputLabel.Name = "hoursLaborOutputLabel";
            this.hoursLaborOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.hoursLaborOutputLabel.TabIndex = 14;
            // 
            // costPaintLabel
            // 
            this.costPaintLabel.BackColor = System.Drawing.Color.Transparent;
            this.costPaintLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPaintLabel.Location = new System.Drawing.Point(386, 146);
            this.costPaintLabel.Name = "costPaintLabel";
            this.costPaintLabel.Size = new System.Drawing.Size(94, 22);
            this.costPaintLabel.TabIndex = 15;
            this.costPaintLabel.Text = "Cost of paint:";
            // 
            // costPaintOutputLabel
            // 
            this.costPaintOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.costPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintOutputLabel.Location = new System.Drawing.Point(480, 146);
            this.costPaintOutputLabel.Name = "costPaintOutputLabel";
            this.costPaintOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.costPaintOutputLabel.TabIndex = 16;
            // 
            // costLaborLabel
            // 
            this.costLaborLabel.AutoSize = true;
            this.costLaborLabel.BackColor = System.Drawing.Color.Transparent;
            this.costLaborLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLaborLabel.Location = new System.Drawing.Point(394, 187);
            this.costLaborLabel.Name = "costLaborLabel";
            this.costLaborLabel.Size = new System.Drawing.Size(80, 15);
            this.costLaborLabel.TabIndex = 17;
            this.costLaborLabel.Text = "Cost of labor:";
            // 
            // costLaborOutputLabel
            // 
            this.costLaborOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.costLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLaborOutputLabel.Location = new System.Drawing.Point(480, 187);
            this.costLaborOutputLabel.Name = "costLaborOutputLabel";
            this.costLaborOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.costLaborOutputLabel.TabIndex = 18;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalCostLabel.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(407, 227);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(65, 15);
            this.totalCostLabel.TabIndex = 19;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(478, 227);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(107, 22);
            this.totalCostOutputLabel.TabIndex = 20;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(17, 20);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(315, 38);
            this.instructionsLabel.TabIndex = 21;
            this.instructionsLabel.Text = "Input the three values below:";
            this.instructionsLabel.Click += new System.EventHandler(this.instructions_label_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.inputGroupBox.Controls.Add(this.gallonPriceInputTextBox);
            this.inputGroupBox.Controls.Add(this.gallonPriceInputLabel);
            this.inputGroupBox.Controls.Add(this.coatsDesiredTextBox);
            this.inputGroupBox.Controls.Add(this.coatsDesiredLabel);
            this.inputGroupBox.Controls.Add(this.sqftInputTextBox);
            this.inputGroupBox.Controls.Add(this.sqftInputLabel);
            this.inputGroupBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(17, 74);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(315, 175);
            this.inputGroupBox.TabIndex = 22;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input:";
            // 
            // gallonPriceInputTextBox
            // 
            this.gallonPriceInputTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonPriceInputTextBox.Location = new System.Drawing.Point(186, 121);
            this.gallonPriceInputTextBox.Name = "gallonPriceInputTextBox";
            this.gallonPriceInputTextBox.Size = new System.Drawing.Size(110, 25);
            this.gallonPriceInputTextBox.TabIndex = 9;
            // 
            // gallonPriceInputLabel
            // 
            this.gallonPriceInputLabel.AutoSize = true;
            this.gallonPriceInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.gallonPriceInputLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonPriceInputLabel.Location = new System.Drawing.Point(38, 126);
            this.gallonPriceInputLabel.Name = "gallonPriceInputLabel";
            this.gallonPriceInputLabel.Size = new System.Drawing.Size(142, 15);
            this.gallonPriceInputLabel.TabIndex = 8;
            this.gallonPriceInputLabel.Text = "Price of paint per gallon:";
            // 
            // coatsDesiredTextBox
            // 
            this.coatsDesiredTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coatsDesiredTextBox.Location = new System.Drawing.Point(186, 75);
            this.coatsDesiredTextBox.Name = "coatsDesiredTextBox";
            this.coatsDesiredTextBox.Size = new System.Drawing.Size(110, 25);
            this.coatsDesiredTextBox.TabIndex = 7;
            // 
            // coatsDesiredLabel
            // 
            this.coatsDesiredLabel.AutoSize = true;
            this.coatsDesiredLabel.BackColor = System.Drawing.Color.Transparent;
            this.coatsDesiredLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coatsDesiredLabel.Location = new System.Drawing.Point(33, 80);
            this.coatsDesiredLabel.Name = "coatsDesiredLabel";
            this.coatsDesiredLabel.Size = new System.Drawing.Size(147, 15);
            this.coatsDesiredLabel.TabIndex = 6;
            this.coatsDesiredLabel.Text = "Number of coats desired:";
            // 
            // sqftInputTextBox
            // 
            this.sqftInputTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqftInputTextBox.Location = new System.Drawing.Point(186, 27);
            this.sqftInputTextBox.Name = "sqftInputTextBox";
            this.sqftInputTextBox.Size = new System.Drawing.Size(111, 25);
            this.sqftInputTextBox.TabIndex = 5;
            // 
            // sqftInputLabel
            // 
            this.sqftInputLabel.AutoSize = true;
            this.sqftInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.sqftInputLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqftInputLabel.Location = new System.Drawing.Point(30, 32);
            this.sqftInputLabel.Name = "sqftInputLabel";
            this.sqftInputLabel.Size = new System.Drawing.Size(150, 15);
            this.sqftInputLabel.TabIndex = 4;
            this.sqftInputLabel.Text = "Square feet of wall space:";
            // 
            // program1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 354);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.costLaborOutputLabel);
            this.Controls.Add(this.costLaborLabel);
            this.Controls.Add(this.costPaintOutputLabel);
            this.Controls.Add(this.costPaintLabel);
            this.Controls.Add(this.hoursLaborOutputLabel);
            this.Controls.Add(this.hoursLaborLabel);
            this.Controls.Add(this.numberGallonsOutputLabel);
            this.Controls.Add(this.numberGallonsLabel);
            this.Controls.Add(this.totalSqFtOutputLabel);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.calculateCostButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "program1Form";
            this.Text = "Paint Job Estimator";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label totalSqFtOutputLabel;
        private System.Windows.Forms.Label numberGallonsLabel;
        private System.Windows.Forms.Label numberGallonsOutputLabel;
        private System.Windows.Forms.Label hoursLaborLabel;
        private System.Windows.Forms.Label hoursLaborOutputLabel;
        private System.Windows.Forms.Label costPaintLabel;
        private System.Windows.Forms.Label costPaintOutputLabel;
        private System.Windows.Forms.Label costLaborLabel;
        private System.Windows.Forms.Label costLaborOutputLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox gallonPriceInputTextBox;
        private System.Windows.Forms.Label gallonPriceInputLabel;
        private System.Windows.Forms.TextBox coatsDesiredTextBox;
        private System.Windows.Forms.Label coatsDesiredLabel;
        private System.Windows.Forms.TextBox sqftInputTextBox;
        private System.Windows.Forms.Label sqftInputLabel;
    }
}

