namespace DB_project
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
            this.btnAddFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetElement = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnProcessDirectory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(23, 22);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(95, 23);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "addFile";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGetElement
            // 
            this.btnGetElement.Location = new System.Drawing.Point(23, 80);
            this.btnGetElement.Name = "btnGetElement";
            this.btnGetElement.Size = new System.Drawing.Size(95, 23);
            this.btnGetElement.TabIndex = 2;
            this.btnGetElement.Text = "getFromBase";
            this.btnGetElement.UseVisualStyleBackColor = true;
            this.btnGetElement.Click += new System.EventHandler(this.btnGetElement_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnProcessDirectory
            // 
            this.btnProcessDirectory.Location = new System.Drawing.Point(124, 341);
            this.btnProcessDirectory.Name = "btnProcessDirectory";
            this.btnProcessDirectory.Size = new System.Drawing.Size(166, 23);
            this.btnProcessDirectory.TabIndex = 4;
            this.btnProcessDirectory.Text = "Process Directory";
            this.btnProcessDirectory.UseVisualStyleBackColor = true;
            this.btnProcessDirectory.Click += new System.EventHandler(this.btnProcessDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 460);
            this.Controls.Add(this.btnProcessDirectory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGetElement);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetElement;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnProcessDirectory;
    }
}

