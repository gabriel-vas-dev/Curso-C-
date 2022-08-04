using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    public Aluno(string nome, double nota1, double nota2)
    {
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

    //Media

    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    //Situação

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    //Mensagem
    public void mensagem()
    {
        //Obter media
        double obterMedia = media();
        
        //Obter situacao
        string obterSituacao = situacao(obterMedia);
    
        //mensagem
        Console.WriteLine(nome + " está " + obterSituacao + " Com media " + obterMedia);
    }

}