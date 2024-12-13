namespace File_Extensions_Report_App
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
            this.suorce_textbox = new System.Windows.Forms.TextBox();
            this.suorce_button = new System.Windows.Forms.Button();
            this.allow_export_checkbox = new System.Windows.Forms.CheckBox();
            this.export_path_button = new System.Windows.Forms.Button();
            this.export_path_textbox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.results_table = new System.Windows.Forms.DataGridView();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).BeginInit();
            this.SuspendLayout();
            // 
            // suorce_textbox
            // 
            this.suorce_textbox.Location = new System.Drawing.Point(138, 41);
            this.suorce_textbox.Name = "suorce_textbox";
            this.suorce_textbox.ReadOnly = true;
            this.suorce_textbox.Size = new System.Drawing.Size(331, 20);
            this.suorce_textbox.TabIndex = 0;
            this.suorce_textbox.Text = "Choose suorce folder...";
            // 
            // suorce_button
            // 
            this.suorce_button.Location = new System.Drawing.Point(37, 39);
            this.suorce_button.Name = "suorce_button";
            this.suorce_button.Size = new System.Drawing.Size(75, 23);
            this.suorce_button.TabIndex = 1;
            this.suorce_button.Text = "Open";
            this.suorce_button.UseVisualStyleBackColor = true;
            this.suorce_button.Click += new System.EventHandler(this.suorce_button_Click);
            // 
            // allow_export_checkbox
            // 
            this.allow_export_checkbox.AutoSize = true;
            this.allow_export_checkbox.Location = new System.Drawing.Point(37, 87);
            this.allow_export_checkbox.Name = "allow_export_checkbox";
            this.allow_export_checkbox.Size = new System.Drawing.Size(283, 17);
            this.allow_export_checkbox.TabIndex = 2;
            this.allow_export_checkbox.Text = "Check to choose export folder and generate report file.";
            this.allow_export_checkbox.UseVisualStyleBackColor = true;
            this.allow_export_checkbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.allow_export_checkbox_MouseClick);
            // 
            // export_path_button
            // 
            this.export_path_button.Location = new System.Drawing.Point(37, 130);
            this.export_path_button.Name = "export_path_button";
            this.export_path_button.Size = new System.Drawing.Size(75, 23);
            this.export_path_button.TabIndex = 3;
            this.export_path_button.Text = "Open";
            this.export_path_button.UseVisualStyleBackColor = true;
            this.export_path_button.Click += new System.EventHandler(this.export_path_button_Click);
            // 
            // export_path_textbox
            // 
            this.export_path_textbox.Enabled = false;
            this.export_path_textbox.Location = new System.Drawing.Point(138, 132);
            this.export_path_textbox.Name = "export_path_textbox";
            this.export_path_textbox.ReadOnly = true;
            this.export_path_textbox.Size = new System.Drawing.Size(331, 20);
            this.export_path_textbox.TabIndex = 4;
            this.export_path_textbox.Text = "Choose export path.";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(222, 201);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(117, 45);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Analyze";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(37, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Status:";
            // 
            // status_textbox
            // 
            this.status_textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.status_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status_textbox.Location = new System.Drawing.Point(83, 279);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(277, 13);
            this.status_textbox.TabIndex = 7;
            this.status_textbox.Text = "Ready.";
            // 
            // results_table
            // 
            this.results_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extension,
            this.Count});
            this.results_table.Location = new System.Drawing.Point(499, 39);
            this.results_table.Name = "results_table";
            this.results_table.ReadOnly = true;
            this.results_table.Size = new System.Drawing.Size(327, 272);
            this.results_table.TabIndex = 8;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 344);
            this.Controls.Add(this.results_table);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.export_path_textbox);
            this.Controls.Add(this.export_path_button);
            this.Controls.Add(this.allow_export_checkbox);
            this.Controls.Add(this.suorce_button);
            this.Controls.Add(this.suorce_textbox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "File Extensions Report App";
            ((System.ComponentModel.ISupportInitialize)(this.results_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox suorce_textbox;
        private System.Windows.Forms.Button suorce_button;
        private System.Windows.Forms.CheckBox allow_export_checkbox;
        private System.Windows.Forms.Button export_path_button;
        private System.Windows.Forms.TextBox export_path_textbox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox status_textbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView results_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

