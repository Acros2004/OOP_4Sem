namespace lab2
{
    partial class DialogForm
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDialog = new System.Windows.Forms.TextBox();
            this.balanceDialog = new System.Windows.Forms.TextBox();
            this.checkDialog = new System.Windows.Forms.CheckBox();
            this.typeDealog = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выражение";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 44);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 23);
            this.textSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Баланс";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип вклада";
            this.label4.Visible = false;
            // 
            // nameDialog
            // 
            this.nameDialog.Location = new System.Drawing.Point(278, 23);
            this.nameDialog.Name = "nameDialog";
            this.nameDialog.Size = new System.Drawing.Size(103, 23);
            this.nameDialog.TabIndex = 5;
            this.nameDialog.Visible = false;
            this.nameDialog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // balanceDialog
            // 
            this.balanceDialog.Location = new System.Drawing.Point(278, 52);
            this.balanceDialog.Name = "balanceDialog";
            this.balanceDialog.Size = new System.Drawing.Size(103, 23);
            this.balanceDialog.TabIndex = 6;
            this.balanceDialog.Visible = false;
            this.balanceDialog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // checkDialog
            // 
            this.checkDialog.AutoSize = true;
            this.checkDialog.Location = new System.Drawing.Point(14, 84);
            this.checkDialog.Name = "checkDialog";
            this.checkDialog.Size = new System.Drawing.Size(142, 19);
            this.checkDialog.TabIndex = 8;
            this.checkDialog.Text = "Расширенный поиск";
            this.checkDialog.UseVisualStyleBackColor = true;
            this.checkDialog.CheckedChanged += new System.EventHandler(this.checksearch_CheckedChanged);
            // 
            // typeDealog
            // 
            this.typeDealog.FormattingEnabled = true;
            this.typeDealog.Items.AddRange(new object[] {
            "Открытй",
            "Закрытый"});
            this.typeDealog.Location = new System.Drawing.Point(278, 81);
            this.typeDealog.Name = "typeDealog";
            this.typeDealog.Size = new System.Drawing.Size(103, 23);
            this.typeDealog.TabIndex = 9;
            this.typeDealog.Visible = false;
            this.typeDealog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balance_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(14, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 79);
            this.listBox1.TabIndex = 11;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(411, 245);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeDealog);
            this.Controls.Add(this.checkDialog);
            this.Controls.Add(this.balanceDialog);
            this.Controls.Add(this.nameDialog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameDialog;
        private TextBox balanceDialog;
        private CheckBox checkDialog;
        private ComboBox typeDealog;
        private Button button1;
        private ListBox listBox1;
    }
}