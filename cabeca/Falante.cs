using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cabeca
{
    class Falante
    {
        public static int Blabla(string frase, int vezes)
        {
            string fraseFinal = "";

            for (int contador = 1; contador <= vezes; contador++)
            {
                fraseFinal = fraseFinal + frase + "\n";
            }

            MessageBox.Show(fraseFinal);
            return fraseFinal.Length;
        }

        public int teste()
        {
            return 3;
        }
        
    }
}
