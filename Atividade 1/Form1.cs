using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;

            bool resultadocpf = Validacoes.ValidaCPF(cpf);

            string idade = tx_idade.Text;
            string sexo = combox_sexo.Text;
            double peso = Convert.ToDouble(num_peso.Text);
            double altura = Convert.ToDouble(mask_altura.Text);

            Pessoa pessoa = new Pessoa(nome, cpf, idade, sexo, peso, altura);
            (double imc, string classificacao, string grau) = pessoa.CalcularIMC();

                if(resultadocpf == true)
                {
                    tx_resultado.Text = $"Resultado IMC = {imc} \nClassificação = {classificacao} {grau}";
                }

                else
                {
                    tx_resultado.Text = "CPF Inválido, Digite Novamente.";
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
