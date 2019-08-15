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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.data_id = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(31, 58);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(185, 31);
            this.tb_name.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(442, 58);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(185, 31);
            this.tb_id.TabIndex = 3;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(222, 58);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(104, 31);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // btn_search
            // 
            this.btn_search.Enabled = false;
            this.btn_search.Location = new System.Drawing.Point(633, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 31);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.data_table, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.data_id, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 441);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // data_table
            // 
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_table.Location = new System.Drawing.Point(3, 3);
            this.data_table.Name = "data_table";
            this.data_table.RowHeadersWidth = 82;
            this.data_table.RowTemplate.Height = 33;
            this.data_table.Size = new System.Drawing.Size(949, 214);
            this.data_table.TabIndex = 0;
            // 
            // data_id
            // 
            this.data_id.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_id.Location = new System.Drawing.Point(3, 223);
            this.data_id.Name = "data_id";
            this.data_id.RowHeadersWidth = 82;
            this.data_id.RowTemplate.Height = 33;
            this.data_id.Size = new System.Drawing.Size(949, 215);
            this.data_id.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Access Database";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.DataGridView data_id;
    }
}

