namespace BloodBank
{
    partial class DonorTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorTable));
            this.dataGrid_donor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_deleteDonor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateDonor = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_donor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_donor
            // 
            this.dataGrid_donor.AllowUserToDeleteRows = false;
            this.dataGrid_donor.AllowUserToResizeColumns = false;
            this.dataGrid_donor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_donor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_donor.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_donor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_donor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_donor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_donor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_donor.ColumnHeadersHeight = 28;
            this.dataGrid_donor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_donor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_donor.EnableHeadersVisualStyles = false;
            this.dataGrid_donor.GridColor = System.Drawing.Color.Red;
            this.dataGrid_donor.Location = new System.Drawing.Point(-1, 3);
            this.dataGrid_donor.Name = "dataGrid_donor";
            this.dataGrid_donor.ReadOnly = true;
            this.dataGrid_donor.RowHeadersVisible = false;
            this.dataGrid_donor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid_donor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_donor.Size = new System.Drawing.Size(754, 403);
            this.dataGrid_donor.TabIndex = 0;
            this.dataGrid_donor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGrid_donor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_donor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.Height = 28;
            this.dataGrid_donor.ThemeStyle.ReadOnly = true;
            this.dataGrid_donor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_donor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGrid_donor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_donor.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid_donor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_donor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_deleteDonor
            // 
            this.btn_deleteDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_deleteDonor.CheckedState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.CustomImages.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.FillColor = System.Drawing.Color.Tomato;
            this.btn_deleteDonor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteDonor.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_deleteDonor.HoverState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDonor.Image")));
            this.btn_deleteDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deleteDonor.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_deleteDonor.Location = new System.Drawing.Point(443, 428);
            this.btn_deleteDonor.Name = "btn_deleteDonor";
            this.btn_deleteDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_deleteDonor.ShadowDecoration.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Size = new System.Drawing.Size(200, 40);
            this.btn_deleteDonor.TabIndex = 4;
            this.btn_deleteDonor.Text = "Delete Donor ";
            this.btn_deleteDonor.TextOffset = new System.Drawing.Point(23, 0);
            this.btn_deleteDonor.UseTransparentBackground = true;
            this.btn_deleteDonor.Click += new System.EventHandler(this.btn_deleteDonor_Click);
            // 
            // btn_updateDonor
            // 
            this.btn_updateDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_updateDonor.CheckedState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.CustomImages.Parent = this.btn_updateDonor;
            this.btn_updateDonor.FillColor = System.Drawing.Color.Tomato;
            this.btn_updateDonor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDonor.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_updateDonor.HoverState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateDonor.Image")));
            this.btn_updateDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_updateDonor.ImageOffset = new System.Drawing.Point(30, 0);
            this.btn_updateDonor.Location = new System.Drawing.Point(222, 428);
            this.btn_updateDonor.Name = "btn_updateDonor";
            this.btn_updateDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_updateDonor.ShadowDecoration.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Size = new System.Drawing.Size(200, 40);
            this.btn_updateDonor.TabIndex = 3;
            this.btn_updateDonor.Text = "Update Donor ";
            this.btn_updateDonor.TextOffset = new System.Drawing.Point(26, 0);
            this.btn_updateDonor.UseTransparentBackground = true;
            this.btn_updateDonor.Click += new System.EventHandler(this.btn_updateDonor_Click);
            // 
            // DonorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 493);
            this.Controls.Add(this.btn_deleteDonor);
            this.Controls.Add(this.btn_updateDonor);
            this.Controls.Add(this.dataGrid_donor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorTable";
            this.Load += new System.EventHandler(this.DonorTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_donor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_donor;
        private Guna.UI2.WinForms.Guna2Button btn_deleteDonor;
        private Guna.UI2.WinForms.Guna2Button btn_updateDonor;
    }
}