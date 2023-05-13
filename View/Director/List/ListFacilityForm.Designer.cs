namespace FinalWindow.View.Director.List
{
    partial class ListFacilityForm
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
            this.dataGridView_listFacility = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listFacility
            // 
            this.dataGridView_listFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listFacility.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_listFacility.Name = "dataGridView_listFacility";
            this.dataGridView_listFacility.RowHeadersWidth = 51;
            this.dataGridView_listFacility.RowTemplate.Height = 24;
            this.dataGridView_listFacility.Size = new System.Drawing.Size(550, 262);
            this.dataGridView_listFacility.TabIndex = 0;
            this.dataGridView_listFacility.Click += new System.EventHandler(this.dataGridView_listFacility_Click);
            // 
            // ListFacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(584, 302);
            this.Controls.Add(this.dataGridView_listFacility);
            this.Name = "ListFacilityForm";
            this.Text = "ListFacilityForm";
            this.Load += new System.EventHandler(this.ListFacilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFacility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listFacility;
    }
}