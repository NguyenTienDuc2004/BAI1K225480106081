namespace Winform_Duc_289
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyword1 = new System.Windows.Forms.TextBox();
            this.txtKeyword2 = new System.Windows.Forms.TextBox();
            this.txtKeyword3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // txtKeyword1
            // 
            this.txtKeyword1.Location = new System.Drawing.Point(116, 94);
            this.txtKeyword1.Name = "txtKeyword1";
            this.txtKeyword1.Size = new System.Drawing.Size(100, 22);
            this.txtKeyword1.TabIndex = 3;
            this.txtKeyword1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKeyword2
            // 
            this.txtKeyword2.Location = new System.Drawing.Point(116, 173);
            this.txtKeyword2.Name = "txtKeyword2";
            this.txtKeyword2.Size = new System.Drawing.Size(100, 22);
            this.txtKeyword2.TabIndex = 4;
            this.txtKeyword2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKeyword3
            // 
            this.txtKeyword3.Location = new System.Drawing.Point(116, 249);
            this.txtKeyword3.Name = "txtKeyword3";
            this.txtKeyword3.Size = new System.Drawing.Size(100, 22);
            this.txtKeyword3.TabIndex = 5;
            this.txtKeyword3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(116, 341);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(389, 97);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKeyword3);
            this.Controls.Add(this.txtKeyword2);
            this.Controls.Add(this.txtKeyword1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyword1;
        private System.Windows.Forms.TextBox txtKeyword2;
        private System.Windows.Forms.TextBox txtKeyword3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

