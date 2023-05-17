
namespace FinalWindow.View.Director.FacilityCRUD
{
    partial class AddMangerToFacilityForm
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
            this.dataGridView_listManager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listManager
            // 
            this.dataGridView_listManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_listManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listManager.Location = new System.Drawing.Point(21, 12);
            this.dataGridView_listManager.Name = "dataGridView_listManager";
            this.dataGridView_listManager.RowHeadersWidth = 51;
            this.dataGridView_listManager.RowTemplate.Height = 24;
            this.dataGridView_listManager.Size = new System.Drawing.Size(1297, 415);
            this.dataGridView_listManager.TabIndex = 1;
            this.dataGridView_listManager.DoubleClick += new System.EventHandler(this.dataGridView_listManager_DoubleClick);
            // 
            // AddMangerToFacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.dataGridView_listManager);
            this.Name = "AddMangerToFacilityForm";
            this.Text = "AddMangerToFacilityForm";
            this.Load += new System.EventHandler(this.AddMangerToFacilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listManager;
    }
}