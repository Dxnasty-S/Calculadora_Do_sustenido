namespace Calculadora_Do_sustenido
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_mais = new System.Windows.Forms.Button();
            this.button_menos = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_slash = new System.Windows.Forms.Button();
            this.textBox_va = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_mais
            // 
            this.button_mais.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.button_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_mais.Location = new System.Drawing.Point(174, 111);
            this.button_mais.Name = "button_mais";
            this.button_mais.Size = new System.Drawing.Size(48, 47);
            this.button_mais.TabIndex = 0;
            this.button_mais.Text = "+";
            this.button_mais.UseVisualStyleBackColor = true;
            this.button_mais.Click += new System.EventHandler(this.Operacao_click);
            // 
            // button_menos
            // 
            this.button_menos.Location = new System.Drawing.Point(174, 60);
            this.button_menos.Name = "button_menos";
            this.button_menos.Size = new System.Drawing.Size(48, 46);
            this.button_menos.TabIndex = 1;
            this.button_menos.Text = "-";
            this.button_menos.UseVisualStyleBackColor = true;
            this.button_menos.Click += new System.EventHandler(this.Operacao_click);
            // 
            // button_equal
            // 
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_equal.Location = new System.Drawing.Point(12, 268);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(210, 46);
            this.button_equal.TabIndex = 2;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // text_result
            // 
            this.text_result.Location = new System.Drawing.Point(12, 34);
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(210, 20);
            this.text_result.TabIndex = 3;
            this.text_result.TextChanged += new System.EventHandler(this.text_result_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 47);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(66, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 47);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(120, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 47);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 47);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(66, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 46);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(120, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button_multi
            // 
            this.button_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_multi.Location = new System.Drawing.Point(174, 164);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(48, 46);
            this.button_multi.TabIndex = 13;
            this.button_multi.Text = "*";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.Operacao_click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(12, 216);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(48, 46);
            this.button_dot.TabIndex = 14;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(66, 216);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(48, 46);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(120, 216);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(48, 46);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "CE";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_slash
            // 
            this.button_slash.Location = new System.Drawing.Point(174, 216);
            this.button_slash.Name = "button_slash";
            this.button_slash.Size = new System.Drawing.Size(48, 46);
            this.button_slash.TabIndex = 17;
            this.button_slash.Text = "/";
            this.button_slash.UseVisualStyleBackColor = true;
            this.button_slash.Click += new System.EventHandler(this.Operacao_click);
            // 
            // textBox_va
            // 
            this.textBox_va.Location = new System.Drawing.Point(12, 8);
            this.textBox_va.Name = "textBox_va";
            this.textBox_va.Size = new System.Drawing.Size(102, 20);
            this.textBox_va.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 326);
            this.Controls.Add(this.textBox_va);
            this.Controls.Add(this.button_slash);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_menos);
            this.Controls.Add(this.button_mais);
            this.Name = "Form1";
            this.Text = "calculator Dó #";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_mais;
        private System.Windows.Forms.Button button_menos;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.TextBox text_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_slash;
        private System.Windows.Forms.TextBox textBox_va;
    }
}

