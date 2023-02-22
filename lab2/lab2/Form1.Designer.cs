namespace lab2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуОткрытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.passport = new System.Windows.Forms.TextBox();
            this.birtdate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TrackBar();
            this.type = new System.Windows.Forms.ComboBox();
            this.opendate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sms = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.programInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.поискToolStripMenuItem.Text = "поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруToolStripMenuItem,
            this.поГодуОткрытияToolStripMenuItem,
            this.поТипуВкладаToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.сортировкаToolStripMenuItem.Text = "сортировка";
            // 
            // поНомеруToolStripMenuItem
            // 
            this.поНомеруToolStripMenuItem.Name = "поНомеруToolStripMenuItem";
            this.поНомеруToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.поНомеруToolStripMenuItem.Text = "по номеру";
            this.поНомеруToolStripMenuItem.Click += new System.EventHandler(this.поНомеруToolStripMenuItem_Click);
            // 
            // поГодуОткрытияToolStripMenuItem
            // 
            this.поГодуОткрытияToolStripMenuItem.Name = "поГодуОткрытияToolStripMenuItem";
            this.поГодуОткрытияToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.поГодуОткрытияToolStripMenuItem.Text = "по году открытия";
            this.поГодуОткрытияToolStripMenuItem.Click += new System.EventHandler(this.поГодуОткрытияToolStripMenuItem_Click);
            // 
            // поТипуВкладаToolStripMenuItem
            // 
            this.поТипуВкладаToolStripMenuItem.Name = "поТипуВкладаToolStripMenuItem";
            this.поТипуВкладаToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.поТипуВкладаToolStripMenuItem.Text = "по типу вклада";
            this.поТипуВкладаToolStripMenuItem.Click += new System.EventHandler(this.типВкладаToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "выход";
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.programInfoToolStripMenuItem.Text = "о программе";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfotoolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Паспортные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "День рождения";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(85, 52);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 23);
            this.name.TabIndex = 4;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(168, 91);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(155, 23);
            this.passport.TabIndex = 5;
            // 
            // birtdate
            // 
            this.birtdate.Location = new System.Drawing.Point(168, 126);
            this.birtdate.Name = "birtdate";
            this.birtdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип вклада";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Баланс";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(457, 52);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(155, 23);
            this.number.TabIndex = 10;
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // balance
            // 
            this.balance.LargeChange = 250;
            this.balance.Location = new System.Drawing.Point(457, 126);
            this.balance.Maximum = 1000000;
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(155, 45);
            this.balance.TabIndex = 5;
            this.balance.Scroll += new System.EventHandler(this.balance_Scroll);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Закрытый",
            "Открытый"});
            this.type.Location = new System.Drawing.Point(457, 88);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(155, 23);
            this.type.TabIndex = 13;
            this.type.Text = "Закрытый";
            // 
            // opendate
            // 
            this.opendate.Location = new System.Drawing.Point(457, 187);
            this.opendate.Name = "opendate";
            this.opendate.Size = new System.Drawing.Size(155, 23);
            this.opendate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата открытия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "SMS";
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(457, 231);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(153, 19);
            this.sms.TabIndex = 17;
            this.sms.Text = "получать уведомления";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(360, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 41);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(457, 265);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 41);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(554, 265);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(91, 41);
            this.buttonLoad.TabIndex = 20;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 312);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(619, 94);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.toolStripLabel8,
            this.toolStripLabel6,
            this.toolStripLabel7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel2.Text = "X";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "поиск";
            this.toolStripLabel1.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel3.Text = "очистить";
            this.toolStripLabel3.Click += new System.EventHandler(this.Clear_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel4.Text = "сортировка";
            this.toolStripLabel4.Click += new System.EventHandler(this.поНомеруToolStripMenuItem_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel5.Text = "назад";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel8.Text = "вперёд";
            this.toolStripLabel8.Click += new System.EventHandler(this.toolStripLabel8_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel6.Text = "ничего";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel7.Text = "toolStripLabel7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.opendate);
            this.Controls.Add(this.type);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birtdate);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox passport;
        private MonthCalendar birtdate;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox number;
        private TrackBar balance;
        private ComboBox type;
        private DateTimePicker opendate;
        private Label label7;
        private Label label8;
        private CheckBox sms;
        private Button buttonAdd;
        private Button buttonSave;
        private Button buttonLoad;
        private ListBox listBox1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem поНомеруToolStripMenuItem;
        private ToolStripMenuItem поГодуОткрытияToolStripMenuItem;
        private ToolStripMenuItem поТипуВкладаToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem programInfoToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel5;
        private ToolStripLabel toolStripLabel8;
        private ToolStripLabel toolStripLabel6;
        private ToolStripLabel toolStripLabel7;
    }
}