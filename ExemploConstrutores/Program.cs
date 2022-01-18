using ExemploConstrutores.Models;
using static System.Console;

namespace ExemploConstrutores
{
    public class ExemploConstrutores
    {

        //usando o delegate, precisa ter a mesma quantidade de parâmetros que o método
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //instanciando classe com construtor
            Pessoa p1 = new Pessoa("Janaina", "Ferreira");
            p1.Apresentar();

            var p2 = new Pessoa();
            p2.Apresentar();

            //instanciando classe com construtor privado
            Log log = Log.GetInstance();
            log.PropriedadeLog = "Testando";

            Log log2 = Log.GetInstance();
            WriteLine(log2.PropriedadeLog);

            //instanciando classe com herança
            Aluno a1 = new Aluno("Janaiina", "Ferreira", 123);

            //getters and setters
            Data d1 = new Data();
            d1.setMes(1);
            d1.ApresentaMes(); //apresenta o mês
            Data d2 = new Data();
            d2.setMes(20);
            d2.ApresentaMes(); //data inválida

            //declarando constante
            const double pi = 3.14;
            WriteLine($"{pi}");

             //usando delegate
            Operacao op = new Operacao(Calculadora.Somar); //ou
            // Operacao op = Calculadora.Somar;
            //chamando o delegate
            op.Invoke(10,10); //ou
            // op(10,10);

            //Chamando mais de um método com o delegate
            op+=Calculadora.Subtrair;

            //Usando eventos
            Matematica m = new Matematica(10,20);
            m.Somar();

        }
    }
}