namespace Program_4
{
    partial class Program_4_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program_4_Form));
            this.originZipTxtBox = new System.Windows.Forms.TextBox();
            this.destinationZipTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.widthTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destinationZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.sendToLvilleBtn = new System.Windows.Forms.Button();
            this.sendFromLville = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipTxtBox
            // 
            this.originZipTxtBox.Location = new System.Drawing.Point(89, 22);
            this.originZipTxtBox.Name = "originZipTxtBox";
            this.originZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.originZipTxtBox.TabIndex = 0;
            // 
            // destinationZipTxtBox
            // 
            this.destinationZipTxtBox.Location = new System.Drawing.Point(89, 61);
            this.destinationZipTxtBox.Name = "destinationZipTxtBox";
            this.destinationZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.destinationZipTxtBox.TabIndex = 1;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(89, 102);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTxtBox.TabIndex = 2;
            // 
            // widthTxtBox
            // 
            this.widthTxtBox.Location = new System.Drawing.Point(89, 147);
            this.widthTxtBox.Name = "widthTxtBox";
            this.widthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.widthTxtBox.TabIndex = 3;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(89, 192);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.heightTxtBox.TabIndex = 4;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(89, 236);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.weightTxtBox.TabIndex = 5;
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.BackColor = System.Drawing.Color.Transparent;
            this.originZipLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originZipLabel.ForeColor = System.Drawing.Color.Black;
            this.originZipLabel.Location = new System.Drawing.Point(23, 26);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(63, 14);
            this.originZipLabel.TabIndex = 0;
            this.originZipLabel.Text = "Origin Zip:";
            // 
            // destinationZipLabel
            // 
            this.destinationZipLabel.AutoSize = true;
            this.destinationZipLabel.BackColor = System.Drawing.Color.Transparent;
            this.destinationZipLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationZipLabel.Location = new System.Drawing.Point(-4, 64);
            this.destinationZipLabel.Name = "destinationZipLabel";
            this.destinationZipLabel.Size = new System.Drawing.Size(92, 14);
            this.destinationZipLabel.TabIndex = 0;
            this.destinationZipLabel.Text = "Destination Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(-3, 105);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(92, 14);
            this.lengthLabel.TabIndex = 0;
            this.lengthLabel.Text = "Length (inches):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.Transparent;
            this.widthLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(0, 149);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(87, 14);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width (inches):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.BackColor = System.Drawing.Color.Transparent;
            this.heightLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(-2, 195);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(90, 14);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height (inches):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(11, 239);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(75, 14);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight (lbs):";
            // 
            // sendToLvilleBtn
            // 
            this.sendToLvilleBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToLvilleBtn.Location = new System.Drawing.Point(607, 73);
            this.sendToLvilleBtn.Name = "sendToLvilleBtn";
            this.sendToLvilleBtn.Size = new System.Drawing.Size(113, 23);
            this.sendToLvilleBtn.TabIndex = 8;
            this.sendToLvilleBtn.Text = "Send to UofL";
            this.sendToLvilleBtn.UseVisualStyleBackColor = true;
            this.sendToLvilleBtn.Click += new System.EventHandler(this.sendToLvilleBtn_Click);
            // 
            // sendFromLville
            // 
            this.sendFromLville.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFromLville.Location = new System.Drawing.Point(607, 120);
            this.sendFromLville.Name = "sendFromLville";
            this.sendFromLville.Size = new System.Drawing.Size(113, 23);
            this.sendFromLville.TabIndex = 9;
            this.sendFromLville.Text = "Send from UofL";
            this.sendFromLville.UseVisualStyleBackColor = true;
            this.sendFromLville.Click += new System.EventHandler(this.sendFromLville_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.ItemHeight = 14;
            this.packageListBox.Location = new System.Drawing.Point(392, 22);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(199, 256);
            this.packageListBox.TabIndex = 7;
            // 
            // detailsBtn
            // 
            this.detailsBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsBtn.Location = new System.Drawing.Point(624, 230);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(75, 23);
            this.detailsBtn.TabIndex = 10;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(89, 282);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(104, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Package";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Program_4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 310);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.sendFromLville);
            this.Controls.Add(this.sendToLvilleBtn);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationZipLabel);
            this.Controls.Add(this.originZipLabel);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.widthTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.destinationZipTxtBox);
            this.Controls.Add(this.originZipTxtBox);
            this.DoubleBuffered = true;
            this.Name = "Program_4_Form";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originZipTxtBox;
        private System.Windows.Forms.TextBox destinationZipTxtBox;
        private System.Windows.Forms.TextBox lengthTxtBox;
        private System.Windows.Forms.TextBox widthTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destinationZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button sendToLvilleBtn;
        private System.Windows.Forms.Button sendFromLville;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

