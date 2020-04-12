namespace kursach
{
    partial class PareAction
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
            this.pnlId = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.numClient2Id = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numClientID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClient2Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Controls.Add(this.label28);
            this.pnlId.Enabled = false;
            this.pnlId.Location = new System.Drawing.Point(10, 34);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(279, 31);
            this.pnlId.TabIndex = 47;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(67, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(185, 20);
            this.tbId.TabIndex = 42;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(36, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "ID";
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(-1, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(303, 28);
            this.lbltitle.TabIndex = 46;
            this.lbltitle.Text = "TEXT";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 141);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(276, 39);
            this.btnAction.TabIndex = 48;
            this.btnAction.Text = "Text";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // numClient2Id
            // 
            this.numClient2Id.Location = new System.Drawing.Point(169, 104);
            this.numClient2Id.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numClient2Id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClient2Id.Name = "numClient2Id";
            this.numClient2Id.Size = new System.Drawing.Size(120, 20);
            this.numClient2Id.TabIndex = 52;
            this.numClient2Id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "ID клиента 2";
            // 
            // numClientID
            // 
            this.numClientID.Location = new System.Drawing.Point(169, 78);
            this.numClientID.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numClientID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClientID.Name = "numClientID";
            this.numClientID.Size = new System.Drawing.Size(120, 20);
            this.numClientID.TabIndex = 50;
            this.numClientID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID клиента 1";
            // 
            // PareAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 192);
            this.Controls.Add(this.numClient2Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numClientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PareAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClient2Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown numClient2Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numClientID;
        private System.Windows.Forms.Label label4;
    }
}