using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cara_pag100
{
    class Cara
    {
        public string Nome;
        public int Dinheiro;
        
        public int EmprestarDinheiro(int quantidade)
        {
            if(quantidade <= Dinheiro && quantidade > 0)
            {
                Dinheiro -= quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show("Não tenho dinheiro suficiente, " + quantidade, Nome + "disse...");
                return 0;
            }

        }
        public int ReceberDinheiro(int quantidade)
        {
            if(quantidade > 0)
            {
                Dinheiro += quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show(quantidade + " esta não e uma quantidade que dare: " + Nome + " disse...");
                return 0;
            }

        }
    }
}
