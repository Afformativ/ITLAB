namespace itLab1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.butOpen = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.butAddColumn = new System.Windows.Forms.Button();
            this.butAddRow = new System.Windows.Forms.Button();
            this.tbCreateDBName = new System.Windows.Forms.TextBox();
            this.butAddTable = new System.Windows.Forms.Button();
            this.tbAddTableName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.tbAddColumnName = new System.Windows.Forms.TextBox();
            this.butChooseFilePath = new System.Windows.Forms.Button();
            this.ofdChooseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.butDeleteColumn = new System.Windows.Forms.Button();
            this.butDeleteRow = new System.Windows.Forms.Button();
            this.butDeleteTable = new System.Windows.Forms.Button();
            this.sfdSaveDB = new System.Windows.Forms.SaveFileDialog();
            this.butSaveDB = new System.Windows.Forms.Button();
            this.ofdOpenDB = new System.Windows.Forms.OpenFileDialog();
            this.butSearch = new System.Windows.Forms.Button();
            this.butCancelSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(16, 240);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1035, 37);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(16, 18);
            this.butOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(161, 35);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Open";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(195, 18);
            this.butCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(161, 35);
            this.butCreate.TabIndex = 2;
            this.butCreate.Text = "New DB";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butAddColumn
            // 
            this.butAddColumn.Location = new System.Drawing.Point(552, 18);
            this.butAddColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddColumn.Name = "butAddColumn";
            this.butAddColumn.Size = new System.Drawing.Size(161, 35);
            this.butAddColumn.TabIndex = 3;
            this.butAddColumn.Text = "Add Column";
            this.butAddColumn.UseVisualStyleBackColor = true;
            this.butAddColumn.Click += new System.EventHandler(this.butAddColumn_Click);
            // 
            // butAddRow
            // 
            this.butAddRow.Location = new System.Drawing.Point(728, 18);
            this.butAddRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddRow.Name = "butAddRow";
            this.butAddRow.Size = new System.Drawing.Size(161, 35);
            this.butAddRow.TabIndex = 4;
            this.butAddRow.Text = "Add Row";
            this.butAddRow.UseVisualStyleBackColor = true;
            this.butAddRow.Click += new System.EventHandler(this.butAddRow_Click);
            // 
            // tbCreateDBName
            // 
            this.tbCreateDBName.Location = new System.Drawing.Point(195, 63);
            this.tbCreateDBName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCreateDBName.Name = "tbCreateDBName";
            this.tbCreateDBName.Size = new System.Drawing.Size(160, 27);
            this.tbCreateDBName.TabIndex = 5;
            // 
            // butAddTable
            // 
            this.butAddTable.Location = new System.Drawing.Point(373, 18);
            this.butAddTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAddTable.Name = "butAddTable";
            this.butAddTable.Size = new System.Drawing.Size(161, 35);
            this.butAddTable.TabIndex = 6;
            this.butAddTable.Text = "Add Table";
            this.butAddTable.UseVisualStyleBackColor = true;
            this.butAddTable.Click += new System.EventHandler(this.butAddTable_Click);
            // 
            // tbAddTableName
            // 
            this.tbAddTableName.Location = new System.Drawing.Point(373, 63);
            this.tbAddTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddTableName.Name = "tbAddTableName";
            this.tbAddTableName.Size = new System.Drawing.Size(160, 27);
            this.tbAddTableName.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 286);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1033, 486);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "Integer",
            "Real",
            "Char",
            "String",
            "Path",
            "IntegerInvl"});
            this.cbTypes.Location = new System.Drawing.Point(552, 103);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(160, 28);
            this.cbTypes.TabIndex = 10;
            // 
            // tbAddColumnName
            // 
            this.tbAddColumnName.Location = new System.Drawing.Point(552, 63);
            this.tbAddColumnName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddColumnName.Name = "tbAddColumnName";
            this.tbAddColumnName.Size = new System.Drawing.Size(160, 27);
            this.tbAddColumnName.TabIndex = 11;
            // 
            // butChooseFilePath
            // 
            this.butChooseFilePath.Location = new System.Drawing.Point(805, 123);
            this.butChooseFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butChooseFilePath.Name = "butChooseFilePath";
            this.butChooseFilePath.Size = new System.Drawing.Size(165, 35);
            this.butChooseFilePath.TabIndex = 12;
            this.butChooseFilePath.Text = "Get file path";
            this.butChooseFilePath.UseVisualStyleBackColor = true;
            this.butChooseFilePath.Click += new System.EventHandler(this.butChooseFilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(728, 168);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(321, 27);
            this.tbFilePath.TabIndex = 13;
            // 
            // butDeleteColumn
            // 
            this.butDeleteColumn.Location = new System.Drawing.Point(552, 145);
            this.butDeleteColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeleteColumn.Name = "butDeleteColumn";
            this.butDeleteColumn.Size = new System.Drawing.Size(161, 35);
            this.butDeleteColumn.TabIndex = 14;
            this.butDeleteColumn.Text = "Delete Column";
            this.butDeleteColumn.UseVisualStyleBackColor = true;
            this.butDeleteColumn.Click += new System.EventHandler(this.butDeleteColumn_Click);
            // 
            // butDeleteRow
            // 
            this.butDeleteRow.Location = new System.Drawing.Point(728, 63);
            this.butDeleteRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeleteRow.Name = "butDeleteRow";
            this.butDeleteRow.Size = new System.Drawing.Size(161, 35);
            this.butDeleteRow.TabIndex = 15;
            this.butDeleteRow.Text = "Delete Row";
            this.butDeleteRow.UseVisualStyleBackColor = true;
            this.butDeleteRow.Click += new System.EventHandler(this.butDeleteRow_Click);
            // 
            // butDeleteTable
            // 
            this.butDeleteTable.Location = new System.Drawing.Point(373, 103);
            this.butDeleteTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeleteTable.Name = "butDeleteTable";
            this.butDeleteTable.Size = new System.Drawing.Size(161, 35);
            this.butDeleteTable.TabIndex = 16;
            this.butDeleteTable.Text = "Delete Table";
            this.butDeleteTable.UseVisualStyleBackColor = true;
            this.butDeleteTable.Click += new System.EventHandler(this.butDeleteTable_Click);
            // 
            // butSaveDB
            // 
            this.butSaveDB.Location = new System.Drawing.Point(16, 63);
            this.butSaveDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSaveDB.Name = "butSaveDB";
            this.butSaveDB.Size = new System.Drawing.Size(161, 35);
            this.butSaveDB.TabIndex = 17;
            this.butSaveDB.Text = "Save";
            this.butSaveDB.UseVisualStyleBackColor = true;
            this.butSaveDB.Click += new System.EventHandler(this.butSaveDB_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(17, 145);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(161, 35);
            this.butSearch.TabIndex = 18;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butCancelSearch
            // 
            this.butCancelSearch.Location = new System.Drawing.Point(16, 189);
            this.butCancelSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancelSearch.Name = "butCancelSearch";
            this.butCancelSearch.Size = new System.Drawing.Size(161, 35);
            this.butCancelSearch.TabIndex = 19;
            this.butCancelSearch.Text = "Cancel";
            this.butCancelSearch.UseVisualStyleBackColor = true;
            this.butCancelSearch.Click += new System.EventHandler(this.butCancelSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(185, 168);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(348, 27);
            this.tbSearch.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 791);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.butCancelSearch);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butSaveDB);
            this.Controls.Add(this.butDeleteTable);
            this.Controls.Add(this.butDeleteRow);
            this.Controls.Add(this.butDeleteColumn);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.butChooseFilePath);
            this.Controls.Add(this.tbAddColumnName);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbAddTableName);
            this.Controls.Add(this.butAddTable);
            this.Controls.Add(this.tbCreateDBName);
            this.Controls.Add(this.butAddRow);
            this.Controls.Add(this.butAddColumn);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Hrabar TTP-41";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Button butAddColumn;
        private System.Windows.Forms.Button butAddRow;
        private System.Windows.Forms.TextBox tbCreateDBName;
        private System.Windows.Forms.Button butAddTable;
        private System.Windows.Forms.TextBox tbAddTableName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.TextBox tbAddColumnName;
        private System.Windows.Forms.Button butChooseFilePath;
        private System.Windows.Forms.OpenFileDialog ofdChooseFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button butDeleteColumn;
        private System.Windows.Forms.Button butDeleteRow;
        private System.Windows.Forms.Button butDeleteTable;
        private System.Windows.Forms.SaveFileDialog sfdSaveDB;
        private System.Windows.Forms.Button butSaveDB;
        private System.Windows.Forms.OpenFileDialog ofdOpenDB;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butCancelSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
