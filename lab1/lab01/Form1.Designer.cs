namespace lab01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resaultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ClearInput = new System.Windows.Forms.Button();
            this.EquallyInput = new System.Windows.Forms.Button();
            this.NotInput = new System.Windows.Forms.Button();
            this.XorInput = new System.Windows.Forms.Button();
            this.OrInput = new System.Windows.Forms.Button();
            this.AndInput = new System.Windows.Forms.Button();
            this.NullInput = new System.Windows.Forms.Button();
            this.OneInput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 100);
            this.panel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(371, 70);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.resaultBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ClearInput);
            this.panel2.Controls.Add(this.EquallyInput);
            this.panel2.Controls.Add(this.NotInput);
            this.panel2.Controls.Add(this.XorInput);
            this.panel2.Controls.Add(this.OrInput);
            this.panel2.Controls.Add(this.AndInput);
            this.panel2.Controls.Add(this.NullInput);
            this.panel2.Controls.Add(this.OneInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 241);
            this.panel2.TabIndex = 1;
            // 
            // resaultBox
            // 
            this.resaultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resaultBox.Location = new System.Drawing.Point(12, 172);
            this.resaultBox.Multiline = true;
            this.resaultBox.Name = "resaultBox";
            this.resaultBox.Size = new System.Drawing.Size(370, 39);
            this.resaultBox.TabIndex = 10;
            this.resaultBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите систему счисления";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bin",
            "Dec",
            "Hex",
            "Oct"});
            this.comboBox1.Location = new System.Drawing.Point(26, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Bin";
            // 
            // ClearInput
            // 
            this.ClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearInput.Location = new System.Drawing.Point(227, 72);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(156, 35);
            this.ClearInput.TabIndex = 7;
            this.ClearInput.Text = "Clear";
            this.ClearInput.UseVisualStyleBackColor = true;
            this.ClearInput.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // EquallyInput
            // 
            this.EquallyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EquallyInput.Location = new System.Drawing.Point(12, 72);
            this.EquallyInput.Name = "EquallyInput";
            this.EquallyInput.Size = new System.Drawing.Size(156, 35);
            this.EquallyInput.TabIndex = 6;
            this.EquallyInput.Text = "=";
            this.EquallyInput.UseVisualStyleBackColor = true;
            this.EquallyInput.Click += new System.EventHandler(this.EquallyInput_Click);
            // 
            // NotInput
            // 
            this.NotInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotInput.Location = new System.Drawing.Point(340, 14);
            this.NotInput.Name = "NotInput";
            this.NotInput.Size = new System.Drawing.Size(43, 38);
            this.NotInput.TabIndex = 5;
            this.NotInput.Text = "~";
            this.NotInput.UseVisualStyleBackColor = true;
            this.NotInput.Click += new System.EventHandler(this.OperationInput_Click);
            // 
            // XorInput
            // 
            this.XorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XorInput.Location = new System.Drawing.Point(276, 14);
            this.XorInput.Name = "XorInput";
            this.XorInput.Size = new System.Drawing.Size(43, 38);
            this.XorInput.TabIndex = 4;
            this.XorInput.Text = "^";
            this.XorInput.UseVisualStyleBackColor = true;
            this.XorInput.Click += new System.EventHandler(this.OperationInput_Click);
            // 
            // OrInput
            // 
            this.OrInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrInput.Location = new System.Drawing.Point(211, 14);
            this.OrInput.Name = "OrInput";
            this.OrInput.Size = new System.Drawing.Size(43, 38);
            this.OrInput.TabIndex = 3;
            this.OrInput.Text = "|";
            this.OrInput.UseVisualStyleBackColor = true;
            this.OrInput.Click += new System.EventHandler(this.OperationInput_Click);
            // 
            // AndInput
            // 
            this.AndInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AndInput.Location = new System.Drawing.Point(144, 14);
            this.AndInput.Name = "AndInput";
            this.AndInput.Size = new System.Drawing.Size(43, 38);
            this.AndInput.TabIndex = 2;
            this.AndInput.Text = "&&";
            this.AndInput.UseVisualStyleBackColor = true;
            this.AndInput.Click += new System.EventHandler(this.OperationInput_Click);
            // 
            // NullInput
            // 
            this.NullInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NullInput.Location = new System.Drawing.Point(77, 14);
            this.NullInput.Name = "NullInput";
            this.NullInput.Size = new System.Drawing.Size(43, 38);
            this.NullInput.TabIndex = 1;
            this.NullInput.Text = "0";
            this.NullInput.UseVisualStyleBackColor = true;
            this.NullInput.Click += new System.EventHandler(this.OneInput_Click);
            // 
            // OneInput
            // 
            this.OneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneInput.Location = new System.Drawing.Point(12, 14);
            this.OneInput.Name = "OneInput";
            this.OneInput.Size = new System.Drawing.Size(43, 38);
            this.OneInput.TabIndex = 0;
            this.OneInput.Text = "1";
            this.OneInput.UseVisualStyleBackColor = true;
            this.OneInput.Click += new System.EventHandler(this.OneInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 347);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ClearInput;
        private System.Windows.Forms.Button EquallyInput;
        private System.Windows.Forms.Button NotInput;
        private System.Windows.Forms.Button XorInput;
        private System.Windows.Forms.Button OrInput;
        private System.Windows.Forms.Button AndInput;
        private System.Windows.Forms.Button NullInput;
        private System.Windows.Forms.Button OneInput;
        private System.Windows.Forms.TextBox resaultBox;
    }
}

