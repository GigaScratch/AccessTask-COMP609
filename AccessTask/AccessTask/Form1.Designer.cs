namespace AccessTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtb_table = new System.Windows.Forms.DataGridView();
            this.dtb_id = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 30);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(94, 20);
            this.tb_name.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(133, 30);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(94, 20);
            this.tb_id.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Enabled = false;
            this.btn_search.Location = new System.Drawing.Point(243, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(52, 20);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtb_table, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtb_id, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 229);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dtb_table
            // 
            this.dtb_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtb_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtb_table.Location = new System.Drawing.Point(2, 2);
            this.dtb_table.Margin = new System.Windows.Forms.Padding(2);
            this.dtb_table.Name = "dtb_table";
            this.dtb_table.RowHeadersWidth = 82;
            this.dtb_table.RowTemplate.Height = 33;
            this.dtb_table.Size = new System.Drawing.Size(474, 110);
            this.dtb_table.TabIndex = 0;
            // 
            // dtb_id
            // 
            this.dtb_id.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtb_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtb_id.Location = new System.Drawing.Point(2, 116);
            this.dtb_id.Margin = new System.Windows.Forms.Padding(2);
            this.dtb_id.Name = "dtb_id";
            this.dtb_id.RowHeadersWidth = 82;
            this.dtb_id.RowTemplate.Height = 33;
            this.dtb_id.Size = new System.Drawing.Size(474, 111);
            this.dtb_id.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Access Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtb_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtb_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtb_table;
        private System.Windows.Forms.DataGridView dtb_id;
    }
}

