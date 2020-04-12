namespace kursach
{
    partial class ClientFilter
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkClub = new System.Windows.Forms.CheckBox();
            this.cbProsperity = new System.Windows.Forms.ComboBox();
            this.cbMartialStatus = new System.Windows.Forms.ComboBox();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.numClub = new System.Windows.Forms.NumericUpDown();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSur = new System.Windows.Forms.TextBox();
            this.chkSurn = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkPatr = new System.Windows.Forms.CheckBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.chkNation = new System.Windows.Forms.CheckBox();
            this.chkMartial = new System.Windows.Forms.CheckBox();
            this.chkCountry = new System.Windows.Forms.CheckBox();
            this.chkCity = new System.Windows.Forms.CheckBox();
            this.chkProsp = new System.Windows.Forms.CheckBox();
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.cbSignHeight = new System.Windows.Forms.ComboBox();
            this.cbSignWeight = new System.Windows.Forms.ComboBox();
            this.cbSignProsperity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClub)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-1, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(721, 36);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Фильтр клиентов";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // chkClub
            // 
            this.chkClub.AutoSize = true;
            this.chkClub.Location = new System.Drawing.Point(20, 45);
            this.chkClub.Name = "chkClub";
            this.chkClub.Size = new System.Drawing.Size(113, 17);
            this.chkClub.TabIndex = 43;
            this.chkClub.Text = "Отделение клуба";
            this.chkClub.UseVisualStyleBackColor = true;
            // 
            // cbProsperity
            // 
            this.cbProsperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProsperity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProsperity.FormattingEnabled = true;
            this.cbProsperity.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий"});
            this.cbProsperity.Location = new System.Drawing.Point(544, 210);
            this.cbProsperity.Name = "cbProsperity";
            this.cbProsperity.Size = new System.Drawing.Size(145, 21);
            this.cbProsperity.TabIndex = 79;
            // 
            // cbMartialStatus
            // 
            this.cbMartialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMartialStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMartialStatus.FormattingEnabled = true;
            this.cbMartialStatus.Items.AddRange(new object[] {
            "В браке",
            "Развод",
            "Не в браке"});
            this.cbMartialStatus.Location = new System.Drawing.Point(501, 45);
            this.cbMartialStatus.Name = "cbMartialStatus";
            this.cbMartialStatus.Size = new System.Drawing.Size(190, 21);
            this.cbMartialStatus.TabIndex = 78;
            // 
            // cbNationality
            // 
            this.cbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNationality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(162, 231);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(151, 21);
            this.cbNationality.TabIndex = 77;
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(544, 179);
            this.numWeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(145, 20);
            this.numWeight.TabIndex = 74;
            this.numWeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(544, 153);
            this.numHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(145, 20);
            this.numHeight.TabIndex = 72;
            this.numHeight.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(501, 118);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(189, 20);
            this.tbCity.TabIndex = 69;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(502, 82);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(189, 20);
            this.tbCountry.TabIndex = 67;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cbGender.Location = new System.Drawing.Point(162, 192);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 21);
            this.cbGender.TabIndex = 65;
            // 
            // numClub
            // 
            this.numClub.Location = new System.Drawing.Point(211, 43);
            this.numClub.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClub.Name = "numClub";
            this.numClub.Size = new System.Drawing.Size(102, 20);
            this.numClub.TabIndex = 63;
            this.numClub.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(139, 155);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(174, 20);
            this.tbPatr.TabIndex = 58;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 118);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(174, 20);
            this.tbName.TabIndex = 57;
            // 
            // tbSur
            // 
            this.tbSur.Location = new System.Drawing.Point(139, 82);
            this.tbSur.Name = "tbSur";
            this.tbSur.Size = new System.Drawing.Size(174, 20);
            this.tbSur.TabIndex = 56;
            // 
            // chkSurn
            // 
            this.chkSurn.AutoSize = true;
            this.chkSurn.Location = new System.Drawing.Point(20, 83);
            this.chkSurn.Name = "chkSurn";
            this.chkSurn.Size = new System.Drawing.Size(75, 17);
            this.chkSurn.TabIndex = 80;
            this.chkSurn.Text = "Фамилия";
            this.chkSurn.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(20, 120);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(48, 17);
            this.chkName.TabIndex = 81;
            this.chkName.Text = "Имя";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // chkPatr
            // 
            this.chkPatr.AutoSize = true;
            this.chkPatr.Location = new System.Drawing.Point(20, 156);
            this.chkPatr.Name = "chkPatr";
            this.chkPatr.Size = new System.Drawing.Size(73, 17);
            this.chkPatr.TabIndex = 82;
            this.chkPatr.Text = "Отчество";
            this.chkPatr.UseVisualStyleBackColor = true;
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(20, 196);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(46, 17);
            this.chkGender.TabIndex = 83;
            this.chkGender.Text = "Пол";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // chkNation
            // 
            this.chkNation.AutoSize = true;
            this.chkNation.Location = new System.Drawing.Point(20, 232);
            this.chkNation.Name = "chkNation";
            this.chkNation.Size = new System.Drawing.Size(111, 17);
            this.chkNation.TabIndex = 84;
            this.chkNation.Text = "Национальность";
            this.chkNation.UseVisualStyleBackColor = true;
            // 
            // chkMartial
            // 
            this.chkMartial.AutoSize = true;
            this.chkMartial.Location = new System.Drawing.Point(363, 48);
            this.chkMartial.Name = "chkMartial";
            this.chkMartial.Size = new System.Drawing.Size(136, 17);
            this.chkMartial.TabIndex = 85;
            this.chkMartial.Text = "Семейное положение";
            this.chkMartial.UseVisualStyleBackColor = true;
            // 
            // chkCountry
            // 
            this.chkCountry.AutoSize = true;
            this.chkCountry.Location = new System.Drawing.Point(363, 84);
            this.chkCountry.Name = "chkCountry";
            this.chkCountry.Size = new System.Drawing.Size(62, 17);
            this.chkCountry.TabIndex = 86;
            this.chkCountry.Text = "Страна";
            this.chkCountry.UseVisualStyleBackColor = true;
            // 
            // chkCity
            // 
            this.chkCity.AutoSize = true;
            this.chkCity.Location = new System.Drawing.Point(363, 120);
            this.chkCity.Name = "chkCity";
            this.chkCity.Size = new System.Drawing.Size(56, 17);
            this.chkCity.TabIndex = 87;
            this.chkCity.Text = "Город";
            this.chkCity.UseVisualStyleBackColor = true;
            // 
            // chkProsp
            // 
            this.chkProsp.AutoSize = true;
            this.chkProsp.Location = new System.Drawing.Point(363, 213);
            this.chkProsp.Name = "chkProsp";
            this.chkProsp.Size = new System.Drawing.Size(75, 17);
            this.chkProsp.TabIndex = 88;
            this.chkProsp.Text = "Достаток";
            this.chkProsp.UseVisualStyleBackColor = true;
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Location = new System.Drawing.Point(363, 181);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(45, 17);
            this.chkWeight.TabIndex = 89;
            this.chkWeight.Text = "Вес";
            this.chkWeight.UseVisualStyleBackColor = true;
            // 
            // chkHeight
            // 
            this.chkHeight.AutoSize = true;
            this.chkHeight.Location = new System.Drawing.Point(363, 152);
            this.chkHeight.Name = "chkHeight";
            this.chkHeight.Size = new System.Drawing.Size(50, 17);
            this.chkHeight.TabIndex = 90;
            this.chkHeight.Text = "Рост";
            this.chkHeight.UseVisualStyleBackColor = true;
            // 
            // cbSignHeight
            // 
            this.cbSignHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignHeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignHeight.FormattingEnabled = true;
            this.cbSignHeight.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignHeight.Location = new System.Drawing.Point(453, 150);
            this.cbSignHeight.Name = "cbSignHeight";
            this.cbSignHeight.Size = new System.Drawing.Size(71, 21);
            this.cbSignHeight.TabIndex = 91;
            // 
            // cbSignWeight
            // 
            this.cbSignWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignWeight.FormattingEnabled = true;
            this.cbSignWeight.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignWeight.Location = new System.Drawing.Point(453, 179);
            this.cbSignWeight.Name = "cbSignWeight";
            this.cbSignWeight.Size = new System.Drawing.Size(71, 21);
            this.cbSignWeight.TabIndex = 92;
            // 
            // cbSignProsperity
            // 
            this.cbSignProsperity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignProsperity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSignProsperity.FormattingEnabled = true;
            this.cbSignProsperity.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cbSignProsperity.Location = new System.Drawing.Point(453, 209);
            this.cbSignProsperity.Name = "cbSignProsperity";
            this.cbSignProsperity.Size = new System.Drawing.Size(71, 21);
            this.cbSignProsperity.TabIndex = 93;
            // 
            // ClientFilter
            // 
            this.ClientSize = new System.Drawing.Size(720, 346);
            this.Controls.Add(this.cbSignProsperity);
            this.Controls.Add(this.cbSignWeight);
            this.Controls.Add(this.cbSignHeight);
            this.Controls.Add(this.chkHeight);
            this.Controls.Add(this.chkWeight);
            this.Controls.Add(this.chkProsp);
            this.Controls.Add(this.chkCity);
            this.Controls.Add(this.chkCountry);
            this.Controls.Add(this.chkMartial);
            this.Controls.Add(this.chkNation);
            this.Controls.Add(this.chkGender);
            this.Controls.Add(this.chkPatr);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.chkSurn);
            this.Controls.Add(this.cbProsperity);
            this.Controls.Add(this.cbMartialStatus);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.numClub);
            this.Controls.Add(this.tbPatr);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSur);
            this.Controls.Add(this.chkClub);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkClub;
        private System.Windows.Forms.ComboBox cbProsperity;
        private System.Windows.Forms.ComboBox cbMartialStatus;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.NumericUpDown numClub;
        private System.Windows.Forms.TextBox tbPatr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSur;
        private System.Windows.Forms.CheckBox chkSurn;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.CheckBox chkPatr;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.CheckBox chkNation;
        private System.Windows.Forms.CheckBox chkMartial;
        private System.Windows.Forms.CheckBox chkCountry;
        private System.Windows.Forms.CheckBox chkCity;
        private System.Windows.Forms.CheckBox chkProsp;
        private System.Windows.Forms.CheckBox chkWeight;
        private System.Windows.Forms.CheckBox chkHeight;
        private System.Windows.Forms.ComboBox cbSignHeight;
        private System.Windows.Forms.ComboBox cbSignWeight;
        private System.Windows.Forms.ComboBox cbSignProsperity;
    }
}