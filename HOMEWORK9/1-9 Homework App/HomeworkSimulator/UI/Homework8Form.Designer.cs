namespace HomeworkSimulator.UI
{
    partial class Homework8Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblEncryptedOutput;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label lblDecryptedOutput;
        private System.Windows.Forms.Label lblDetectedShift;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblEncryptedOutput = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.lblDecryptedOutput = new System.Windows.Forms.Label();
            this.lblDetectedShift = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(20, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(500, 100);
            this.txtInput.TabIndex = 0;

            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(20, 160);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(50, 22);
            this.txtShift.TabIndex = 1;

            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(90, 160);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(180, 160);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(20, 220);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(500, 100);
            this.txtOutput.TabIndex = 4;

            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(83, 16);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Input Text:";

            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(20, 140);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(69, 16);
            this.lblShift.TabIndex = 6;
            this.lblShift.Text = "Shift Value:";

            // 
            // lblEncryptedOutput
            // 
            this.lblEncryptedOutput.AutoSize = true;
            this.lblEncryptedOutput.Location = new System.Drawing.Point(20, 200);
            this.lblEncryptedOutput.Name = "lblEncryptedOutput";
            this.lblEncryptedOutput.Size = new System.Drawing.Size(116, 16);
            this.lblEncryptedOutput.TabIndex = 7;
            this.lblEncryptedOutput.Text = "Encrypted Output:";

            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(20, 360);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(500, 100);
            this.txtDecrypted.TabIndex = 8;

            // 
            // lblDecryptedOutput
            // 
            this.lblDecryptedOutput.AutoSize = true;
            this.lblDecryptedOutput.Location = new System.Drawing.Point(20, 340);
            this.lblDecryptedOutput.Name = "lblDecryptedOutput";
            this.lblDecryptedOutput.Size = new System.Drawing.Size(116, 16);
            this.lblDecryptedOutput.TabIndex = 9;
            this.lblDecryptedOutput.Text = "Decrypted Output:";

            // 
            // lblDetectedShift
            // 
            this.lblDetectedShift.AutoSize = true;
            this.lblDetectedShift.Location = new System.Drawing.Point(180, 340);
            this.lblDetectedShift.Name = "lblDetectedShift";
            this.lblDetectedShift.Size = new System.Drawing.Size(98, 16);
            this.lblDetectedShift.TabIndex = 10;
            this.lblDetectedShift.Text = "Detected Shift: ";

            // 
            // Homework8Form
            // 
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.lblDetectedShift);
            this.Controls.Add(this.lblDecryptedOutput);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.lblEncryptedOutput);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtInput);
            this.Name = "Homework8Form";
            this.Text = "Homework 8 - Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
