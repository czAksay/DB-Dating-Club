namespace kursach
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoUsers = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.tTipApply = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoUsers);
            this.groupBox1.Controls.Add(this.pnlUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аккаунты (F5 - обновить)";
            // 
            // lblNoUsers
            // 
            this.lblNoUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoUsers.Location = new System.Drawing.Point(0, 107);
            this.lblNoUsers.Name = "lblNoUsers";
            this.lblNoUsers.Size = new System.Drawing.Size(623, 19);
            this.lblNoUsers.TabIndex = 0;
            this.lblNoUsers.Text = "Нет доступа к пользователям БД";
            this.lblNoUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoUsers.Visible = false;
            // 
            // pnlUsers
            // 
            this.pnlUsers.AutoScroll = true;
            this.pnlUsers.Location = new System.Drawing.Point(0, 21);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(623, 258);
            this.pnlUsers.TabIndex = 0;
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Location = new System.Drawing.Point(400, 289);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(225, 34);
            this.btnRegistrate.TabIndex = 1;
            this.btnRegistrate.Text = "Регистрация нового пользователя";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // tTipApply
            // 
            this.tTipApply.AutoPopDelay = 10000;
            this.tTipApply.InitialDelay = 500;
            this.tTipApply.ReshowDelay = 100;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 326);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminPanel_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblNoUsers;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.ToolTip tTipApply;
    }
}