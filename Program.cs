using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculos infoPlayer = new Calculos();

            

            //Primeira opção sem argumentos 
            Console.WriteLine(infoPlayer.calcular());

            //Quarta opção - Com 2 argumentos string
            Console.WriteLine(infoPlayer.calcular("Sherlok", "Holmes"));

            //Quinta opção - Com 1 argumentos int
            Console.WriteLine(infoPlayer.calcularIdade(40));

            //Segunda opção - Com o argumento int 
            Console.WriteLine(infoPlayer.calcular(100));

            //Terceira opção - Com 2 argumentos int 
            Console.WriteLine(infoPlayer.calcular(100, 40));

            //Sexta opção - Com 1 argumentos string
            Console.WriteLine(infoPlayer.ApresentarPoder("o poder da dedução."));

            
           

        }
    }
}
