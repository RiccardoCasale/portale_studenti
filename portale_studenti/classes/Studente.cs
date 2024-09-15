using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portale_studenti.classes
{
    internal class Studente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }

        public double? Voto { get; set; }
        #region "ERRORE"
        //         if (value > 0 && value <= 10)
        //                {
        //                    Voto = value;
        //                }
        //                else
        //                {
        //                    throw new ArgumentOutOfRangeException(nameof(value), "Il voto deve essere maggiore di 0 e minore o uguale a 10.");
        //}
        #endregion

        public Studente (string nome, string cognome, double? voto)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            if (voto != null)
            {
                this.Voto = voto;
            }
        }

        public override string ToString()
        {
            return $"Lo studente si chiama {Nome} {Cognome} e il suo voto è {Voto}";
        }
    }
}
