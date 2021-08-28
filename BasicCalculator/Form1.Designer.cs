
namespace BasicCalculator
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
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(183, 225);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(70, 50);
            this.btn_six.TabIndex = 1;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(31, 169);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(70, 50);
            this.btn_seven.TabIndex = 2;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(183, 169);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(70, 50);
            this.btn_nine.TabIndex = 3;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(259, 281);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(102, 50);
            this.btn_sum.TabIndex = 4;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(259, 337);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(102, 50);
            this.btn_result.TabIndex = 5;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(107, 169);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(70, 50);
            this.btn_eight.TabIndex = 6;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(259, 225);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(102, 50);
            this.btn_subtraction.TabIndex = 7;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(107, 225);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(70, 50);
            this.btn_five.TabIndex = 8;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(31, 225);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(70, 50);
            this.btn_four.TabIndex = 9;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(183, 281);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(70, 50);
            this.btn_three.TabIndex = 10;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(107, 281);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(70, 50);
            this.btn_two.TabIndex = 11;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(31, 281);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(70, 50);
            this.btn_one.TabIndex = 12;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_comma
            // 
            this.btn_comma.Location = new System.Drawing.Point(183, 337);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(70, 50);
            this.btn_comma.TabIndex = 13;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = true;
            this.btn_comma.Click += new System.EventHandler(this.btn_click_comma);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(107, 337);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(70, 50);
            this.btn_zero.TabIndex = 14;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Location = new System.Drawing.Point(259, 169);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(102, 50);
            this.btn_multiplication.TabIndex = 15;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(259, 113);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(102, 50);
            this.btn_division.TabIndex = 16;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(145, 113);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(108, 50);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "<--";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 113);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 50);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_result.Location = new System.Drawing.Point(32, 39);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(329, 43);
            this.txt_result.TabIndex = 19;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_result;
    }
}

