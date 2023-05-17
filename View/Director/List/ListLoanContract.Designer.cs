
namespace FinalWindow.View.Director.List
{
    partial class ListLoanContract
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
            this.tabControl_Contract = new Guna.UI2.WinForms.Guna2TabControl();
            this.Done = new System.Windows.Forms.TabPage();
            this.dataGridView_LongContract = new System.Windows.Forms.DataGridView();
            this.Doing = new System.Windows.Forms.TabPage();
            this.dataGridView_LoanContract = new System.Windows.Forms.DataGridView();
            this.tabControl_Contract.SuspendLayout();
            this.Done.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LongContract)).BeginInit();
            this.Doing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoanContract)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Contract
            // 
            this.tabControl_Contract.Controls.Add(this.Done);
            this.tabControl_Contract.Controls.Add(this.Doing);
            this.tabControl_Contract.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl_Contract.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Contract.Name = "tabControl_Contract";
            this.tabControl_Contract.SelectedIndex = 0;
            this.tabControl_Contract.Size = new System.Drawing.Size(1042, 613);
            this.tabControl_Contract.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Contract.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_Contract.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_Contract.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl_Contract.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_Contract.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Contract.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_Contract.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_Contract.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl_Contract.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_Contract.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Contract.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl_Contract.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_Contract.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl_Contract.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl_Contract.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl_Contract.TabIndex = 1;
            this.tabControl_Contract.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_Contract.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // Done
            // 
            this.Done.Controls.Add(this.dataGridView_LongContract);
            this.Done.Location = new System.Drawing.Point(4, 44);
            this.Done.Name = "Done";
            this.Done.Padding = new System.Windows.Forms.Padding(3);
            this.Done.Size = new System.Drawing.Size(1034, 565);
            this.Done.TabIndex = 0;
            this.Done.Text = "Done contract";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // dataGridView_LongContract
            // 
            this.dataGridView_LongContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LongContract.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_LongContract.Name = "dataGridView_LongContract";
            this.dataGridView_LongContract.RowHeadersWidth = 51;
            this.dataGridView_LongContract.RowTemplate.Height = 24;
            this.dataGridView_LongContract.Size = new System.Drawing.Size(1022, 553);
            this.dataGridView_LongContract.TabIndex = 1;
            // 
            // Doing
            // 
            this.Doing.Controls.Add(this.dataGridView_LoanContract);
            this.Doing.Location = new System.Drawing.Point(4, 44);
            this.Doing.Name = "Doing";
            this.Doing.Padding = new System.Windows.Forms.Padding(3);
            this.Doing.Size = new System.Drawing.Size(1034, 565);
            this.Doing.TabIndex = 1;
            this.Doing.Text = "Doing contract";
            this.Doing.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LoanContract
            // 
            this.dataGridView_LoanContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoanContract.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_LoanContract.Name = "dataGridView_LoanContract";
            this.dataGridView_LoanContract.RowHeadersWidth = 51;
            this.dataGridView_LoanContract.RowTemplate.Height = 24;
            this.dataGridView_LoanContract.Size = new System.Drawing.Size(1022, 553);
            this.dataGridView_LoanContract.TabIndex = 2;
            // 
            // ListLoanContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 637);
            this.Controls.Add(this.tabControl_Contract);
            this.Name = "ListLoanContract";
            this.Text = "ListContract";
            this.Load += new System.EventHandler(this.ListContract_Load);
            this.tabControl_Contract.ResumeLayout(false);
            this.Done.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LongContract)).EndInit();
            this.Doing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoanContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl_Contract;
        private System.Windows.Forms.TabPage Done;
        private System.Windows.Forms.TabPage Doing;
        private System.Windows.Forms.DataGridView dataGridView_LongContract;
        private System.Windows.Forms.DataGridView dataGridView_LoanContract;
    }
}