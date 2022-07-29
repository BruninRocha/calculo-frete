using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            // txtValor
            // cbxUf
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            // obter os valores dos campos
            var nome = txtNome.Text;
            decimal valor = decimal.Parse(txtValor.Text);
            var estado = cbxUf.SelectedItem.ToString();
            decimal frete = 0;
            decimal valorTotal = 0;
            decimal valorCompra = 0;

            // se estado for RJ
            //    frete = 15.00;
            // se estado fro RS
            //    frete = 20.00;

            if (valor > 1000)
            {
                frete += 0;
            } 

            else if (estado == "SP")
            {
                frete = 5;
            }
            else if (estado == "RJ")
            {
                frete = 10;
            }
            else if (estado == "AM")
            {
                frete = 20;
            }
            else 
                frete = 15;
                
            

            valorTotal = valor + frete;
            // valor da compra
            lblValorCompra.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = valorTotal.ToString("C");


        } 

    }
}
