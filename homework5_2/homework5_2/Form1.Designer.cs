
namespace homework5_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randomLabel = new System.Windows.Forms.Label();
            this.orderedNum = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.averLabel = new System.Windows.Forms.Label();
            this.generateRandomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "随机生成的随机数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "从大到小排序";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "和";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "平均数";
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.randomLabel.Location = new System.Drawing.Point(210, 65);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(0, 17);
            this.randomLabel.TabIndex = 4;
            // 
            // orderedNum
            // 
            this.orderedNum.AutoSize = true;
            this.orderedNum.Location = new System.Drawing.Point(210, 174);
            this.orderedNum.Name = "orderedNum";
            this.orderedNum.Size = new System.Drawing.Size(0, 17);
            this.orderedNum.TabIndex = 5;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(98, 278);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 17);
            this.sumLabel.TabIndex = 6;
            // 
            // averLabel
            // 
            this.averLabel.AutoSize = true;
            this.averLabel.Location = new System.Drawing.Point(84, 372);
            this.averLabel.Name = "averLabel";
            this.averLabel.Size = new System.Drawing.Size(0, 17);
            this.averLabel.TabIndex = 7;
            // 
            // generateRandomBtn
            // 
            this.generateRandomBtn.Location = new System.Drawing.Point(317, 13);
            this.generateRandomBtn.Name = "generateRandomBtn";
            this.generateRandomBtn.Size = new System.Drawing.Size(135, 23);
            this.generateRandomBtn.TabIndex = 8;
            this.generateRandomBtn.Text = "点击生成100个随机数";
            this.generateRandomBtn.UseVisualStyleBackColor = true;
            this.generateRandomBtn.Click += new System.EventHandler(this.generateRandomBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateRandomBtn);
            this.Controls.Add(this.averLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.orderedNum);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.Label orderedNum;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label averLabel;
        private System.Windows.Forms.Button generateRandomBtn;
    }
}

