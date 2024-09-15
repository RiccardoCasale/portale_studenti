using portale_studenti.classes;

namespace portale_studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaStudenti studenti = new ListaStudenti();
            bool exit = false;

            while (exit == false) { 
            Console.WriteLine("Benvenuto all'università I&M. " +
                "\n Come possiamo aiutarti? Digita il numero dell'operazione desiderata:" +
                "\n 1.Aggiungi studente" +
                "\n 2.Modifica studente" +
                "\n 3.Stampa studenti" +
                "\n 4.Elimina studente" +
                "\n 5.Raggruppa studenti sulla base di un minimo e un massimo" +
                "\n 6.Calcola media dei voti degli studenti" +
                "\n 7.Calcola voto massimo o voto minimo" +
                "\n 8.Esci");

                string choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        try
                        {
                            Console.WriteLine("Inserisci il nome del nuovo studente.");
                            string varNome = Console.ReadLine();
                            if (varNome.Any(char.IsDigit))
                            {
                                throw new Exception("Solo caratteri sono ammessi");
                            }

                            Console.WriteLine("Inserisci il cognome del nuovo studente.");
                            string varCognome = Console.ReadLine();
                            if (varCognome.Any(char.IsDigit))
                            {
                                throw new Exception("Solo caratteri sono ammessi");
                            }

                            Console.WriteLine("Inserisci il voto del nuovo studente.");
                            double varVoto = Convert.ToDouble(Console.ReadLine());

                            if(varVoto < 0 || varVoto > 10)
                            {
                                throw new Exception("Il voto deve essere compreso tra 0 e 10");
                            }

                            Studente studente = new Studente(varNome, varCognome, varVoto);
                            studenti.AggiungiStudente(studente);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "2":
                        try
                        {
                            Console.WriteLine("Inserisci il nome dello studente da modificare.");
                            string varNome = Console.ReadLine();
                            Console.WriteLine("Inserisci il cognome dello studente da modificare.");
                            string varCognome = Console.ReadLine();

                            Console.WriteLine("Digita il nuovo nome.");
                            string newNome = Console.ReadLine();
                            if (newNome.Any(char.IsDigit))
                            {
                                throw new Exception("Solo caratteri sono ammessi");
                            }

                            Console.WriteLine("Digita il nuovo cognome.");
                            string newCognome = Console.ReadLine();
                            if (newCognome.Any(char.IsDigit))
                            {
                                throw new Exception("Solo caratteri sono ammessi");
                            }

                            Console.WriteLine("Digita il nuovo voto.");
                            double? newVoto = Convert.ToDouble(Console.ReadLine());

                            if (newVoto < 0 || newVoto > 10)
                            {
                                throw new Exception("Il voto deve essere compreso tra 0 e 10");
                            }

                            studenti.ModificaStudente(varNome, varCognome, newNome, newCognome, newVoto);

                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "3":
                        try
                        {
                            studenti.VisualizzaStudenti();
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "4":
                        try
                        {
                            Console.WriteLine("Digita il nome dello studente che vuoi eliminare.");
                            string varNome = Console.ReadLine();

                            studenti.EliminaStudente(varNome);

                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        
                        break;

                    case "5":
                        try
                        {
                            Console.WriteLine("Inserisci un voto minimo");
                            double min = Convert.ToDouble(Console.ReadLine());

                            if (min < 0 || min > 10)
                            {
                                throw new Exception("Il voto deve essere compreso tra 0 e 10");
                            }

                            Console.WriteLine("Inserisci un voto massimo");
                            double max = Convert.ToDouble(Console.ReadLine());

                            if (max < 0 || max > 10)
                            {
                                throw new Exception("Il voto deve essere compreso tra 0 e 10");
                            }

                            studenti.FiltraSuBaseVoto(min, max);
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                        case "6":
                        try
                        {
                            studenti.MediaVoti();
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "7":
                        try
                        {
                            Console.WriteLine("Vuoi calcolare il voto minimo o il voto massimo? /min/max");
                            string sceltaMinMax = Console.ReadLine();

                            switch (sceltaMinMax)
                            {
                                case "min":

                                    studenti.VotoMinimo();

                                    break;

                                case "max":

                                    studenti.VotoMassimo();

                                    break;

                                default:
                                    Console.WriteLine("Inserisci min o max");

                                    break;
                            }

                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                        case "8":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("ERRORE di digitazione.");
                        break;

                }

            }





        }
    }
}

