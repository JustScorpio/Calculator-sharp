
namespace Calculator_sharp
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.button_1 = new Calculator_sharp.CustomButton();
            this.button_2 = new Calculator_sharp.CustomButton();
            this.button_3 = new Calculator_sharp.CustomButton();
            this.button_4 = new Calculator_sharp.CustomButton();
            this.button_5 = new Calculator_sharp.CustomButton();
            this.button_6 = new Calculator_sharp.CustomButton();
            this.button_7 = new Calculator_sharp.CustomButton();
            this.button_8 = new Calculator_sharp.CustomButton();
            this.button_9 = new Calculator_sharp.CustomButton();
            this.button_0 = new Calculator_sharp.CustomButton();
            this.buttonDot = new Calculator_sharp.CustomButton();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(177, 56);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(40, 40);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(223, 56);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(40, 40);
            this.buttonMultiply.TabIndex = 12;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(177, 102);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(40, 40);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(223, 102);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEquals.Location = new System.Drawing.Point(223, 148);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(40, 40);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackspace.Location = new System.Drawing.Point(177, 194);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(40, 40);
            this.buttonBackspace.TabIndex = 16;
            this.buttonBackspace.Text = "<x";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(223, 194);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 40);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Enabled = false;
            this.textBoxExpression.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExpression.Location = new System.Drawing.Point(12, 12);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(250, 29);
            this.textBoxExpression.TabIndex = 18;
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(12, 56);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(40, 40);
            this.button_1.TabIndex = 19;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(58, 56);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(40, 40);
            this.button_2.TabIndex = 20;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(104, 56);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(40, 40);
            this.button_3.TabIndex = 21;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(12, 102);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(40, 40);
            this.button_4.TabIndex = 22;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(58, 102);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(40, 40);
            this.button_5.TabIndex = 23;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(104, 102);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(40, 40);
            this.button_6.TabIndex = 24;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(12, 148);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(40, 40);
            this.button_7.TabIndex = 25;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(58, 148);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(40, 40);
            this.button_8.TabIndex = 26;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(104, 148);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(40, 40);
            this.button_9.TabIndex = 27;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(58, 194);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(40, 40);
            this.button_0.TabIndex = 28;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(104, 194);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(40, 40);
            this.buttonDot.TabIndex = 29;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 244);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxExpression;
        private CustomButton button_1;
        private CustomButton button_2;
        private CustomButton button_3;
        private CustomButton button_4;
        private CustomButton button_5;
        private CustomButton button_6;
        private CustomButton button_7;
        private CustomButton button_8;
        private CustomButton button_9;
        private CustomButton button_0;
        private CustomButton buttonDot;
    }
}

