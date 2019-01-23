namespace FileModifier
{
    partial class FileModifier
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
            this.btnOpenflies = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSelectDstFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDestfolder = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenflies
            // 
            this.btnOpenflies.Location = new System.Drawing.Point(55, 22);
            this.btnOpenflies.Name = "btnOpenflies";
            this.btnOpenflies.Size = new System.Drawing.Size(120, 45);
            this.btnOpenflies.TabIndex = 0;
            this.btnOpenflies.Text = "Select files";
            this.btnOpenflies.UseVisualStyleBackColor = true;
            this.btnOpenflies.Click += new System.EventHandler(this.btnOpenflies_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(55, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(639, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(574, 334);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 45);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify files";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSelectDstFolder
            // 
            this.btnSelectDstFolder.Location = new System.Drawing.Point(55, 334);
            this.btnSelectDstFolder.Name = "btnSelectDstFolder";
            this.btnSelectDstFolder.Size = new System.Drawing.Size(120, 45);
            this.btnSelectDstFolder.TabIndex = 3;
            this.btnSelectDstFolder.Text = "Select Destination";
            this.btnSelectDstFolder.UseVisualStyleBackColor = true;
            this.btnSelectDstFolder.Click += new System.EventHandler(this.btnSelectDstFolder_Click);
            // 
            // txtDestfolder
            // 
            this.txtDestfolder.Enabled = false;
            this.txtDestfolder.Location = new System.Drawing.Point(181, 334);
            this.txtDestfolder.Name = "txtDestfolder";
            this.txtDestfolder.Size = new System.Drawing.Size(344, 20);
            this.txtDestfolder.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(181, 355);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // Key
            // 
            this.Key.DataPropertyName = "Key";
            this.Key.HeaderText = "Sl";
            this.Key.Name = "Key";
            this.Key.Width = 50;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "File Name";
            this.Value.Name = "Value";
            this.Value.Width = 550;
            // 
            // FileModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtDestfolder);
            this.Controls.Add(this.btnSelectDstFolder);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpenflies);
            this.Name = "FileModifier";
            this.Text = "Bulk file Update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenflies;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSelectDstFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtDestfolder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

