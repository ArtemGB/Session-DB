namespace Bd_Session
{
    partial class MainForm
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ExData = new System.Windows.Forms.DataGridView();
            this.ExName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StData = new System.Windows.Forms.DataGridView();
            this.StNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StSecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StData)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 386);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(361, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchLabel.Location = new System.Drawing.Point(22, 389);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(48, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Поиск...";
            this.SearchLabel.Click += new System.EventHandler(this.SearchLabel_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(379, 144);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(95, 23);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(378, 173);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(378, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(378, 203);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(96, 23);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExData
            // 
            this.ExData.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.ExData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExName,
            this.ExScore});
            this.ExData.Location = new System.Drawing.Point(480, 24);
            this.ExData.Name = "ExData";
            this.ExData.ReadOnly = true;
            this.ExData.RowHeadersVisible = false;
            this.ExData.Size = new System.Drawing.Size(248, 382);
            this.ExData.TabIndex = 10;
            // 
            // ExName
            // 
            this.ExName.Frozen = true;
            this.ExName.HeaderText = "Экзамен";
            this.ExName.Name = "ExName";
            this.ExName.ReadOnly = true;
            this.ExName.Width = 148;
            // 
            // ExScore
            // 
            this.ExScore.Frozen = true;
            this.ExScore.HeaderText = "Оценка";
            this.ExScore.Name = "ExScore";
            this.ExScore.ReadOnly = true;
            // 
            // StData
            // 
            this.StData.AllowUserToAddRows = false;
            this.StData.AllowUserToDeleteRows = false;
            this.StData.AllowUserToResizeRows = false;
            this.StData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StNum,
            this.StSecName,
            this.StName,
            this.StGroup});
            this.StData.Location = new System.Drawing.Point(13, 24);
            this.StData.Name = "StData";
            this.StData.ReadOnly = true;
            this.StData.RowHeadersVisible = false;
            this.StData.Size = new System.Drawing.Size(360, 356);
            this.StData.TabIndex = 11;
            this.StData.Click += new System.EventHandler(this.StData_Click);
            // 
            // StNum
            // 
            this.StNum.Frozen = true;
            this.StNum.HeaderText = "№";
            this.StNum.Name = "StNum";
            this.StNum.ReadOnly = true;
            this.StNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StNum.Width = 40;
            // 
            // StSecName
            // 
            this.StSecName.Frozen = true;
            this.StSecName.HeaderText = "Фамилия";
            this.StSecName.Name = "StSecName";
            this.StSecName.ReadOnly = true;
            this.StSecName.Width = 110;
            // 
            // StName
            // 
            this.StName.Frozen = true;
            this.StName.HeaderText = "Имя";
            this.StName.Name = "StName";
            this.StName.ReadOnly = true;
            this.StName.Width = 110;
            // 
            // StGroup
            // 
            this.StGroup.Frozen = true;
            this.StGroup.HeaderText = "Группа";
            this.StGroup.Name = "StGroup";
            this.StGroup.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 416);
            this.Controls.Add(this.StData);
            this.Controls.Add(this.ExData);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "База данных студентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ExData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ExData;
        private System.Windows.Forms.DataGridView StData;
        private System.Windows.Forms.DataGridViewTextBoxColumn StNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StSecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExScore;
    }
}

