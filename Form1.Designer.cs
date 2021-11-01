
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiplic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_res = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cos_btn = new System.Windows.Forms.Button();
            this.sin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(12, 76);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(100, 23);
            this.btn_sum.TabIndex = 2;
            this.btn_sum.Text = "Sum";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(12, 19);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(57, 13);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "Operand 1";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(250, 19);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(57, 13);
            this.label_Y.TabIndex = 4;
            this.label_Y.Text = "Operand 2";
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(131, 76);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(100, 23);
            this.btn_substract.TabIndex = 5;
            this.btn_substract.Text = "Subtraction";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(131, 117);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(100, 23);
            this.btn_divide.TabIndex = 7;
            this.btn_divide.Text = "Divide";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiplic
            // 
            this.btn_multiplic.Location = new System.Drawing.Point(15, 117);
            this.btn_multiplic.Name = "btn_multiplic";
            this.btn_multiplic.Size = new System.Drawing.Size(100, 23);
            this.btn_multiplic.TabIndex = 6;
            this.btn_multiplic.Text = "Multiplication";
            this.btn_multiplic.UseVisualStyleBackColor = true;
            this.btn_multiplic.Click += new System.EventHandler(this.btn_multiplic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(85, 160);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(40, 13);
            this.label_res.TabIndex = 9;
            this.label_res.Text = "Result:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // cos_btn
            // 
            this.cos_btn.Location = new System.Drawing.Point(253, 117);
            this.cos_btn.Name = "cos_btn";
            this.cos_btn.Size = new System.Drawing.Size(100, 23);
            this.cos_btn.TabIndex = 12;
            this.cos_btn.Text = "Cos";
            this.cos_btn.UseVisualStyleBackColor = true;
            this.cos_btn.Click += new System.EventHandler(this.cos_btn_Click);
            // 
            // sin_btn
            // 
            this.sin_btn.Location = new System.Drawing.Point(253, 76);
            this.sin_btn.Name = "sin_btn";
            this.sin_btn.Size = new System.Drawing.Size(100, 23);
            this.sin_btn.TabIndex = 11;
            this.sin_btn.Text = "Sin";
            this.sin_btn.UseVisualStyleBackColor = true;
            this.sin_btn.Click += new System.EventHandler(this.syn_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 189);
            this.Controls.Add(this.cos_btn);
            this.Controls.Add(this.sin_btn);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiplic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cos_btn;
        private System.Windows.Forms.Button sin_btn;
    }
}

