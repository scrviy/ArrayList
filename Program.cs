using System;

namespace ArraysList
{
    public class ArrayList
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            List<string> listaString = new List<string>();

            listaString.Add("São Paulo");
            listaString.Add("Goiás");
            listaString.Add("Rio de Janeiro");
            listaString.Add("Mato Grosso");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

            listaString.Add("Tocantins");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

            listaString.Remove("Goiás");

            Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

            
            // percorrendo uma lista com FOR
            for(int contador = 0; contador < listaString.Count; contador++)
            {
                Console.WriteLine($"Posição N˚ {contador} - {listaString[contador]}");
            }

            Console.WriteLine("--------------------------------");

            //Percorrendo uma lista com FOREACH
            int contadorForeach = 0;
            foreach(string item in listaString)
            {
                Console.WriteLine($"Posição N˚ {contadorForeach} - {item}");
                contadorForeach++;
            } 

            
            //Arrays e Listas
            int[] arrayInteiros = new int[4];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;
            arrayInteiros[3] = 1;

            int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

            //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

            Console.WriteLine("Percorrendo array com loop FOR.");
            for (int contadorFor = 0; contadorFor < arrayInteiros.Length; contadorFor++)
            {
                Console.WriteLine($"Posição N˚ {contadorFor} - {arrayInteiros[contadorFor]}");
            }

            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Percorrendo array com loop FOREACH");
            int contador_Foreach = 0;
            foreach (int valorForeach in arrayInteiros)
            {
                Console.WriteLine($"Posição N˚ {contador_Foreach} - {valorForeach}");
                contador_Foreach++;
            } 
        }
    }
}