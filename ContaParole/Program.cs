namespace ContaParole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            frase = frase.Trim();                    // Questo comando mi è servito per rimuovere gli spazi in più che non dividevano delle parole ( COMANDO CHIESTO ALL'IA ).
            int spazio = frase.IndexOf(' ');
            int contatore_parole = 0;
            if (frase.Substring(0, 1) != " ")
            {
                contatore_parole++;
            }
            while (spazio != -1 && spazio <= frase.Length - 1)
            {
                if (frase.Substring(spazio + 1, 1) != " ")
                {
                    contatore_parole++;
                }
                spazio = frase.IndexOf(' ', spazio + 1);
            }
            if (contatore_parole == 1)
            {
                Console.WriteLine("Nella frase scritta c'è {0} parola", contatore_parole);
            }
            else
            {
                Console.WriteLine("Nella frase scritta ci sono {0} parole", contatore_parole);
            }
        }
    }
}
