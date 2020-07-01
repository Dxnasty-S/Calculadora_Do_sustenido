using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Do_sustenido
{
    public partial class Form1 : Form
    {
        float _num1 = 0;
        float _num2 = 0;
        float _resultado = 0;
        string _Operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (_Operacao)
            {
                case "+":
                    _num1 = float.Parse(textBox_va.Text);
                    _num2 = float.Parse(text_result.Text);
                    _resultado = _num1 + _num2;
                    text_result.Text = _resultado.ToString();
                    textBox_va.Text = "";
                    break;

                case "-":
                    _num1 = float.Parse(textBox_va.Text);
                    _num2 = float.Parse(text_result.Text);
                    _resultado = _num1 - _num2;
                    text_result.Text = _resultado.ToString();
                    textBox_va.Text = "";
                    break;

                case "*":
                    _num1 = float.Parse(textBox_va.Text);
                    _num2 = float.Parse(text_result.Text);
                    _resultado = _num1 * _num2;
                    text_result.Text = _resultado.ToString();
                    textBox_va.Text = "";
                    break;

                case "/":
                    _num1 = float.Parse(textBox_va.Text);
                    _num2 = float.Parse(text_result.Text);
                    _resultado = _num1 / _num2;
                    text_result.Text = _resultado.ToString();
                    textBox_va.Text = "";
                    break;

                default:
                    text_result.Text = "ERROR";
                    break;
                    
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            textBox_va.Text = text_result.Text;
            text_result.Text = "";
            _Operacao = "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            float number = float.Parse(button.Text);

            text_result.Text += number.ToString();
        }

        private void button_dot_click(object sender, EventArgs e)
        {
            text_result.Text += ",";
        }

        private void Operacao_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string Operacao = (button.Text);
            _Operacao = Operacao;

            textBox_va.Text = text_result.Text;
            text_result.Text = "";



        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_result.Text = "";
            textBox_va.Text = "";
            _Operacao = "";
            _resultado = 0;
            _num1 = 0;
            _num2 = 0;
            
            

        }
    }
}
