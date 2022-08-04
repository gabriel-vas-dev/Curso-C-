using System;

class Pessoa
{
    //metodo01

        public void apresentar()
        {
            Console.WriteLine("Olá");
        }

    //metodo02

        public void apresentar(string nome)
        {
            Console.WriteLine("Ola "+nome);
        }
    //metodo03

        public void apresentar(string nome , int idade)
        {
            Console.WriteLine("Ola "+nome+" voce tem "+idade+" anos");
        }

    //metodo04
}