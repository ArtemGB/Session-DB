namespace Bd_Session
{
    partial class AddForm
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
            this.SecNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CanselBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecNameBox
            // 
            this.SecNameBox.Location = new System.Drawing.Point(12, 29);
            this.SecNameBox.Name = "SecNameBox";
            this.SecNameBox.Size = new System.Drawing.Size(272, 20);
            this.SecNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите фамилию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите имя";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(15, 73);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(269, 20);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите группу";
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(15, 117);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(187, 20);
            this.GroupBox.TabIndex = 5;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(210, 145);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CanselBtn
            // 
            this.CanselBtn.Location = new System.Drawing.Point(129, 145);
            this.CanselBtn.Name = "CanselBtn";
            this.CanselBtn.Size = new System.Drawing.Size(75, 23);
            this.CanselBtn.TabIndex = 7;
            this.CanselBtn.Text = "Отмена";
            this.CanselBtn.UseVisualStyleBackColor = true;
            this.CanselBtn.Click += new System.EventHandler(this.CanselBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 180);
            this.Controls.Add(this.CanselBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CanselBtn;
    }
}