
namespace Lab_2_5
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiplic = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(50, 164);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(40, 13);
            this.label_res.TabIndex = 20;
            this.label_res.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(131, 123);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(100, 23);
            this.btn_divide.TabIndex = 18;
            this.btn_divide.Text = "Divide";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiplic
            // 
            this.btn_multiplic.Location = new System.Drawing.Point(15, 123);
            this.btn_multiplic.Name = "btn_multiplic";
            this.btn_multiplic.Size = new System.Drawing.Size(100, 23);
            this.btn_multiplic.TabIndex = 17;
            this.btn_multiplic.Text = "Multiplication";
            this.btn_multiplic.UseVisualStyleBackColor = true;
            this.btn_multiplic.Click += new System.EventHandler(this.btn_multiplic_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(131, 82);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(100, 23);
            this.btn_substract.TabIndex = 16;
            this.btn_substract.Text = "Subtraction";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(128, 25);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(57, 13);
            this.label_Y.TabIndex = 15;
            this.label_Y.Text = "Operand 2";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(12, 25);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(57, 13);
            this.label_X.TabIndex = 14;
            this.label_X.Text = "Operand 1";
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(12, 82);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(100, 23);
            this.btn_sum.TabIndex = 13;
            this.btn_sum.Text = "Sum";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiplic);
            this.Controls.Add(this.btn_substract);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiplic;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

