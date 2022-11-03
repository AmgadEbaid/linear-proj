namespace linear_equation_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matRow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.colCount = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.demo = new System.Windows.Forms.Button();
            this.mat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "enter the matrix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(384, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matRow
            // 
            this.matRow.AutoSize = true;
            this.matRow.Location = new System.Drawing.Point(12, 58);
            this.matRow.Name = "matRow";
            this.matRow.Size = new System.Drawing.Size(80, 20);
            this.matRow.TabIndex = 2;
            this.matRow.Tag = "";
            this.matRow.Text = "matrix size";
            this.matRow.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(98, 367);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(94, 29);
            this.solve.TabIndex = 4;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(98, 56);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(83, 27);
            this.rowCount.TabIndex = 6;
            this.rowCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // colCount
            // 
            this.colCount.Location = new System.Drawing.Point(209, 58);
            this.colCount.Name = "colCount";
            this.colCount.Size = new System.Drawing.Size(83, 27);
            this.colCount.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(488, 162);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(103, 188);
            this.dataGridView2.TabIndex = 8;
            // 
            // demo
            // 
            this.demo.Location = new System.Drawing.Point(403, 356);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(188, 29);
            this.demo.TabIndex = 9;
            this.demo.Text = "demo";
            this.demo.UseVisualStyleBackColor = true;
            this.demo.Click += new System.EventHandler(this.button2_Click);
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Location = new System.Drawing.Point(98, 139);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(51, 20);
            this.mat.TabIndex = 10;
            this.mat.Text = "Matrix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "victor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(98, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 78);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.colCount);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matRow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label matRow;
        private Label label2;
        private Button solve;
        private NumericUpDown rowCount;
        private NumericUpDown colCount;
        private DataGridView dataGridView2;
        private Button demo;
        private Label mat;
        private Label label3;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}