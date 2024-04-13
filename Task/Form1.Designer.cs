namespace Task
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnEnterSet1 = new System.Windows.Forms.Button();
            this.bttnEnterSet2 = new System.Windows.Forms.Button();
            this.BttnUnionSets = new System.Windows.Forms.Button();
            this.BttnFindUnionSets = new System.Windows.Forms.Button();
            this.BttnPowerSets = new System.Windows.Forms.Button();
            this.BttnShowSets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Множество 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Множество 2";
            // 
            // BttnEnterSet1
            // 
            this.BttnEnterSet1.Location = new System.Drawing.Point(41, 80);
            this.BttnEnterSet1.Name = "BttnEnterSet1";
            this.BttnEnterSet1.Size = new System.Drawing.Size(155, 23);
            this.BttnEnterSet1.TabIndex = 4;
            this.BttnEnterSet1.Text = "Принять";
            this.BttnEnterSet1.UseVisualStyleBackColor = true;
            this.BttnEnterSet1.Click += new System.EventHandler(this.BttnEnterSet1_Click);
            // 
            // bttnEnterSet2
            // 
            this.bttnEnterSet2.Location = new System.Drawing.Point(238, 80);
            this.bttnEnterSet2.Name = "bttnEnterSet2";
            this.bttnEnterSet2.Size = new System.Drawing.Size(155, 23);
            this.bttnEnterSet2.TabIndex = 5;
            this.bttnEnterSet2.Text = "Принять";
            this.bttnEnterSet2.UseVisualStyleBackColor = true;
            this.bttnEnterSet2.Click += new System.EventHandler(this.bttnEnterSet2_Click);
            // 
            // BttnUnionSets
            // 
            this.BttnUnionSets.Location = new System.Drawing.Point(40, 166);
            this.BttnUnionSets.Name = "BttnUnionSets";
            this.BttnUnionSets.Size = new System.Drawing.Size(352, 35);
            this.BttnUnionSets.TabIndex = 6;
            this.BttnUnionSets.Text = "Объединить множетсва";
            this.BttnUnionSets.UseVisualStyleBackColor = true;
            this.BttnUnionSets.Click += new System.EventHandler(this.BttnUnionSets_Click);
            // 
            // BttnFindUnionSets
            // 
            this.BttnFindUnionSets.Location = new System.Drawing.Point(41, 207);
            this.BttnFindUnionSets.Name = "BttnFindUnionSets";
            this.BttnFindUnionSets.Size = new System.Drawing.Size(352, 35);
            this.BttnFindUnionSets.TabIndex = 7;
            this.BttnFindUnionSets.Text = "Нахождение пересечения множетсва\r\n";
            this.BttnFindUnionSets.UseVisualStyleBackColor = true;
            this.BttnFindUnionSets.Click += new System.EventHandler(this.BttnFindUnionSets_Click);
            // 
            // BttnPowerSets
            // 
            this.BttnPowerSets.Location = new System.Drawing.Point(40, 248);
            this.BttnPowerSets.Name = "BttnPowerSets";
            this.BttnPowerSets.Size = new System.Drawing.Size(352, 35);
            this.BttnPowerSets.TabIndex = 8;
            this.BttnPowerSets.Text = "Мощность множетсва";
            this.BttnPowerSets.UseVisualStyleBackColor = true;
            this.BttnPowerSets.Click += new System.EventHandler(this.BttnPowerSets_Click);
            // 
            // BttnShowSets
            // 
            this.BttnShowSets.Location = new System.Drawing.Point(41, 309);
            this.BttnShowSets.Name = "BttnShowSets";
            this.BttnShowSets.Size = new System.Drawing.Size(351, 35);
            this.BttnShowSets.TabIndex = 9;
            this.BttnShowSets.Text = "Просмотреть текущие множетсва";
            this.BttnShowSets.UseVisualStyleBackColor = true;
            this.BttnShowSets.Click += new System.EventHandler(this.BttnShowSets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.BttnShowSets);
            this.Controls.Add(this.BttnPowerSets);
            this.Controls.Add(this.BttnFindUnionSets);
            this.Controls.Add(this.BttnUnionSets);
            this.Controls.Add(this.bttnEnterSet2);
            this.Controls.Add(this.BttnEnterSet1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnEnterSet1;
        private System.Windows.Forms.Button bttnEnterSet2;
        private System.Windows.Forms.Button BttnUnionSets;
        private System.Windows.Forms.Button BttnFindUnionSets;
        private System.Windows.Forms.Button BttnPowerSets;
        private System.Windows.Forms.Button BttnShowSets;
    }
}

