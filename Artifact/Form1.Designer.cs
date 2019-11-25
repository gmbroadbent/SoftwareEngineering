namespace SE
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.Label_From = new System.Windows.Forms.Label();
            this.Label_ToDate = new System.Windows.Forms.Label();
            this.Check_FromDate = new System.Windows.Forms.CheckBox();
            this.Check_ToDate = new System.Windows.Forms.CheckBox();
            this.Label_Country = new System.Windows.Forms.Label();
            this.Check_Country = new System.Windows.Forms.CheckBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Catagory = new System.Windows.Forms.ComboBox();
            this.Check_Catagory = new System.Windows.Forms.CheckBox();
            this.Label_Catagory = new System.Windows.Forms.Label();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "News";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.Location = new System.Drawing.Point(316, 198);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(389, 407);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(397, 39);
            this.FromDate.MaxDate = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 20);
            this.FromDate.TabIndex = 3;
            this.FromDate.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(397, 71);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 20);
            this.ToDate.TabIndex = 5;
            // 
            // Label_From
            // 
            this.Label_From.AutoSize = true;
            this.Label_From.Location = new System.Drawing.Point(313, 44);
            this.Label_From.Name = "Label_From";
            this.Label_From.Size = new System.Drawing.Size(56, 13);
            this.Label_From.TabIndex = 6;
            this.Label_From.Text = "From Date";
            // 
            // Label_ToDate
            // 
            this.Label_ToDate.AutoSize = true;
            this.Label_ToDate.Location = new System.Drawing.Point(313, 72);
            this.Label_ToDate.Name = "Label_ToDate";
            this.Label_ToDate.Size = new System.Drawing.Size(46, 13);
            this.Label_ToDate.TabIndex = 7;
            this.Label_ToDate.Text = "To Date";
            // 
            // Check_FromDate
            // 
            this.Check_FromDate.AutoSize = true;
            this.Check_FromDate.Location = new System.Drawing.Point(376, 44);
            this.Check_FromDate.Name = "Check_FromDate";
            this.Check_FromDate.Size = new System.Drawing.Size(15, 14);
            this.Check_FromDate.TabIndex = 8;
            this.Check_FromDate.UseVisualStyleBackColor = true;
            this.Check_FromDate.CheckedChanged += new System.EventHandler(this.Check_FromDate_CheckedChanged);
            // 
            // Check_ToDate
            // 
            this.Check_ToDate.AutoSize = true;
            this.Check_ToDate.Location = new System.Drawing.Point(376, 72);
            this.Check_ToDate.Name = "Check_ToDate";
            this.Check_ToDate.Size = new System.Drawing.Size(15, 14);
            this.Check_ToDate.TabIndex = 9;
            this.Check_ToDate.UseVisualStyleBackColor = true;
            this.Check_ToDate.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Label_Country
            // 
            this.Label_Country.AutoSize = true;
            this.Label_Country.Location = new System.Drawing.Point(316, 104);
            this.Label_Country.Name = "Label_Country";
            this.Label_Country.Size = new System.Drawing.Size(43, 13);
            this.Label_Country.TabIndex = 10;
            this.Label_Country.Text = "Country";
            // 
            // Check_Country
            // 
            this.Check_Country.AutoSize = true;
            this.Check_Country.Location = new System.Drawing.Point(376, 104);
            this.Check_Country.Name = "Check_Country";
            this.Check_Country.Size = new System.Drawing.Size(15, 14);
            this.Check_Country.TabIndex = 11;
            this.Check_Country.UseVisualStyleBackColor = true;
            this.Check_Country.CheckedChanged += new System.EventHandler(this.Check_Country_CheckedChanged);
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Argentina",
            "Australia",
            "Austria",
            "Belgium",
            "Brazil",
            "Bulgaria",
            "Canada",
            "China",
            "Colombia",
            "Cuba",
            "Czechia",
            "Egypt",
            "France",
            "Germany",
            "Greece",
            "Hong Kong",
            "Hungary",
            "India",
            "Indonesia",
            "Ireland",
            "Israel",
            "Italy",
            "Japan",
            "Korea",
            "Latvia",
            "Lithuania",
            "Malaysia",
            "Mexico",
            "Morocco",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Norway",
            "Philippines",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "Saudi Arabia",
            "Serbia",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "Sweden",
            "Switzerland",
            "Taiwan",
            "Thailand",
            "Turkey",
            "UAE",
            "UK",
            "Ukraine",
            "US",
            "Venezuela"});
            this.Country.Location = new System.Drawing.Point(398, 104);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(121, 21);
            this.Country.Sorted = true;
            this.Country.TabIndex = 12;
            // 
            // Catagory
            // 
            this.Catagory.FormattingEnabled = true;
            this.Catagory.Items.AddRange(new object[] {
            "Business",
            "Entertainment",
            "General",
            "Health",
            "Science",
            "Sports",
            "Technology"});
            this.Catagory.Location = new System.Drawing.Point(398, 133);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(121, 21);
            this.Catagory.Sorted = true;
            this.Catagory.TabIndex = 15;
            // 
            // Check_Catagory
            // 
            this.Check_Catagory.AutoSize = true;
            this.Check_Catagory.Location = new System.Drawing.Point(376, 133);
            this.Check_Catagory.Name = "Check_Catagory";
            this.Check_Catagory.Size = new System.Drawing.Size(15, 14);
            this.Check_Catagory.TabIndex = 14;
            this.Check_Catagory.UseVisualStyleBackColor = true;
            // 
            // Label_Catagory
            // 
            this.Label_Catagory.AutoSize = true;
            this.Label_Catagory.Location = new System.Drawing.Point(316, 133);
            this.Label_Catagory.Name = "Label_Catagory";
            this.Label_Catagory.Size = new System.Drawing.Size(49, 13);
            this.Label_Catagory.TabIndex = 13;
            this.Label_Catagory.Text = "Catagory";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(94, 11);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportBtn.TabIndex = 16;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 617);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.Check_Catagory);
            this.Controls.Add(this.Label_Catagory);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Check_Country);
            this.Controls.Add(this.Label_Country);
            this.Controls.Add(this.Check_ToDate);
            this.Controls.Add(this.Check_FromDate);
            this.Controls.Add(this.Label_ToDate);
            this.Controls.Add(this.Label_From);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label Label_From;
        private System.Windows.Forms.Label Label_ToDate;
        private System.Windows.Forms.CheckBox Check_FromDate;
        private System.Windows.Forms.CheckBox Check_ToDate;
        private System.Windows.Forms.Label Label_Country;
        private System.Windows.Forms.CheckBox Check_Country;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.ComboBox Catagory;
        private System.Windows.Forms.CheckBox Check_Catagory;
        private System.Windows.Forms.Label Label_Catagory;
        private System.Windows.Forms.Button ExportBtn;
    }
}

