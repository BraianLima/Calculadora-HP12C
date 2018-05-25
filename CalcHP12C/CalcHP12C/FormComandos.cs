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
    public partial class FormComandos : Form
    {
        public FormComandos()
        {
            InitializeComponent();
            richTextBoxCod.Text = "Comandos básicos : " + Environment.NewLine + Environment.NewLine +
                "Soma: Clique no número, então clique enter, adicione outro número e então no operador de soma!" + Environment.NewLine + Environment.NewLine +
                "Subtração: Clique no número, então clique enter, adicione outro número e então no operador de subtração!" + Environment.NewLine + Environment.NewLine +
                "Multiplicação: Clique no número, então clique enter, adicione outro número e então no operador de multiplicação!" + Environment.NewLine + Environment.NewLine +
                "Divisão: Clique no número, então clique enter, adicione outro número e então no operador de divisão!" + Environment.NewLine + Environment.NewLine +
                "CHS: Clique em um número, então pode clicar em CHS, ele irá inverter o sinal do número!" + Environment.NewLine + Environment.NewLine +
                "CLX: Limpa tudo!" + Environment.NewLine + Environment.NewLine +
                "Σ+: Clique em um número, então clique enter, adicione outro número e já pode clicar em Σ+!" + Environment.NewLine + Environment.NewLine +
                "ENTER: Clique nesse botão para adicionar valores na pilha!" + Environment.NewLine + Environment.NewLine +
                "1/X: Adicione o número a sua escolhe e já pode clicar nesse botão para mostrá-lo em decimal!" + Environment.NewLine + Environment.NewLine +
                "Y^X: Clique no número, então clique enter, adicione outro número e então no operador de potência!" + Environment.NewLine + Environment.NewLine +
                "%: Adicione o valor que quer saber a porcentagem, clique enter, adicione o valor do percent que quer encontrar a porcentagem então clique %!" + Environment.NewLine + Environment.NewLine +
                "√: Adcione um valor, e já pode clicar no botao √ para achar a raiz quadrada!" + Environment.NewLine + Environment.NewLine +
                "MEDIA: Adione um valor, clique enter, adicione outro valor clique na MEDIA (não calcula se o ultimo botao pressionado for enter)!" + Environment.NewLine + Environment.NewLine +
                "P/ SIN, COS e TAN: Adicione um valor, clique enter e já pode clicar no botão para calcular!" + Environment.NewLine + Environment.NewLine + 
                "Faça bom uso da calculadora.";
        }


    }
}
