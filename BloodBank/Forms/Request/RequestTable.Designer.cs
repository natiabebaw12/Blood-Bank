namespace BloodBank.Forms.Request
{
    partial class RequestTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_searchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_deleteDonor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateDonor = new Guna.UI2.WinForms.Guna2Button();
            this.grid_patient = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchPatient
            // 
            this.txt_searchPatient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_searchPatient.BorderRadius = 15;
            this.txt_searchPatient.BorderThickness = 2;
            this.txt_searchPatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchPatient.DefaultText = "";
            this.txt_searchPatient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchPatient.DisabledState.Parent = this.txt_searchPatient;
            this.txt_searchPatient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchPatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchPatient.FocusedState.Parent = this.txt_searchPatient;
            this.txt_searchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchPatient.ForeColor = System.Drawing.Color.Black;
            this.txt_searchPatient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchPatient.HoverState.Parent = this.txt_searchPatient;
            this.txt_searchPatient.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_searchPatient.IconLeft")));
            this.txt_searchPatient.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_searchPatient.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txt_searchPatient.Location = new System.Drawing.Point(256, 30);
            this.txt_searchPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchPatient.Name = "txt_searchPatient";
            this.txt_searchPatient.PasswordChar = '\0';
            this.txt_searchPatient.PlaceholderText = "Search...";
            this.txt_searchPatient.SelectedText = "";
            this.txt_searchPatient.ShadowDecoration.Parent = this.txt_searchPatient;
            this.txt_searchPatient.Size = new System.Drawing.Size(230, 36);
            this.txt_searchPatient.TabIndex = 10;
            this.txt_searchPatient.TextChanged += new System.EventHandler(this.txt_searchPatient_TextChanged);
            // 
            // btn_deleteDonor
            // 
            this.btn_deleteDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_deleteDonor.BorderRadius = 20;
            this.btn_deleteDonor.CheckedState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.CustomImages.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteDonor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteDonor.ForeColor = System.Drawing.Color.White;
            this.btn_deleteDonor.HoverState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDonor.Image")));
            this.btn_deleteDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deleteDonor.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_deleteDonor.Location = new System.Drawing.Point(423, 469);
            this.btn_deleteDonor.Name = "btn_deleteDonor";
            this.btn_deleteDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_deleteDonor.ShadowDecoration.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Size = new System.Drawing.Size(140, 40);
            this.btn_deleteDonor.TabIndex = 9;
            this.btn_deleteDonor.Text = "Delete";
            this.btn_deleteDonor.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_deleteDonor.UseTransparentBackground = true;
            this.btn_deleteDonor.Click += new System.EventHandler(this.btn_deleteDonor_Click);
            // 
            // btn_updateDonor
            // 
            this.btn_updateDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_updateDonor.BorderRadius = 20;
            this.btn_updateDonor.CheckedState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.CustomImages.Parent = this.btn_updateDonor;
            this.btn_updateDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_updateDonor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDonor.ForeColor = System.Drawing.Color.White;
            this.btn_updateDonor.HoverState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateDonor.Image")));
            this.btn_updateDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_updateDonor.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_updateDonor.Location = new System.Drawing.Point(222, 469);
            this.btn_updateDonor.Name = "btn_updateDonor";
            this.btn_updateDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_updateDonor.ShadowDecoration.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Size = new System.Drawing.Size(140, 40);
            this.btn_updateDonor.TabIndex = 8;
            this.btn_updateDonor.Text = "Update";
            this.btn_updateDonor.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_updateDonor.UseTransparentBackground = true;
            this.btn_updateDonor.Click += new System.EventHandler(this.btn_updateDonor_Click);
            // 
            // grid_patient
            // 
            this.grid_patient.AllowUserToDeleteRows = false;
            this.grid_patient.AllowUserToResizeColumns = false;
            this.grid_patient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_patient.BackgroundColor = System.Drawing.Color.White;
            this.grid_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_patient.ColumnHeadersHeight = 28;
            this.grid_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_patient.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_patient.EnableHeadersVisualStyles = false;
            this.grid_patient.GridColor = System.Drawing.Color.Red;
            this.grid_patient.Location = new System.Drawing.Point(1, 74);
            this.grid_patient.Name = "grid_patient";
            this.grid_patient.ReadOnly = true;
            this.grid_patient.RowHeadersVisible = false;
            this.grid_patient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_patient.Size = new System.Drawing.Size(754, 387);
            this.grid_patient.TabIndex = 7;
            this.grid_patient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grid_patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_patient.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.grid_patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grid_patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_patient.ThemeStyle.HeaderStyle.Height = 28;
            this.grid_patient.ThemeStyle.ReadOnly = true;
            this.grid_patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grid_patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_patient.ThemeStyle.RowsStyle.Height = 22;
            this.grid_patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RequestTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 532);
            this.Controls.Add(this.txt_searchPatient);
            this.Controls.Add(this.btn_deleteDonor);
            this.Controls.Add(this.btn_updateDonor);
            this.Controls.Add(this.grid_patient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestTable";
            this.Text = "RequestTable";
            this.Load += new System.EventHandler(this.RequestTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_searchPatient;
        private Guna.UI2.WinForms.Guna2Button btn_deleteDonor;
        private Guna.UI2.WinForms.Guna2Button btn_updateDonor;
        private Guna.UI2.WinForms.Guna2DataGridView grid_patient;
    }
}