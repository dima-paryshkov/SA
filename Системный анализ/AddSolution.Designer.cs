namespace Системный_анализ
{
    partial class AddSolution
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
            this.AddSolutionLabel = new System.Windows.Forms.Label();
            this.AddSolutionTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddSolutionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddSolutionLabel
            // 
            this.AddSolutionLabel.AutoSize = true;
            this.AddSolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolutionLabel.Location = new System.Drawing.Point(150, 33);
            this.AddSolutionLabel.Name = "AddSolutionLabel";
            this.AddSolutionLabel.Size = new System.Drawing.Size(195, 20);
            this.AddSolutionLabel.TabIndex = 0;
            this.AddSolutionLabel.Text = "Добавить альтернативу";
            // 
            // AddSolutionTextBox
            // 
            this.AddSolutionTextBox.Location = new System.Drawing.Point(12, 86);
            this.AddSolutionTextBox.Multiline = true;
            this.AddSolutionTextBox.Name = "AddSolutionTextBox";
            this.AddSolutionTextBox.Size = new System.Drawing.Size(455, 222);
            this.AddSolutionTextBox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 32);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddSolutionButton
            // 
            this.AddSolutionButton.Location = new System.Drawing.Point(181, 325);
            this.AddSolutionButton.Name = "AddSolutionButton";
            this.AddSolutionButton.Size = new System.Drawing.Size(116, 32);
            this.AddSolutionButton.TabIndex = 3;
            this.AddSolutionButton.Text = "Добавить";
            this.AddSolutionButton.UseVisualStyleBackColor = true;
            this.AddSolutionButton.Click += new System.EventHandler(this.AddSolutionButton_Click);
            // 
            // AddSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.AddSolutionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddSolutionTextBox);
            this.Controls.Add(this.AddSolutionLabel);
            this.Name = "AddSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить решение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddSolutionLabel;
        private System.Windows.Forms.TextBox AddSolutionTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddSolutionButton;
    }
}