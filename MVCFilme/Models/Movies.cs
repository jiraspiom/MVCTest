using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFilme.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime TataLancamento { get; set; }
        public string Genero { get; set; }
        public int Valor { get; set; }
    }
}
