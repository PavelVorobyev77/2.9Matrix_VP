namespace _2._9Matrix_VP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonMatrices1 = new System.Windows.Forms.Button();
            this.buttonMatrices2 = new System.Windows.Forms.Button();
            this.buttonFold = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonTransposition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtn1 = new System.Windows.Forms.RadioButton();
            this.radiobtn2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(812, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(483, 187);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1458, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(483, 187);
            this.dataGridView3.TabIndex = 2;
            // 
            // buttonMatrices1
            // 
            this.buttonMatrices1.Location = new System.Drawing.Point(40, 286);
            this.buttonMatrices1.Name = "buttonMatrices1";
            this.buttonMatrices1.Size = new System.Drawing.Size(144, 45);
            this.buttonMatrices1.TabIndex = 3;
            this.buttonMatrices1.Text = "Сгенерировать 1-ю матрицу";
            this.buttonMatrices1.UseVisualStyleBackColor = true;
            this.buttonMatrices1.Click += new System.EventHandler(this.buttonMatrices1_Click);
            // 
            // buttonMatrices2
            // 
            this.buttonMatrices2.Location = new System.Drawing.Point(812, 286);
            this.buttonMatrices2.Name = "buttonMatrices2";
            this.buttonMatrices2.Size = new System.Drawing.Size(144, 45);
            this.buttonMatrices2.TabIndex = 4;
            this.buttonMatrices2.Text = "Сгенерировать 2-ю матрицу";
            this.buttonMatrices2.UseVisualStyleBackColor = true;
            this.buttonMatrices2.Click += new System.EventHandler(this.buttonMatrices2_Click);
            // 
            // buttonFold
            // 
            this.buttonFold.Location = new System.Drawing.Point(604, 57);
            this.buttonFold.Name = "buttonFold";
            this.buttonFold.Size = new System.Drawing.Size(114, 39);
            this.buttonFold.TabIndex = 5;
            this.buttonFold.Text = "Сложение(+)";
            this.buttonFold.UseVisualStyleBackColor = true;
            this.buttonFold.Click += new System.EventHandler(this.buttonFold_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(604, 113);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(114, 39);
            this.buttonMultiply.TabIndex = 6;
            this.buttonMultiply.Text = "Умножение (*)";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(604, 167);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(114, 39);
            this.buttonSubtract.TabIndex = 7;
            this.buttonSubtract.Text = "Вычитание (-)";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonTransposition
            // 
            this.buttonTransposition.Location = new System.Drawing.Point(592, 223);
            this.buttonTransposition.Name = "buttonTransposition";
            this.buttonTransposition.Size = new System.Drawing.Size(146, 39);
            this.buttonTransposition.TabIndex = 8;
            this.buttonTransposition.Text = "Транспонирование";
            this.buttonTransposition.UseVisualStyleBackColor = true;
            this.buttonTransposition.Click += new System.EventHandler(this.buttonTransposition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Матрица 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Матрица 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1455, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1355, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "=";
            // 
            // radiobtn1
            // 
            this.radiobtn1.AutoSize = true;
            this.radiobtn1.Location = new System.Drawing.Point(40, 361);
            this.radiobtn1.Name = "radiobtn1";
            this.radiobtn1.Size = new System.Drawing.Size(215, 20);
            this.radiobtn1.TabIndex = 13;
            this.radiobtn1.TabStop = true;
            this.radiobtn1.Text = "Транспонировать матрицу 1";
            this.radiobtn1.UseVisualStyleBackColor = true;
            // 
            // radiobtn2
            // 
            this.radiobtn2.AutoSize = true;
            this.radiobtn2.Location = new System.Drawing.Point(812, 361);
            this.radiobtn2.Name = "radiobtn2";
            this.radiobtn2.Size = new System.Drawing.Size(215, 20);
            this.radiobtn2.TabIndex = 14;
            this.radiobtn2.TabStop = true;
            this.radiobtn2.Text = "Транспонировать матрицу 2";
            this.radiobtn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2033, 793);
            this.Controls.Add(this.radiobtn2);
            this.Controls.Add(this.radiobtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTransposition);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonMatrices2);
            this.Controls.Add(this.buttonMatrices1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonMatrices1;
        private System.Windows.Forms.Button buttonMatrices2;
        private System.Windows.Forms.Button buttonFold;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonTransposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiobtn1;
        private System.Windows.Forms.RadioButton radiobtn2;
    }
}

