namespace Системный_анализ
{
    partial class ExpertEdit
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
            this.ExpertNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpertNameLabel = new System.Windows.Forms.Label();
            this.ExpertAgeTextBox = new System.Windows.Forms.TextBox();
            this.ExpertSexTextBox = new System.Windows.Forms.TextBox();
            this.ExpertAgeLabel = new System.Windows.Forms.Label();
            this.ExpertSexLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpertNameTextBox
            // 
            this.ExpertNameTextBox.Location = new System.Drawing.Point(136, 48);
            this.ExpertNameTextBox.Name = "ExpertNameTextBox";
            this.ExpertNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertNameTextBox.TabIndex = 5;
            // 
            // ExpertNameLabel
            // 
            this.ExpertNameLabel.AutoSize = true;
            this.ExpertNameLabel.Location = new System.Drawing.Point(97, 48);
            this.ExpertNameLabel.Name = "ExpertNameLabel";
            this.ExpertNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ExpertNameLabel.TabIndex = 8;
            this.ExpertNameLabel.Text = "Имя";
            // 
            // ExpertAgeTextBox
            // 
            this.ExpertAgeTextBox.Location = new System.Drawing.Point(136, 75);
            this.ExpertAgeTextBox.Name = "ExpertAgeTextBox";
            this.ExpertAgeTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertAgeTextBox.TabIndex = 11;
            // 
            // ExpertSexTextBox
            // 
            this.ExpertSexTextBox.Location = new System.Drawing.Point(136, 101);
            this.ExpertSexTextBox.Name = "ExpertSexTextBox";
            this.ExpertSexTextBox.Size = new System.Drawing.Size(151, 20);
            this.ExpertSexTextBox.TabIndex = 12;
            // 
            // ExpertAgeLabel
            // 
            this.ExpertAgeLabel.AutoSize = true;
            this.ExpertAgeLabel.Location = new System.Drawing.Point(81, 75);
            this.ExpertAgeLabel.Name = "ExpertAgeLabel";
            this.ExpertAgeLabel.Size = new System.Drawing.Size(49, 13);
            this.ExpertAgeLabel.TabIndex = 13;
            this.ExpertAgeLabel.Text = "Возраст";
            // 
            // ExpertSexLabel
            // 
            this.ExpertSexLabel.AutoSize = true;
            this.ExpertSexLabel.Location = new System.Drawing.Point(103, 101);
            this.ExpertSexLabel.Name = "ExpertSexLabel";
            this.ExpertSexLabel.Size = new System.Drawing.Size(27, 13);
            this.ExpertSexLabel.TabIndex = 14;
            this.ExpertSexLabel.Text = "Пол";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(151, 127);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(114, 33);
            this.ChangeButton.TabIndex = 15;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 175);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 33);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExpertEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 220);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ExpertSexLabel);
            this.Controls.Add(this.ExpertAgeLabel);
            this.Controls.Add(this.ExpertSexTextBox);
            this.Controls.Add(this.ExpertAgeTextBox);
            this.Controls.Add(this.ExpertNameLabel);
            this.Controls.Add(this.ExpertNameTextBox);
            this.Name = "ExpertEdit";
            this.Text = "Изменить данные об эксперте";
            this.Load += new System.EventHandler(this.ExpertEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExpertNameTextBox;
        private System.Windows.Forms.Label ExpertNameLabel;
        private System.Windows.Forms.TextBox ExpertAgeTextBox;
        private System.Windows.Forms.TextBox ExpertSexTextBox;
        private System.Windows.Forms.Label ExpertAgeLabel;
        private System.Windows.Forms.Label ExpertSexLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button BackButton;
    }
}