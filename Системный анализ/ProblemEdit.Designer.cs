namespace Системный_анализ
{
    partial class ProblemEdit
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProblemTextBox = new System.Windows.Forms.TextBox();
            this.ProblenLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveProblemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProblemTextBox
            // 
            this.ProblemTextBox.Location = new System.Drawing.Point(12, 39);
            this.ProblemTextBox.Multiline = true;
            this.ProblemTextBox.Name = "ProblemTextBox";
            this.ProblemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ProblemTextBox.Size = new System.Drawing.Size(567, 200);
            this.ProblemTextBox.TabIndex = 2;
            // 
            // ProblenLabel
            // 
            this.ProblenLabel.AutoSize = true;
            this.ProblenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblenLabel.Location = new System.Drawing.Point(144, 9);
            this.ProblenLabel.Name = "ProblenLabel";
            this.ProblenLabel.Size = new System.Drawing.Size(300, 18);
            this.ProblenLabel.TabIndex = 3;
            this.ProblenLabel.Text = "Редактировать формулировку проблемы";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 295);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveProblemButton
            // 
            this.SaveProblemButton.Location = new System.Drawing.Point(240, 245);
            this.SaveProblemButton.Name = "SaveProblemButton";
            this.SaveProblemButton.Size = new System.Drawing.Size(95, 26);
            this.SaveProblemButton.TabIndex = 5;
            this.SaveProblemButton.Text = "Сохранить";
            this.SaveProblemButton.UseVisualStyleBackColor = true;
            this.SaveProblemButton.Click += new System.EventHandler(this.SaveProblemButton_Click);
            // 
            // Problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 330);
            this.Controls.Add(this.SaveProblemButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ProblenLabel);
            this.Controls.Add(this.ProblemTextBox);
            this.Name = "Problem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ProblemTextBox;
        private System.Windows.Forms.Label ProblenLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveProblemButton;
    }
}