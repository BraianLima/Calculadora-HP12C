using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcHP12C
{
    public partial class CalcHP : Form
    {
        public CalcHP()
        {
            InitializeComponent();
        }

        private Stack<double> Pilha = new Stack<double>();

        private short ValidaVirgula = 0; //verifica se o ultimo botao clicado foi o ponto
        private bool Validador = true; //controle para inclusao do 1º num
        private bool Controle = true; //controle para o 2º (ou dps do 2º) num incluso

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "0";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "0";
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {

            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "1";
                Validador = false;
                Controle = true;
            }
            else
            {

                richtxtboxTela.Text += "1";
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "2";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "3";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "3";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "4";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "5";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "5";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "6";
                Validador = false;
                Controle = true;
            }
            else
            {
             
                richtxtboxTela.Text += "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "7";
                Validador = false;
                Controle = true;
            }
            else
            {
            
                richtxtboxTela.Text += "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "8";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (Validador == true || Controle == false)
            {
                richtxtboxTela.Text = "9";
                Validador = false;
                Controle = true;
            }
            else
            {
                richtxtboxTela.Text += "9";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if(Validador == true || Controle == false)
            {

                if(ValidaVirgula == 0)
                {
                    richtxtboxTela.Text = "0,";
                    Validador = false;
                    Controle = true;
                    ++ValidaVirgula;
                }
            }
            else
            {
                if(ValidaVirgula == 0)
                {
                    ++ValidaVirgula;
                    richtxtboxTela.Text += ",";
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ValidaVirgula = 0;
            if(Validador == false)
            {
                double Valor = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(Valor);
                foreach(var elemento in Pilha)
                {
                    Console.WriteLine(elemento);
                }
                Console.WriteLine("Fim Pilha");
                Controle = false; //controle do Enter
            }
            else
            {
                MessageBox.Show("Adicione um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (Pilha.Count > 0)
            {
                Console.WriteLine("Pilha vazia");
                Pilha.Clear();
            }
            ValidaVirgula = 0;
            richtxtboxTela.Text = "0,00";
            Controle = true;
            Validador = true;
        }

        private void btnChs_Click(object sender, EventArgs e)
        {
            double Valor = Convert.ToDouble(richtxtboxTela.Text);
            if (Valor != 0)
            {
                Valor = Valor * (-1);
                richtxtboxTela.Text = Valor.ToString();
            }
        }

        //abaixo têm os eventos de operações com os números...
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(Validador == false)
            {
                //adicionando na pilha, e mostrando a pilha
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                //abaixo, realizando a operação de soma
                double Soma = 0;
                if(Pilha.Count == 1)
                {
                    Soma = Pilha.Pop();
                    Soma = Soma + 0;
                }
                if(Pilha.Count > 1)
                {
                    Soma = Pilha.Pop();
                    Soma = Pilha.Pop() + Soma;
                }
                richtxtboxTela.Text = Soma.ToString();
            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                //adicionando na pilha, e mostrando a pilha
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                //abaixo, realizando a operação de subtração
                double Sub = 0;
                if (Pilha.Count == 1)
                {
                    Sub = Pilha.Pop();
                    Sub = Sub * (-1);
                }
                if (Pilha.Count > 1)
                {
                    Sub = Pilha.Pop();
                    Sub = Pilha.Pop() - Sub;
                }
                richtxtboxTela.Text = Sub.ToString();
            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                //adicionando na pilha, e mostrando a pilha
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                //abaixo, realizando a operação de multiplicaçãp
                double Mult = 0;
                if (Pilha.Count == 1)
                {
                    Mult = Pilha.Pop();
                    Mult = Mult * 0;
                }
                if (Pilha.Count > 1)
                {
                    Mult = Pilha.Pop();
                    Mult = Pilha.Pop() * Mult;
                }
                richtxtboxTela.Text = Mult.ToString();
            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                //adicionando na pilha, e mostrando a pilha
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                //abaixo, realizando a operação de divisao
                double Divis = 0;
                int flag = 0;
                if (Pilha.Count == 1)
                {
                    Divis = Pilha.Pop();
                    if(Divis == 0)
                    {
                        flag = 1;
                        MessageBox.Show("Não é possível dividir", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Divis = 0;
                    
                }
                if (Pilha.Count > 1)
                {
                    Divis = Pilha.Pop();
                    Divis = Pilha.Pop() / Divis;
                }
                if(flag == 0)
                {
                    richtxtboxTela.Text = Divis.ToString();
                }

            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                //adicionando na pilha, e mostrando a pilha
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                //abaixo, realizando a operação de potenciação
                double Pot = 0;
                if (Pilha.Count == 1)
                {
                    Pot = Pilha.Pop();
                    Pot = Math.Pow(0, Pot);
                }
                if (Pilha.Count > 1)
                {
                    Pot = Pilha.Pop();
                    Pot = Math.Pow(Pilha.Pop(), Pot);
                }

                richtxtboxTela.Text = Pot.ToString();
            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInvers_Click(object sender, EventArgs e)
        {
            if(Validador == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                double Invers = 0;
                if(Pilha.Count > 0)
                {
                    Invers = Pilha.Pop();
                    Invers = 1 / Invers;
                }
                richtxtboxTela.Text = Invers.ToString();

            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);

                //Foreach para mostrar no console para controle...
                string MostraConsole = string.Empty;
                Console.WriteLine("Pilha de valores");
                foreach (var elemento in Pilha)
                {
                    Console.WriteLine(elemento.ToString());
                }
                Console.WriteLine("Fim Pilha");

                double Percent = 0;
                if (Pilha.Count > 1)
                {
                    Percent = Pilha.Pop();
                    Percent = Percent * Pilha.Pop();
                    Percent = Percent / 100;
                }
                richtxtboxTela.Text = Percent.ToString();

            }
            else
            {
                MessageBox.Show("É necessário adicionar um valor", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnSomato_Click(object sender, EventArgs e)
        {
            if (Validador == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double Somat = 1;
                if(Pilha.Count > 0)
                {
                    Somat = Somat + Pilha.Pop();
                }
                richtxtboxTela.Text = Somat.ToString();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if(Validador == false && Controle == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double Raiz = 0;
                if (Pilha.Count > 0)
                {
                    Raiz = Math.Sqrt(Pilha.Pop());
                }
                richtxtboxTela.Text = Raiz.ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (Validador == false && Controle == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double AngSin = 0;
                if (Pilha.Count > 0)
                {
                    AngSin = Pilha.Pop();
                    AngSin = AngSin * Math.PI / 180;
                    AngSin = Math.Sin(AngSin);
                }
                richtxtboxTela.Text = AngSin.ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (Validador == false && Controle == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double AngCos = 0;
                if (Pilha.Count > 0)
                {
                    AngCos = Pilha.Pop();
                    AngCos = AngCos * Math.PI / 180;
                    AngCos = Math.Cos(AngCos);
                }
                richtxtboxTela.Text = AngCos.ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (Validador == false && Controle == false)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double AngTan = 0;
                if (Pilha.Count > 0)
                {
                    AngTan = Pilha.Pop();
                    AngTan = AngTan * Math.PI / 180;
                    AngTan = Math.Tan(AngTan);
                }
                richtxtboxTela.Text = AngTan.ToString();
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (Validador == false && Controle == true)
            {
                double ValorDigit = Convert.ToDouble(richtxtboxTela.Text);
                Pilha.Push(ValorDigit);
                double Media = 0;
                double Calc = Pilha.Count;
                while(Pilha.Count != 0)
                {
                    Media = Media + Pilha.Pop();
                }
                Media = Media / Calc;
                richtxtboxTela.Text = Media.ToString();
            }
        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            FormComandos Ajuda = new FormComandos();
            Ajuda.Show();
        }
    }
}
