using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portale_studenti.classes
{
    internal class ListaStudenti
    {
        List<Studente> Studenti {  get; set; } = new List<Studente>();

        public void AggiungiStudente(Studente studente)
        {
            try
            {
                Studenti.Add(studente);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ModificaStudente(string varNome , string varCognome, string? nuovoNome, string? nuovoCognome, double? nuovoVoto)
        {
            foreach(Studente studente in Studenti)
            {
                if(studente.Nome.Equals(varNome) && studente.Cognome.Equals(varCognome))
                {
                    if (nuovoNome != null)
                    {
                        studente.Nome = nuovoNome;
                    }
                    if (nuovoCognome != null)
                    {
                        studente.Cognome = nuovoCognome;
                    }
                    if (nuovoVoto != null)
                    {
                        studente.Voto = nuovoVoto;
                    }
                }
                else
                {
                    throw new Exception("Utente non trovato.");
                }
            }
        }

        public void FiltraSuBaseVoto(double min, double max)
        {
            foreach (Studente studente in Studenti)
            {
                if(studente.Voto >= min &&  studente.Voto <= max)
                {
                    Console.WriteLine(studente);
                }
            }
        }

        public void EliminaStudente(string nomeStudente)
        {
            for(int i = 0; i < Studenti.Count; i++)
            {
                if (Studenti[i].Nome.Equals(nomeStudente))
                {
                    Studenti.Remove(Studenti[i]);
                }
                else
                {
                    throw new Exception("Utente non trovato.");
                }
            }
        }

        public void MediaVoti()
        {
            double numStudenti = Studenti.Count();
            double? sumVoti = 0;

            if (Studenti.Count == 0)
            {
                throw new Exception("Non ci sono studenti");
            }

            foreach(Studente studente in Studenti)
            {
                sumVoti += studente.Voto;
            }

            Console.WriteLine($"La media dei voti è {sumVoti / numStudenti}."); 
        }

        public void VotoMinimo()
        {
            if (Studenti.Count == 0)
            {
                throw new Exception("La lista è vuota.");
            }

            double? min = Studenti[0].Voto;

            foreach (Studente studente in Studenti)
            {
                if(studente.Voto < min)
                {
                    min = studente.Voto;
                }
            }
            Console.WriteLine($"Il voto più basso è {min}");
        }

        public void VotoMassimo()
        {
            if (Studenti.Count == 0)
            {
                throw new Exception("La lista è vuota.");
            }

            double? max = Studenti[0].Voto;

            foreach (Studente studente in Studenti)
            {
                if (studente.Voto > max)
                {
                    max = studente.Voto;
                }
            }
            Console.WriteLine($"Il voto più alto è {max}");
        }

        public void VisualizzaStudenti()
        {
            if(Studenti.Count == 0)
            {
                throw new Exception("Non ci sono studenti.");
            }

            foreach(var studente in Studenti)
            {
                Console.WriteLine(studente);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
