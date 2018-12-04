namespace LawHouseGUI
{
    partial class UcCases
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridCases = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.caseCrud1 = new LawHouseGUI.CaseCrud();
            this.createCaseEmpl1 = new LawHouseGUI.CreateCaseEmpl();
            ((System.ComponentModel.ISupportInitialize)(this.GridCases)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCases
            // 
            this.GridCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCases.Location = new System.Drawing.Point(0, 37);
            this.GridCases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridCases.Name = "GridCases";
            this.GridCases.RowTemplate.Height = 24;
            this.GridCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCases.Size = new System.Drawing.Size(1593, 445);
            this.GridCases.TabIndex = 0;
            this.GridCases.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCases_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sager";
            // 
            // caseCrud1
            // 
            this.caseCrud1.CaseId = 0;
            this.caseCrud1.Location = new System.Drawing.Point(4, 491);
            this.caseCrud1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.caseCrud1.Name = "caseCrud1";
            this.caseCrud1.Size = new System.Drawing.Size(970, 180);
            this.caseCrud1.TabIndex = 2;
            // 
            // createCaseEmpl1
            // 
            this.createCaseEmpl1.Location = new System.Drawing.Point(4, 681);
            this.createCaseEmpl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createCaseEmpl1.Name = "createCaseEmpl1";
            this.createCaseEmpl1.Size = new System.Drawing.Size(1505, 387);
            this.createCaseEmpl1.TabIndex = 3;
            // 
            // UcCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.createCaseEmpl1);
            this.Controls.Add(this.caseCrud1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCases);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcCases";
            this.Size = new System.Drawing.Size(1597, 1073);
            this.Load += new System.EventHandler(this.UcCases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCases;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CaseCrud caseCrud1;
        private CreateCaseEmpl createCaseEmpl1;
    }
}
