namespace GUITest
{
    partial class Services
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
            this.labelCaseName = new System.Windows.Forms.Label();
            this.ServiseDeleteBut = new System.Windows.Forms.Button();
            this.NyYdButton = new System.Windows.Forms.Button();
            this.YUpdate = new System.Windows.Forms.Button();
            this.YCommentTxt = new System.Windows.Forms.RichTextBox();
            this.YKmTxt = new System.Windows.Forms.TextBox();
            this.YHouresTxt = new System.Windows.Forms.TextBox();
            this.YDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.YEmploeeCombox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.Service_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCaseName
            // 
            this.labelCaseName.AutoSize = true;
            this.labelCaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaseName.Location = new System.Drawing.Point(201, 22);
            this.labelCaseName.Name = "labelCaseName";
            this.labelCaseName.Size = new System.Drawing.Size(60, 24);
            this.labelCaseName.TabIndex = 155;
            this.labelCaseName.Text = "label3";
            // 
            // ServiseDeleteBut
            // 
            this.ServiseDeleteBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ServiseDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiseDeleteBut.Location = new System.Drawing.Point(1164, 260);
            this.ServiseDeleteBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiseDeleteBut.Name = "ServiseDeleteBut";
            this.ServiseDeleteBut.Size = new System.Drawing.Size(161, 44);
            this.ServiseDeleteBut.TabIndex = 154;
            this.ServiseDeleteBut.Text = "Slet ydelse";
            this.ServiseDeleteBut.UseVisualStyleBackColor = false;
            this.ServiseDeleteBut.Click += new System.EventHandler(this.ServiseDeleteBut_Click);
            // 
            // NyYdButton
            // 
            this.NyYdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NyYdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyYdButton.Location = new System.Drawing.Point(1563, 260);
            this.NyYdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NyYdButton.Name = "NyYdButton";
            this.NyYdButton.Size = new System.Drawing.Size(161, 44);
            this.NyYdButton.TabIndex = 153;
            this.NyYdButton.Text = "Tilføj ydelse";
            this.NyYdButton.UseVisualStyleBackColor = false;
            this.NyYdButton.Click += new System.EventHandler(this.NyYdButton_Click);
            // 
            // YUpdate
            // 
            this.YUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YUpdate.Location = new System.Drawing.Point(1369, 260);
            this.YUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YUpdate.Name = "YUpdate";
            this.YUpdate.Size = new System.Drawing.Size(161, 44);
            this.YUpdate.TabIndex = 152;
            this.YUpdate.Text = "Opdatere ydelse";
            this.YUpdate.UseVisualStyleBackColor = true;
            this.YUpdate.Click += new System.EventHandler(this.YUpdate_Click);
            // 
            // YCommentTxt
            // 
            this.YCommentTxt.Location = new System.Drawing.Point(1513, 71);
            this.YCommentTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YCommentTxt.Name = "YCommentTxt";
            this.YCommentTxt.Size = new System.Drawing.Size(209, 130);
            this.YCommentTxt.TabIndex = 151;
            this.YCommentTxt.Text = "";
            // 
            // YKmTxt
            // 
            this.YKmTxt.Location = new System.Drawing.Point(1071, 187);
            this.YKmTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YKmTxt.Name = "YKmTxt";
            this.YKmTxt.Size = new System.Drawing.Size(209, 22);
            this.YKmTxt.TabIndex = 150;
            this.YKmTxt.Text = "0";
            // 
            // YHouresTxt
            // 
            this.YHouresTxt.Location = new System.Drawing.Point(1071, 147);
            this.YHouresTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YHouresTxt.Name = "YHouresTxt";
            this.YHouresTxt.Size = new System.Drawing.Size(209, 22);
            this.YHouresTxt.TabIndex = 149;
            this.YHouresTxt.Text = "0";
            // 
            // YDateTimePicker1
            // 
            this.YDateTimePicker1.Location = new System.Drawing.Point(1071, 107);
            this.YDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YDateTimePicker1.Name = "YDateTimePicker1";
            this.YDateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.YDateTimePicker1.TabIndex = 148;
            // 
            // YEmploeeCombox
            // 
            this.YEmploeeCombox.FormattingEnabled = true;
            this.YEmploeeCombox.Location = new System.Drawing.Point(1071, 66);
            this.YEmploeeCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YEmploeeCombox.Name = "YEmploeeCombox";
            this.YEmploeeCombox.Size = new System.Drawing.Size(209, 24);
            this.YEmploeeCombox.TabIndex = 147;
            this.YEmploeeCombox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YEmploeeCombox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(937, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 146;
            this.label18.Text = "Km:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(937, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 17);
            this.label17.TabIndex = 145;
            this.label17.Text = "Timer:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1380, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 144;
            this.label16.Text = "Ydelse:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(937, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 143;
            this.label15.Text = "Dato:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(937, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 142;
            this.label14.Text = "Medarbejder:";
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service_Id,
            this.Empl_id,
            this.Date,
            this.Comments,
            this.Hours,
            this.Km});
            this.ServiceDataGrid.Location = new System.Drawing.Point(13, 55);
            this.ServiceDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowTemplate.Height = 37;
            this.ServiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDataGrid.Size = new System.Drawing.Size(857, 322);
            this.ServiceDataGrid.TabIndex = 141;
            this.ServiceDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceDataGrid_CellMouseDoubleClick);
            // 
            // Service_Id
            // 
            this.Service_Id.FillWeight = 50F;
            this.Service_Id.HeaderText = "ID";
            this.Service_Id.Name = "Service_Id";
            this.Service_Id.ReadOnly = true;
            this.Service_Id.Visible = false;
            this.Service_Id.Width = 30;
            // 
            // Empl_id
            // 
            this.Empl_id.FillWeight = 170F;
            this.Empl_id.HeaderText = "Advokat";
            this.Empl_id.Name = "Empl_id";
            this.Empl_id.ReadOnly = true;
            this.Empl_id.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Dato";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.FillWeight = 225F;
            this.Comments.HeaderText = "Ydelse";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 225;
            // 
            // Hours
            // 
            this.Hours.FillWeight = 60F;
            this.Hours.HeaderText = "Timer";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 60;
            // 
            // Km
            // 
            this.Km.FillWeight = 65F;
            this.Km.HeaderText = "Km";
            this.Km.Name = "Km";
            this.Km.ReadOnly = true;
            this.Km.Width = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "Ydelser på sagen:";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 780);
            this.Controls.Add(this.labelCaseName);
            this.Controls.Add(this.ServiseDeleteBut);
            this.Controls.Add(this.NyYdButton);
            this.Controls.Add(this.YUpdate);
            this.Controls.Add(this.YCommentTxt);
            this.Controls.Add(this.YKmTxt);
            this.Controls.Add(this.YHouresTxt);
            this.Controls.Add(this.YDateTimePicker1);
            this.Controls.Add(this.YEmploeeCombox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ServiceDataGrid);
            this.Controls.Add(this.label2);
            this.Name = "Services";
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCaseName;
        private System.Windows.Forms.Button ServiseDeleteBut;
        private System.Windows.Forms.Button NyYdButton;
        private System.Windows.Forms.Button YUpdate;
        private System.Windows.Forms.RichTextBox YCommentTxt;
        private System.Windows.Forms.TextBox YKmTxt;
        private System.Windows.Forms.TextBox YHouresTxt;
        private System.Windows.Forms.DateTimePicker YDateTimePicker1;
        private System.Windows.Forms.ComboBox YEmploeeCombox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km;
        private System.Windows.Forms.Label label2;
    }
}