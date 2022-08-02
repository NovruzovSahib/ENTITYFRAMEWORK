namespace ENTITYFRAMEWORK
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_personid = new System.Windows.Forms.TextBox();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbox_company = new System.Windows.Forms.GroupBox();
            this.gbox_personal = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rbtn_company = new System.Windows.Forms.RadioButton();
            this.rbtn_personal = new System.Windows.Forms.RadioButton();
            this.rbtn_orderby = new System.Windows.Forms.RadioButton();
            this.rbtn_sum = new System.Windows.Forms.RadioButton();
            this.rbtn_min = new System.Windows.Forms.RadioButton();
            this.rbtn_max = new System.Windows.Forms.RadioButton();
            this.rbtn_avg = new System.Windows.Forms.RadioButton();
            this.btn_join = new System.Windows.Forms.Button();
            this.gbox_operations = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbox_company.SuspendLayout();
            this.gbox_personal.SuspendLayout();
            this.gbox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 343);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(142, 409);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 38);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(9, 361);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(257, 38);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(9, 409);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 38);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(9, 453);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 38);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "PERSONID";
            // 
            // txt_personid
            // 
            this.txt_personid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personid.ForeColor = System.Drawing.Color.Black;
            this.txt_personid.Location = new System.Drawing.Point(109, 26);
            this.txt_personid.Name = "txt_personid";
            this.txt_personid.Size = new System.Drawing.Size(100, 20);
            this.txt_personid.TabIndex = 8;
            // 
            // txt_companyname
            // 
            this.txt_companyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyname.ForeColor = System.Drawing.Color.Black;
            this.txt_companyname.Location = new System.Drawing.Point(109, 52);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(100, 20);
            this.txt_companyname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "NAME";
            // 
            // gbox_company
            // 
            this.gbox_company.Controls.Add(this.label2);
            this.gbox_company.Controls.Add(this.txt_companyname);
            this.gbox_company.Controls.Add(this.label1);
            this.gbox_company.Controls.Add(this.txt_personid);
            this.gbox_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_company.ForeColor = System.Drawing.Color.White;
            this.gbox_company.Location = new System.Drawing.Point(12, 12);
            this.gbox_company.Name = "gbox_company";
            this.gbox_company.Size = new System.Drawing.Size(254, 92);
            this.gbox_company.TabIndex = 11;
            this.gbox_company.TabStop = false;
            this.gbox_company.Text = "COMPANY";
            // 
            // gbox_personal
            // 
            this.gbox_personal.Controls.Add(this.label8);
            this.gbox_personal.Controls.Add(this.txt_id);
            this.gbox_personal.Controls.Add(this.label7);
            this.gbox_personal.Controls.Add(this.txt_country);
            this.gbox_personal.Controls.Add(this.label5);
            this.gbox_personal.Controls.Add(this.txt_age);
            this.gbox_personal.Controls.Add(this.label6);
            this.gbox_personal.Controls.Add(this.txtposition);
            this.gbox_personal.Controls.Add(this.label3);
            this.gbox_personal.Controls.Add(this.txt_surname);
            this.gbox_personal.Controls.Add(this.label4);
            this.gbox_personal.Controls.Add(this.txt_name);
            this.gbox_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_personal.ForeColor = System.Drawing.Color.White;
            this.gbox_personal.Location = new System.Drawing.Point(12, 110);
            this.gbox_personal.Name = "gbox_personal";
            this.gbox_personal.Size = new System.Drawing.Size(254, 214);
            this.gbox_personal.TabIndex = 12;
            this.gbox_personal.TabStop = false;
            this.gbox_personal.Text = "PERSONAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(75, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(109, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "COUNTRY";
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_country.ForeColor = System.Drawing.Color.Black;
            this.txt_country.Location = new System.Drawing.Point(109, 165);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(100, 20);
            this.txt_country.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(56, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "AGE";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.ForeColor = System.Drawing.Color.Black;
            this.txt_age.Location = new System.Drawing.Point(109, 139);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "POSITION";
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.ForeColor = System.Drawing.Color.Black;
            this.txtposition.Location = new System.Drawing.Point(109, 113);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(100, 20);
            this.txtposition.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "SURNAME";
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.ForeColor = System.Drawing.Color.Black;
            this.txt_surname.Location = new System.Drawing.Point(109, 87);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_surname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(44, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "NAME";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(109, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 8;
            // 
            // rbtn_company
            // 
            this.rbtn_company.AutoSize = true;
            this.rbtn_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_company.ForeColor = System.Drawing.Color.White;
            this.rbtn_company.Location = new System.Drawing.Point(12, 330);
            this.rbtn_company.Name = "rbtn_company";
            this.rbtn_company.Size = new System.Drawing.Size(121, 29);
            this.rbtn_company.TabIndex = 13;
            this.rbtn_company.TabStop = true;
            this.rbtn_company.Text = "Company";
            this.rbtn_company.UseVisualStyleBackColor = true;
            this.rbtn_company.CheckedChanged += new System.EventHandler(this.rbtn_company_CheckedChanged);
            // 
            // rbtn_personal
            // 
            this.rbtn_personal.AutoSize = true;
            this.rbtn_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_personal.ForeColor = System.Drawing.Color.White;
            this.rbtn_personal.Location = new System.Drawing.Point(151, 330);
            this.rbtn_personal.Name = "rbtn_personal";
            this.rbtn_personal.Size = new System.Drawing.Size(115, 29);
            this.rbtn_personal.TabIndex = 14;
            this.rbtn_personal.TabStop = true;
            this.rbtn_personal.Text = "Personal";
            this.rbtn_personal.UseVisualStyleBackColor = true;
            this.rbtn_personal.CheckedChanged += new System.EventHandler(this.rbtn_personal_CheckedChanged);
            // 
            // rbtn_orderby
            // 
            this.rbtn_orderby.AutoSize = true;
            this.rbtn_orderby.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_orderby.ForeColor = System.Drawing.Color.White;
            this.rbtn_orderby.Location = new System.Drawing.Point(19, 31);
            this.rbtn_orderby.Name = "rbtn_orderby";
            this.rbtn_orderby.Size = new System.Drawing.Size(76, 29);
            this.rbtn_orderby.TabIndex = 16;
            this.rbtn_orderby.TabStop = true;
            this.rbtn_orderby.Text = "A->Z";
            this.rbtn_orderby.UseVisualStyleBackColor = true;
            this.rbtn_orderby.CheckedChanged += new System.EventHandler(this.rbtn_orderby_CheckedChanged);
            // 
            // rbtn_sum
            // 
            this.rbtn_sum.AutoSize = true;
            this.rbtn_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_sum.ForeColor = System.Drawing.Color.White;
            this.rbtn_sum.Location = new System.Drawing.Point(390, 31);
            this.rbtn_sum.Name = "rbtn_sum";
            this.rbtn_sum.Size = new System.Drawing.Size(156, 29);
            this.rbtn_sum.TabIndex = 17;
            this.rbtn_sum.TabStop = true;
            this.rbtn_sum.Text = "SUM_TABLE";
            this.rbtn_sum.UseVisualStyleBackColor = true;
            this.rbtn_sum.CheckedChanged += new System.EventHandler(this.rbtn_sum_CheckedChanged);
            // 
            // rbtn_min
            // 
            this.rbtn_min.AutoSize = true;
            this.rbtn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_min.ForeColor = System.Drawing.Color.White;
            this.rbtn_min.Location = new System.Drawing.Point(208, 31);
            this.rbtn_min.Name = "rbtn_min";
            this.rbtn_min.Size = new System.Drawing.Size(68, 29);
            this.rbtn_min.TabIndex = 18;
            this.rbtn_min.TabStop = true;
            this.rbtn_min.Text = "MIN";
            this.rbtn_min.UseVisualStyleBackColor = true;
            this.rbtn_min.CheckedChanged += new System.EventHandler(this.rbtn_min_CheckedChanged);
            // 
            // rbtn_max
            // 
            this.rbtn_max.AutoSize = true;
            this.rbtn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_max.ForeColor = System.Drawing.Color.White;
            this.rbtn_max.Location = new System.Drawing.Point(113, 31);
            this.rbtn_max.Name = "rbtn_max";
            this.rbtn_max.Size = new System.Drawing.Size(76, 29);
            this.rbtn_max.TabIndex = 19;
            this.rbtn_max.TabStop = true;
            this.rbtn_max.Text = "MAX";
            this.rbtn_max.UseVisualStyleBackColor = true;
            this.rbtn_max.CheckedChanged += new System.EventHandler(this.rbtn_max_CheckedChanged);
            // 
            // rbtn_avg
            // 
            this.rbtn_avg.AutoSize = true;
            this.rbtn_avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_avg.ForeColor = System.Drawing.Color.White;
            this.rbtn_avg.Location = new System.Drawing.Point(294, 31);
            this.rbtn_avg.Name = "rbtn_avg";
            this.rbtn_avg.Size = new System.Drawing.Size(74, 29);
            this.rbtn_avg.TabIndex = 20;
            this.rbtn_avg.TabStop = true;
            this.rbtn_avg.Text = "AVG";
            this.rbtn_avg.UseVisualStyleBackColor = true;
            this.rbtn_avg.CheckedChanged += new System.EventHandler(this.rbtn_avg_CheckedChanged);
            // 
            // btn_join
            // 
            this.btn_join.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join.Location = new System.Drawing.Point(142, 453);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(124, 38);
            this.btn_join.TabIndex = 21;
            this.btn_join.Text = "JOIN";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // gbox_operations
            // 
            this.gbox_operations.Controls.Add(this.rbtn_min);
            this.gbox_operations.Controls.Add(this.rbtn_max);
            this.gbox_operations.Controls.Add(this.rbtn_sum);
            this.gbox_operations.Controls.Add(this.rbtn_orderby);
            this.gbox_operations.Controls.Add(this.rbtn_avg);
            this.gbox_operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_operations.ForeColor = System.Drawing.Color.White;
            this.gbox_operations.Location = new System.Drawing.Point(280, 361);
            this.gbox_operations.Name = "gbox_operations";
            this.gbox_operations.Size = new System.Drawing.Size(552, 130);
            this.gbox_operations.TabIndex = 22;
            this.gbox_operations.TabStop = false;
            this.gbox_operations.Text = "OPERATİONS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(844, 503);
            this.Controls.Add(this.gbox_operations);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.rbtn_personal);
            this.Controls.Add(this.rbtn_company);
            this.Controls.Add(this.gbox_personal);
            this.Controls.Add(this.gbox_company);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbox_company.ResumeLayout(false);
            this.gbox_company.PerformLayout();
            this.gbox_personal.ResumeLayout(false);
            this.gbox_personal.PerformLayout();
            this.gbox_operations.ResumeLayout(false);
            this.gbox_operations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_personid;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_company;
        private System.Windows.Forms.GroupBox gbox_personal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rbtn_company;
        private System.Windows.Forms.RadioButton rbtn_personal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RadioButton rbtn_orderby;
        private System.Windows.Forms.RadioButton rbtn_sum;
        private System.Windows.Forms.RadioButton rbtn_min;
        private System.Windows.Forms.RadioButton rbtn_max;
        private System.Windows.Forms.RadioButton rbtn_avg;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.GroupBox gbox_operations;
    }
}

