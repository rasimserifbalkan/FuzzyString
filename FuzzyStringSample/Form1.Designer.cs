namespace FuzzyStringSample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dtgKeys = new System.Windows.Forms.DataGridView();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binResult = new System.Windows.Forms.BindingSource(this.components);
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindKeys = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKeys
            // 
            this.dtgKeys.AllowUserToAddRows = false;
            this.dtgKeys.AllowUserToDeleteRows = false;
            this.dtgKeys.AutoGenerateColumns = false;
            this.dtgKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn});
            this.dtgKeys.DataSource = this.bindKeys;
            this.dtgKeys.Location = new System.Drawing.Point(33, 57);
            this.dtgKeys.Name = "dtgKeys";
            this.dtgKeys.ReadOnly = true;
            this.dtgKeys.Size = new System.Drawing.Size(288, 150);
            this.dtgKeys.TabIndex = 0;
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(139, 28);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(75, 23);
            this.btnAddKey.TabIndex = 1;
            this.btnAddKey.Text = "Add";
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.BtnAddKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(33, 31);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 213);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dtgResult
            // 
            this.dtgResult.AllowUserToAddRows = false;
            this.dtgResult.AllowUserToDeleteRows = false;
            this.dtgResult.AutoGenerateColumns = false;
            this.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn1});
            this.dtgResult.DataSource = this.binResult;
            this.dtgResult.Location = new System.Drawing.Point(33, 242);
            this.dtgResult.Name = "dtgResult";
            this.dtgResult.ReadOnly = true;
            this.dtgResult.Size = new System.Drawing.Size(288, 150);
            this.dtgResult.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 213);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            57,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDown1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textDataGridViewTextBoxColumn1
            // 
            this.textDataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn1.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn1.Name = "textDataGridViewTextBoxColumn1";
            this.textDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // binResult
            // 
            this.binResult.DataSource = typeof(FuzzyStringSample.Models.KeyModel);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindKeys
            // 
            this.bindKeys.DataSource = typeof(FuzzyStringSample.Models.KeyModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.dtgResult);
            this.Controls.Add(this.dtgKeys);
            this.Name = "Form1";
            this.Text = "FUZZY SAMPLE";
            ((System.ComponentModel.ISupportInitialize)(this.dtgKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgKeys;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.BindingSource bindKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource binResult;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

