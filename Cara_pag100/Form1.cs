using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cara_pag100
{
    public partial class Form1 : Form
    {
        Cara Joe;
        Cara Bob;
        int banco = 100;

        public Form1()
        {
            InitializeComponent();
            Joe = new Cara();
            Joe.Nome = "Joe";
            Joe.Dinheiro = 100;

            Bob = new Cara();
            Bob.Nome = "Bob";
            Bob.Dinheiro = 50;

            AtualizarFormulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (banco >= 100)
            {
                banco -= Joe.ReceberDinheiro(10);
                AtualizarFormulario();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            banco += Bob.EmprestarDinheiro(5);
           
            AtualizarFormulario();
        }

        public void AtualizarFormulario()
        {
            DinheiroJoe.Text = Joe.Nome + " tem " + Joe.Dinheiro;
            DinheiroBob.Text = Bob.Nome + " tem " + Bob.Dinheiro;
            DinheiroBanco.Text = "O banco tem " + banco;
        }

    }
}
