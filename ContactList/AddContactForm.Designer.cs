namespace ContactList
{
    partial class AddContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelExtraInfo;

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
            this.components = new System.ComponentModel.Container();
            this.labelExtraInfo = new System.Windows.Forms.Label();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // labelExtraInfo
            // 
            this.labelExtraInfo.AutoSize = true;
            this.labelExtraInfo.Location = new System.Drawing.Point(50, 100);
            this.labelExtraInfo.Name = "labelExtraInfo";
            this.labelExtraInfo.Size = new System.Drawing.Size(120, 17);
            this.labelExtraInfo.TabIndex = 2;
            this.labelExtraInfo.Text = "Thông tin bổ sung";
            // 
            // AddContactForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExtraInfo);
            this.Text = "Form1";
        }

        #endregion
    }
}