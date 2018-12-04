namespace LawHouseGUI
{
    partial class CasesForm
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
            this.ucCases1 = new LawHouseGUI.UcCases();
            this.SuspendLayout();
            // 
            // ucCases1
            // 
            this.ucCases1.Location = new System.Drawing.Point(0, 39);
            this.ucCases1.Name = "ucCases1";
            this.ucCases1.Size = new System.Drawing.Size(1630, 606);
            this.ucCases1.TabIndex = 0;
            // 
            // CasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1768, 974);
            this.Controls.Add(this.ucCases1);
            this.MinimizeBox = false;
            this.Name = "CasesForm";
            this.ShowIcon = false;
            this.Text = "Sager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UcCases ucCases1;
    }
}