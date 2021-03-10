namespace Системный_анализ
{
    partial class AddExpert
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExpertAgeTextBox = new System.Windows.Forms.TextBox();
            this.ExpertLoginTextBox = new System.Windows.Forms.TextBox();
            this.ExpertNametextBox = new System.Windows.Forms.TextBox();
            this.ExpertSexTextBox = new System.Windows.Forms.TextBox();
            this.ExpertLoginLabel = new System.Windows.Forms.Label();
            this.ExpertNameLabel = new System.Windows.Forms.Label();
            this.ExpertAgeLabel = new System.Windows.Forms.Label();
            this.ExpertSexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 215);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 33);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(145, 134);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 33);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExpertAgeTextBox
            // 
            this.ExpertAgeTextBox.Location = new System.Drawing.Point(27, 108);
            this.ExpertAgeTextBox.Name = "ExpertAgeTextBox";
            this.ExpertAgeTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertAgeTextBox.TabIndex = 2;
            // 
            // ExpertLoginTextBox
            // 
            this.ExpertLoginTextBox.Location = new System.Drawing.Point(235, 55);
            this.ExpertLoginTextBox.Name = "ExpertLoginTextBox";
            this.ExpertLoginTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertLoginTextBox.TabIndex = 3;
            // 
            // ExpertNametextBox
            // 
            this.ExpertNametextBox.Location = new System.Drawing.Point(27, 55);
            this.ExpertNametextBox.Name = "ExpertNametextBox";
            this.ExpertNametextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertNametextBox.TabIndex = 4;
            // 
            // ExpertSexTextBox
            // 
            this.ExpertSexTextBox.Location = new System.Drawing.Point(235, 108);
            this.ExpertSexTextBox.Name = "ExpertSexTextBox";
            this.ExpertSexTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertSexTextBox.TabIndex = 5;
            // 
            // ExpertLoginLabel
            // 
            this.ExpertLoginLabel.AutoSize = true;
            this.ExpertLoginLabel.Location = new System.Drawing.Point(232, 39);
            this.ExpertLoginLabel.Name = "ExpertLoginLabel";
            this.ExpertLoginLabel.Size = new System.Drawing.Size(38, 13);
            this.ExpertLoginLabel.TabIndex = 6;
            this.ExpertLoginLabel.Text = "Логин";
            // 
            // ExpertNameLabel
            // 
            this.ExpertNameLabel.AutoSize = true;
            this.ExpertNameLabel.Location = new System.Drawing.Point(24, 39);
            this.ExpertNameLabel.Name = "ExpertNameLabel";
            this.ExpertNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ExpertNameLabel.TabIndex = 7;
            this.ExpertNameLabel.Text = "Имя";
            // 
            // ExpertAgeLabel
            // 
            this.ExpertAgeLabel.AutoSize = true;
            this.ExpertAgeLabel.Location = new System.Drawing.Point(24, 92);
            this.ExpertAgeLabel.Name = "ExpertAgeLabel";
            this.ExpertAgeLabel.Size = new System.Drawing.Size(49, 13);
            this.ExpertAgeLabel.TabIndex = 8;
            this.ExpertAgeLabel.Text = "Возраст";
            // 
            // ExpertSexLabel
            // 
            this.ExpertSexLabel.AutoSize = true;
            this.ExpertSexLabel.Location = new System.Drawing.Point(232, 92);
            this.ExpertSexLabel.Name = "ExpertSexLabel";
            this.ExpertSexLabel.Size = new System.Drawing.Size(27, 13);
            this.ExpertSexLabel.TabIndex = 9;
            this.ExpertSexLabel.Text = "Пол";
            // 
            // AddExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 260);
            this.Controls.Add(this.ExpertSexLabel);
            this.Controls.Add(this.ExpertAgeLabel);
            this.Controls.Add(this.ExpertNameLabel);
            this.Controls.Add(this.ExpertLoginLabel);
            this.Controls.Add(this.ExpertSexTextBox);
            this.Controls.Add(this.ExpertNametextBox);
            this.Controls.Add(this.ExpertLoginTextBox);
            this.Controls.Add(this.ExpertAgeTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Name = "AddExpert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить эксперта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ExpertAgeTextBox;
        private System.Windows.Forms.TextBox ExpertLoginTextBox;
        private System.Windows.Forms.TextBox ExpertNametextBox;
        private System.Windows.Forms.TextBox ExpertSexTextBox;
        private System.Windows.Forms.Label ExpertLoginLabel;
        private System.Windows.Forms.Label ExpertNameLabel;
        private System.Windows.Forms.Label ExpertAgeLabel;
        private System.Windows.Forms.Label ExpertSexLabel;
    }
}