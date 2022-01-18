using static System.Console;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        //readonly, valor do atributo só pode ser alterado na inicialização ou pelo contrutor
        private readonly string nome;
        private readonly string sobrenome;

        // construtor sem parametros
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        // construtor com parametros

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            WriteLine("Construtor Classe Pessoa");

        }

        public void Apresentar(){
            WriteLine($"Nome: {nome} - Sobrenome: {sobrenome}");
        }
    }
}