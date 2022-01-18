using static System.Console;
namespace ExemploConstrutores.Models
{
    public class Aluno:Pessoa
    {
        //Herança com sobrescrita de método construtor
        //base recebe os parâmetros da classe mãe
        public Aluno(string nome, string sobrenome, int matricula):base(nome,sobrenome)
        {
            WriteLine("Construtor Classe Aluno");
            
        }
        
    }
}