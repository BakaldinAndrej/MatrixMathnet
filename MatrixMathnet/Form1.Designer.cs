namespace MatrixMathnet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbAcolumn = new System.Windows.Forms.TextBox();
            this._tbBcolumn = new System.Windows.Forms.TextBox();
            this._tbAformula = new System.Windows.Forms.TextBox();
            this._btnCalc = new System.Windows.Forms.Button();
            this._rtbDialog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tbArow = new System.Windows.Forms.TextBox();
            this._tbBrow = new System.Windows.Forms.TextBox();
            this._tbBformula = new System.Windows.Forms.TextBox();
            this._cmbbOpperation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this._chbSparseA = new System.Windows.Forms.CheckBox();
            this._chbSparseB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число строк A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Формула для A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Формула для B";
            // 
            // _tbAcolumn
            // 
            this._tbAcolumn.Location = new System.Drawing.Point(117, 32);
            this._tbAcolumn.Name = "_tbAcolumn";
            this._tbAcolumn.Size = new System.Drawing.Size(49, 20);
            this._tbAcolumn.TabIndex = 1;
            this._tbAcolumn.Text = "100";
            // 
            // _tbBcolumn
            // 
            this._tbBcolumn.Location = new System.Drawing.Point(117, 84);
            this._tbBcolumn.Name = "_tbBcolumn";
            this._tbBcolumn.Size = new System.Drawing.Size(49, 20);
            this._tbBcolumn.TabIndex = 3;
            this._tbBcolumn.Text = "100";
            // 
            // _tbAformula
            // 
            this._tbAformula.Location = new System.Drawing.Point(264, 6);
            this._tbAformula.Name = "_tbAformula";
            this._tbAformula.Size = new System.Drawing.Size(100, 20);
            this._tbAformula.TabIndex = 4;
            this._tbAformula.Text = "x+y";
            // 
            // _btnCalc
            // 
            this._btnCalc.Location = new System.Drawing.Point(12, 110);
            this._btnCalc.Name = "_btnCalc";
            this._btnCalc.Size = new System.Drawing.Size(99, 23);
            this._btnCalc.TabIndex = 7;
            this._btnCalc.Text = "Вычислить";
            this._btnCalc.UseVisualStyleBackColor = true;
            this._btnCalc.Click += new System.EventHandler(this._btnCalc_Click);
            // 
            // _rtbDialog
            // 
            this._rtbDialog.Location = new System.Drawing.Point(15, 148);
            this._rtbDialog.Name = "_rtbDialog";
            this._rtbDialog.Size = new System.Drawing.Size(349, 140);
            this._rtbDialog.TabIndex = 8;
            this._rtbDialog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Число столбцов A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Число столбцов B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Число строк B";
            // 
            // _tbArow
            // 
            this._tbArow.Location = new System.Drawing.Point(117, 6);
            this._tbArow.Name = "_tbArow";
            this._tbArow.Size = new System.Drawing.Size(49, 20);
            this._tbArow.TabIndex = 0;
            this._tbArow.Text = "100";
            // 
            // _tbBrow
            // 
            this._tbBrow.Location = new System.Drawing.Point(117, 58);
            this._tbBrow.Name = "_tbBrow";
            this._tbBrow.Size = new System.Drawing.Size(49, 20);
            this._tbBrow.TabIndex = 2;
            this._tbBrow.Text = "100";
            // 
            // _tbBformula
            // 
            this._tbBformula.Location = new System.Drawing.Point(264, 58);
            this._tbBformula.Name = "_tbBformula";
            this._tbBformula.Size = new System.Drawing.Size(100, 20);
            this._tbBformula.TabIndex = 5;
            this._tbBformula.Text = "y*3.1";
            // 
            // _cmbbOpperation
            // 
            this._cmbbOpperation.DisplayMember = "1";
            this._cmbbOpperation.FormattingEnabled = true;
            this._cmbbOpperation.Items.AddRange(new object[] {
            "Перемножение",
            "Транспонирование"});
            this._cmbbOpperation.Location = new System.Drawing.Point(241, 112);
            this._cmbbOpperation.Name = "_cmbbOpperation";
            this._cmbbOpperation.Size = new System.Drawing.Size(123, 21);
            this._cmbbOpperation.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Опперация";
            // 
            // _chbSparseA
            // 
            this._chbSparseA.AutoSize = true;
            this._chbSparseA.Location = new System.Drawing.Point(264, 34);
            this._chbSparseA.Name = "_chbSparseA";
            this._chbSparseA.Size = new System.Drawing.Size(89, 17);
            this._chbSparseA.TabIndex = 16;
            this._chbSparseA.Text = "Разреженна";
            this._chbSparseA.UseVisualStyleBackColor = true;
            // 
            // _chbSparseB
            // 
            this._chbSparseB.AutoSize = true;
            this._chbSparseB.Location = new System.Drawing.Point(264, 87);
            this._chbSparseB.Name = "_chbSparseB";
            this._chbSparseB.Size = new System.Drawing.Size(89, 17);
            this._chbSparseB.TabIndex = 17;
            this._chbSparseB.Text = "Разреженна";
            this._chbSparseB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "A разреженна?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "B разреженна?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 300);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._chbSparseB);
            this.Controls.Add(this._chbSparseA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._cmbbOpperation);
            this.Controls.Add(this._tbBformula);
            this.Controls.Add(this._tbBrow);
            this.Controls.Add(this._tbArow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._rtbDialog);
            this.Controls.Add(this._btnCalc);
            this.Controls.Add(this._tbAformula);
            this.Controls.Add(this._tbBcolumn);
            this.Controls.Add(this._tbAcolumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Матрицы Math.Net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbAcolumn;
        private System.Windows.Forms.TextBox _tbBcolumn;
        private System.Windows.Forms.TextBox _tbAformula;
        private System.Windows.Forms.Button _btnCalc;
        private System.Windows.Forms.RichTextBox _rtbDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _tbArow;
        private System.Windows.Forms.TextBox _tbBrow;
        private System.Windows.Forms.TextBox _tbBformula;
        private System.Windows.Forms.ComboBox _cmbbOpperation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox _chbSparseA;
        private System.Windows.Forms.CheckBox _chbSparseB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

