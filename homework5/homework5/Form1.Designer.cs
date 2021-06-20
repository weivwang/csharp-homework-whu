
namespace homework5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.InfoText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ansTextBox1 = new System.Windows.Forms.TextBox();
            this.ansTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "哥德巴赫猜想";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(205, 100);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(66, 23);
            this.questionTextBox.TabIndex = 1;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Location = new System.Drawing.Point(65, 103);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(125, 17);
            this.InfoText.TabIndex = 2;
            this.InfoText.Text = "输入6-100之间的偶数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // ansTextBox1
            // 
            this.ansTextBox1.Location = new System.Drawing.Point(320, 100);
            this.ansTextBox1.Name = "ansTextBox1";
            this.ansTextBox1.Size = new System.Drawing.Size(59, 23);
            this.ansTextBox1.TabIndex = 5;
            // 
            // ansTextBox2
            // 
            this.ansTextBox2.Location = new System.Drawing.Point(408, 100);
            this.ansTextBox2.Name = "ansTextBox2";
            this.ansTextBox2.Size = new System.Drawing.Size(56, 23);
            this.ansTextBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansTextBox2);
            this.Controls.Add(this.ansTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ansTextBox1;
        private System.Windows.Forms.TextBox ansTextBox2;
    }
}

