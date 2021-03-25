namespace Системный_анализ
{
    partial class ExpertInterface
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
            this.BackButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.LabelBoth = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ProblemFormulation = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(880, 534);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(238, 49);
            this.BackButton.TabIndex = 41;
            this.BackButton.Text = "Вернуться в меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1106, 472);
            this.listBox1.TabIndex = 44;
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLabel.Location = new System.Drawing.Point(109, 559);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(0, 24);
            this.ListLabel.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Страница";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirst.Location = new System.Drawing.Point(65, 214);
            this.textBoxFirst.Multiline = true;
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.ReadOnly = true;
            this.textBoxFirst.Size = new System.Drawing.Size(434, 161);
            this.textBoxFirst.TabIndex = 66;
            // 
            // LabelBoth
            // 
            this.LabelBoth.AutoSize = true;
            this.LabelBoth.BackColor = System.Drawing.Color.LightCoral;
            this.LabelBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBoth.Location = new System.Drawing.Point(450, 396);
            this.LabelBoth.Name = "LabelBoth";
            this.LabelBoth.Size = new System.Drawing.Size(249, 25);
            this.LabelBoth.TabIndex = 82;
            this.LabelBoth.Text = "Варианты равнозначны";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecond.Location = new System.Drawing.Point(640, 214);
            this.textBoxSecond.Multiline = true;
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.ReadOnly = true;
            this.textBoxSecond.Size = new System.Drawing.Size(434, 161);
            this.textBoxSecond.TabIndex = 83;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.Location = new System.Drawing.Point(471, 544);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(103, 30);
            this.PreviousButton.TabIndex = 84;
            this.PreviousButton.Text = "<--";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(580, 544);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(103, 30);
            this.NextButton.TabIndex = 85;
            this.NextButton.Text = "-->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.Location = new System.Drawing.Point(880, 535);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(238, 49);
            this.EndButton.TabIndex = 86;
            this.EndButton.Text = "Завершить оценивание";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ProblemFormulation
            // 
            this.ProblemFormulation.BackColor = System.Drawing.SystemColors.Menu;
            this.ProblemFormulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemFormulation.Location = new System.Drawing.Point(65, 28);
            this.ProblemFormulation.Multiline = true;
            this.ProblemFormulation.Name = "ProblemFormulation";
            this.ProblemFormulation.ReadOnly = true;
            this.ProblemFormulation.Size = new System.Drawing.Size(1009, 166);
            this.ProblemFormulation.TabIndex = 87;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ExpertInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 608);
            this.Controls.Add(this.ProblemFormulation);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.LabelBoth);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "ExpertInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpertInterface";
            this.Load += new System.EventHandler(this.ExpertInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label LabelBoth;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox ProblemFormulation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}