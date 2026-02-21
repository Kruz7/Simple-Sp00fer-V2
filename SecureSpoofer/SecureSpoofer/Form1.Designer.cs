namespace SecureSpoofer
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
            btnSpoofHWID = new Button();
            chkFiveGuard = new CheckBox();
            chkProtection = new CheckBox();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // btnSpoofHWID
            // 
            btnSpoofHWID.Location = new Point(167, 104);
            btnSpoofHWID.Name = "btnSpoofHWID";
            btnSpoofHWID.Size = new Size(139, 35);
            btnSpoofHWID.TabIndex = 0;
            btnSpoofHWID.Text = "Spoof HWID";
            btnSpoofHWID.UseVisualStyleBackColor = true;
            // 
            // chkFiveGuard
            // 
            chkFiveGuard.AutoSize = true;
            chkFiveGuard.Location = new Point(71, 163);
            chkFiveGuard.Name = "chkFiveGuard";
            chkFiveGuard.Size = new Size(135, 19);
            chkFiveGuard.TabIndex = 1;
            chkFiveGuard.Text = "Anti-Ban FiveGuard";
            chkFiveGuard.UseVisualStyleBackColor = true;
            // 
            // chkProtection
            // 
            chkProtection.AutoSize = true;
            chkProtection.Location = new Point(272, 163);
            chkProtection.Name = "chkProtection";
            chkProtection.Size = new Size(143, 19);
            chkProtection.TabIndex = 2;
            chkProtection.Text = "Advanced Protection";
            chkProtection.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(40, 15);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9;
            ClientSize = new Size(487, 285);
            Controls.Add(lblInfo);
            Controls.Add(chkProtection);
            Controls.Add(chkFiveGuard);
            Controls.Add(btnSpoofHWID);
            Cursor = Cursors.Cross;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            ShowIcon = false;
            Text = "SecureSpoff";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpoofHWID;
        private CheckBox chkFiveGuard;
        private CheckBox chkProtection;
        private Label lblInfo;
    }
}
