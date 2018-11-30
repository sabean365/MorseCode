namespace MorseCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.morseCodeLabel = new System.Windows.Forms.Label();
            this.morseCodeConvertedLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text to be converted to Morse Code:";
            // 
            // stringTextBox
            // 
            this.stringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTextBox.Location = new System.Drawing.Point(206, 70);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(341, 22);
            this.stringTextBox.TabIndex = 1;
            // 
            // morseCodeLabel
            // 
            this.morseCodeLabel.AutoSize = true;
            this.morseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseCodeLabel.Location = new System.Drawing.Point(202, 106);
            this.morseCodeLabel.Name = "morseCodeLabel";
            this.morseCodeLabel.Size = new System.Drawing.Size(203, 20);
            this.morseCodeLabel.TabIndex = 2;
            this.morseCodeLabel.Text = "Here is the Morse Code:";
            // 
            // morseCodeConvertedLabel
            // 
            this.morseCodeConvertedLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.morseCodeConvertedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseCodeConvertedLabel.Location = new System.Drawing.Point(203, 136);
            this.morseCodeConvertedLabel.Name = "morseCodeConvertedLabel";
            this.morseCodeConvertedLabel.Size = new System.Drawing.Size(431, 233);
            this.morseCodeConvertedLabel.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Image = global::MorseCode.Properties.Resources.button;
            this.convertButton.Location = new System.Drawing.Point(206, 388);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(114, 51);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Get Code!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = global::MorseCode.Properties.Resources.button;
            this.exitButton.Location = new System.Drawing.Point(520, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.morseCodeConvertedLabel);
            this.Controls.Add(this.morseCodeLabel);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Morse Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label morseCodeLabel;
        private System.Windows.Forms.Label morseCodeConvertedLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

