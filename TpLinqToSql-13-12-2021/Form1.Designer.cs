namespace TpLinqToSql_13_12_2021
{
    partial class LinqToSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinqToSql));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOrderSalire = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textcin = new System.Windows.Forms.TextBox();
            this.textdepa = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textSalarie = new System.Windows.Forms.TextBox();
            this.Textfonction = new System.Windows.Forms.TextBox();
            this.timeEmp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(919, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btnOrderSalire
            // 
            this.btnOrderSalire.Location = new System.Drawing.Point(919, 203);
            this.btnOrderSalire.Name = "btnOrderSalire";
            this.btnOrderSalire.Size = new System.Drawing.Size(236, 38);
            this.btnOrderSalire.TabIndex = 2;
            this.btnOrderSalire.Text = "Order  Salary Asecending";
            this.btnOrderSalire.UseVisualStyleBackColor = true;
            this.btnOrderSalire.Click += new System.EventHandler(this.btnOrderSalire_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Order EmpName Descending";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Get Selected Columns";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Count Employees by Job ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(919, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "Count Empolyees by Departement   >5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(919, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "Count Emplyees by dep > 5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Count Emplyees by job < 5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(919, 467);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 38);
            this.button7.TabIndex = 12;
            this.button7.Text = "select All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(644, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 38);
            this.button8.TabIndex = 17;
            this.button8.Text = "supprimer";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(797, 34);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 38);
            this.button9.TabIndex = 16;
            this.button9.Text = "Effacer";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(797, 78);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 38);
            this.button10.TabIndex = 15;
            this.button10.Text = "Fremer";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(644, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button11_Click);
            // 
            // textcin
            // 
            this.textcin.Location = new System.Drawing.Point(73, 13);
            this.textcin.Multiline = true;
            this.textcin.Name = "textcin";
            this.textcin.Size = new System.Drawing.Size(180, 36);
            this.textcin.TabIndex = 18;
            // 
            // textdepa
            // 
            this.textdepa.Location = new System.Drawing.Point(73, 97);
            this.textdepa.Multiline = true;
            this.textdepa.Name = "textdepa";
            this.textdepa.Size = new System.Drawing.Size(180, 36);
            this.textdepa.TabIndex = 19;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(73, 55);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(180, 36);
            this.textNom.TabIndex = 20;
            // 
            // textSalarie
            // 
            this.textSalarie.Location = new System.Drawing.Point(339, 58);
            this.textSalarie.Multiline = true;
            this.textSalarie.Name = "textSalarie";
            this.textSalarie.Size = new System.Drawing.Size(180, 33);
            this.textSalarie.TabIndex = 21;
            // 
            // Textfonction
            // 
            this.Textfonction.Location = new System.Drawing.Point(339, 13);
            this.Textfonction.Multiline = true;
            this.Textfonction.Name = "Textfonction";
            this.Textfonction.Size = new System.Drawing.Size(180, 36);
            this.Textfonction.TabIndex = 22;
            // 
            // timeEmp
            // 
            this.timeEmp.Location = new System.Drawing.Point(339, 102);
            this.timeEmp.Name = "timeEmp";
            this.timeEmp.Size = new System.Drawing.Size(200, 22);
            this.timeEmp.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "focntion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Depa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "date em";
            // 
            // LinqToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 571);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeEmp);
            this.Controls.Add(this.Textfonction);
            this.Controls.Add(this.textSalarie);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textdepa);
            this.Controls.Add(this.textcin);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrderSalire);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinqToSql";
            this.Text = "LinQ to Sql ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOrderSalire;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textcin;
        private System.Windows.Forms.TextBox textdepa;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textSalarie;
        private System.Windows.Forms.TextBox Textfonction;
        private System.Windows.Forms.DateTimePicker timeEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

