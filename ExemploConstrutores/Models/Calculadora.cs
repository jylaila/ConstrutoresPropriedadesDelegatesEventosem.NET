using static System.Console;

namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Exemplo Delegate
        public delegate void DelegateCalculadora();

        //evento
        public static event DelegateCalculadora EventoCalculadora;


        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {//caso tenha algum inscrito no evento

                WriteLine($"Adição: {x + y}");
                EventoCalculadora();//executa todos os métodos que foram inscritos no evento
            }
            else{
                WriteLine("Nenhum inscrito!");
            }
        }
        public static void Subtrair(int x, int y)
        {
            WriteLine($"Subtração: {x - y}");
        }
    }
}