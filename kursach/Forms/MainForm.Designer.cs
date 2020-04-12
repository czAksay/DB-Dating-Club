namespace kursach
{
    partial class MainForm
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
            this.lblYouEntered = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblNoTable = new System.Windows.Forms.Label();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCloseClient = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.gbActionButtons = new System.Windows.Forms.GroupBox();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbButtonDescription = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbActionButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).BeginInit();
            this.pnlActions.Panel1.SuspendLayout();
            this.pnlActions.Panel2.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYouEntered
            // 
            this.lblYouEntered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYouEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYouEntered.Location = new System.Drawing.Point(253, 20);
            this.lblYouEntered.Name = "lblYouEntered";
            this.lblYouEntered.Size = new System.Drawing.Size(477, 24);
            this.lblYouEntered.TabIndex = 0;
            this.lblYouEntered.Text = "Вы вошли как: никто";
            this.lblYouEntered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.Controls.Add(this.lblNoTable);
            this.pnlTable.Controls.Add(this.btnResetFilters);
            this.pnlTable.Controls.Add(this.btnFilter);
            this.pnlTable.Controls.Add(this.tableLayoutPanel1);
            this.pnlTable.Controls.Add(this.btnRefreshTable);
            this.pnlTable.Controls.Add(this.dataGridView);
            this.pnlTable.Location = new System.Drawing.Point(24, 47);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(706, 403);
            this.pnlTable.TabIndex = 4;
            this.pnlTable.Visible = false;
            // 
            // lblNoTable
            // 
            this.lblNoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoTable.AutoSize = true;
            this.lblNoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNoTable.Location = new System.Drawing.Point(261, 161);
            this.lblNoTable.Name = "lblNoTable";
            this.lblNoTable.Size = new System.Drawing.Size(189, 18);
            this.lblNoTable.TabIndex = 8;
            this.lblNoTable.Text = "Нет доступа к отношению";
            this.lblNoTable.Visible = false;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Location = new System.Drawing.Point(563, 3);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(67, 40);
            this.btnResetFilters.TabIndex = 7;
            this.btnResetFilters.Text = "Сброс";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(490, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(67, 40);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCloseClient, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 347);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(353, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(178, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 47);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCloseClient
            // 
            this.btnCloseClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseClient.Location = new System.Drawing.Point(528, 3);
            this.btnCloseClient.Name = "btnCloseClient";
            this.btnCloseClient.Size = new System.Drawing.Size(169, 47);
            this.btnCloseClient.TabIndex = 2;
            this.btnCloseClient.Text = "Закрыть";
            this.btnCloseClient.UseVisualStyleBackColor = true;
            this.btnCloseClient.Click += new System.EventHandler(this.btnCloseClient_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTable.Location = new System.Drawing.Point(636, 3);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(67, 40);
            this.btnRefreshTable.TabIndex = 1;
            this.btnRefreshTable.Text = "Обн.";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 45);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(700, 296);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Location = new System.Drawing.Point(192, 274);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(151, 39);
            this.btnChangeUser.TabIndex = 0;
            this.btnChangeUser.Text = "Сменить пользователя";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            this.btnChangeUser.MouseEnter += new System.EventHandler(this.btnChangeUser_MouseEnter);
            this.btnChangeUser.MouseLeave += new System.EventHandler(this.btnChangeUser_MouseLeave);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Location = new System.Drawing.Point(192, 316);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(151, 39);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.Text = "Закрыть программу";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            this.btnCloseApp.MouseEnter += new System.EventHandler(this.btnCloseApp_MouseEnter);
            this.btnCloseApp.MouseLeave += new System.EventHandler(this.btnCloseApp_MouseLeave);
            // 
            // gbActionButtons
            // 
            this.gbActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActionButtons.Controls.Add(this.pnlActionButtons);
            this.gbActionButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbActionButtons.Location = new System.Drawing.Point(3, 3);
            this.gbActionButtons.Name = "gbActionButtons";
            this.gbActionButtons.Size = new System.Drawing.Size(347, 358);
            this.gbActionButtons.TabIndex = 0;
            this.gbActionButtons.TabStop = false;
            this.gbActionButtons.Text = " Действия ";
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionButtons.AutoScroll = true;
            this.pnlActionButtons.Location = new System.Drawing.Point(3, 25);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(344, 327);
            this.pnlActionButtons.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbButtonDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Описание ";
            // 
            // lbButtonDescription
            // 
            this.lbButtonDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbButtonDescription.Location = new System.Drawing.Point(15, 25);
            this.lbButtonDescription.Name = "lbButtonDescription";
            this.lbButtonDescription.Size = new System.Drawing.Size(313, 231);
            this.lbButtonDescription.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Location = new System.Drawing.Point(24, 89);
            this.pnlActions.Name = "pnlActions";
            // 
            // pnlActions.Panel1
            // 
            this.pnlActions.Panel1.Controls.Add(this.gbActionButtons);
            // 
            // pnlActions.Panel2
            // 
            this.pnlActions.Panel2.Controls.Add(this.groupBox1);
            this.pnlActions.Panel2.Controls.Add(this.btnChangeUser);
            this.pnlActions.Panel2.Controls.Add(this.btnCloseApp);
            this.pnlActions.Size = new System.Drawing.Size(706, 361);
            this.pnlActions.SplitterDistance = 353;
            this.pnlActions.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursach.Properties.Resources.Без_имени_1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lblYouEntered);
            this.MinimumSize = new System.Drawing.Size(767, 517);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Главная";
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbActionButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlActions.Panel1.ResumeLayout(false);
            this.pnlActions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).EndInit();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYouEntered;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCloseClient;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.GroupBox gbActionButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer pnlActions;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Label lbButtonDescription;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Label lblNoTable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}