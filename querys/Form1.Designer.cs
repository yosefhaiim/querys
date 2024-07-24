namespace querys
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDayInMonth = new System.Windows.Forms.ComboBox();
            this.cmbDayInWeek = new System.Windows.Forms.ComboBox();
            this.lblTheAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "היום בחודש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "שנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "חודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "היום בשבוע";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(101, 177);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "כתיבה";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "תשפ\'\'ד",
            "תשפ\'\'ה",
            "תשפ\'\'ו",
            "תשפ\'\'ז",
            "תשפ\'\'ח",
            "תשפ\'\'ט"});
            this.cmbYear.Location = new System.Drawing.Point(179, 104);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 5;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMonth.Location = new System.Drawing.Point(326, 104);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 6;
            // 
            // cmbDayInMonth
            // 
            this.cmbDayInMonth.FormattingEnabled = true;
            this.cmbDayInMonth.Items.AddRange(new object[] {
            "יום אחד לירח",
            "שני ימים לירח",
            "שלושה ימים לירח",
            "ארבעה ימים לירח",
            " חמישה ימים לירח",
            "ששה ימים לירח",
            "שבעה ימים לירח",
            "שמונה ימים לירח",
            "תשעה ימים לירח",
            " עשרה ימים לירח ",
            "אחד עשר יום לירח",
            "שנים עשר יום לירח",
            "שלושה עשר יום לירח",
            "ארבעה עשר יום לירח",
            "חמישה עשר יום לירח",
            "ששה עשר יום לירח",
            "שבעה עשר יום לירח",
            "שמונה עשר יום לירח",
            "תשעה עשר יום לירח",
            "עשרים יום לירח",
            "אחד ועשרים יום לירח",
            "שנים ועשרים יום לירח",
            "שלושה ועשרים יום לירח",
            "ארבעה ועשרים יום לירח",
            "חמישה ועשרים יום לירח",
            "ששה ועשרים יום לירח",
            "שבעה ועשרים יום לירח",
            "שמונה ועשרים יום לירח",
            "תשעה ועשרים יום לירח",
            "יום שלושים לחודש"});
            this.cmbDayInMonth.Location = new System.Drawing.Point(475, 104);
            this.cmbDayInMonth.Name = "cmbDayInMonth";
            this.cmbDayInMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbDayInMonth.TabIndex = 7;
            // 
            // cmbDayInWeek
            // 
            this.cmbDayInWeek.FormattingEnabled = true;
            this.cmbDayInWeek.Items.AddRange(new object[] {
            "באחד בשבת",
            "בשני בשבת",
            "בשלישי בשבת",
            "ברביעי בשבת",
            "בחמישי בשבת",
            "בששי בשבת"});
            this.cmbDayInWeek.Location = new System.Drawing.Point(636, 104);
            this.cmbDayInWeek.Name = "cmbDayInWeek";
            this.cmbDayInWeek.Size = new System.Drawing.Size(121, 24);
            this.cmbDayInWeek.TabIndex = 8;
            // 
            // lblTheAll
            // 
            this.lblTheAll.AutoSize = true;
            this.lblTheAll.Location = new System.Drawing.Point(66, 382);
            this.lblTheAll.Name = "lblTheAll";
            this.lblTheAll.Size = new System.Drawing.Size(76, 16);
            this.lblTheAll.TabIndex = 9;
            this.lblTheAll.Text = "הנוסח המלא";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTheAll);
            this.Controls.Add(this.cmbDayInWeek);
            this.Controls.Add(this.cmbDayInMonth);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDayInMonth;
        private System.Windows.Forms.ComboBox cmbDayInWeek;
        private System.Windows.Forms.Label lblTheAll;
    }
}

