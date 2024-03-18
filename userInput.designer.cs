namespace FOQA
{
    partial class userInput
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
            this.TextToInput = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextToInput
            // 
            this.TextToInput.AutoSize = true;
            this.TextToInput.Location = new System.Drawing.Point(54, 37);
            this.TextToInput.Name = "TextToInput";
            this.TextToInput.Size = new System.Drawing.Size(65, 13);
            this.TextToInput.TabIndex = 0;
            this.TextToInput.Text = "TextToInput";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(57, 76);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(582, 20);
            this.textResult.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(564, 139);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(473, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // userInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 191);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.TextToInput);
            this.Name = "userInput";
            this.Text = "userInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextToInput;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
    }
}