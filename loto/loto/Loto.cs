using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    class Loto
    {
        public List<int> Uplacenibrojevi { get; set; }
        public List<int> Dobitnibrojevi { get; set; }

        /// <summary>
        /// Konstruktor klase.
        /// </summary>

        public Loto()
        {
            Uplacenibrojevi = new List<int>();
            Dobitnibrojevi = new List<int>();
        }



        public bool UnesiUplaceneBrojeve (List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            Uplacenibrojevi.Clear();

            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (Uplacenibrojevi.Contains(broj) == false)
                        {
                            Uplacenibrojevi.Add(broj);
                        }
                    }
                }
            }

            if (Uplacenibrojevi.Count == 7)
            {
                ispravni = true;
            }
            return ispravni;

        }    
 

        public void GenerirajDobitnuKombinaciju() {

            Dobitnibrojevi.Clear();
            Random generatorBrojeva = new Random();
            while (Dobitnibrojevi.Count < 7)
            {
                int broj = generatorBrojeva.Next(1, 39);
                if (Dobitnibrojevi.Contains(broj) == false)
                {
                    Dobitnibrojevi.Add(broj);
                }
            }


    }

        public int IzracunajBrojPogodaka()
        {
            int brojPogodaka = 0;
            foreach (int broj in Uplacenibrojevi)
            {
                if (Dobitnibrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }

            return brojPogodaka;
            
        }

    }

    

    
}
