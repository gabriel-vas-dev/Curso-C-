class Pessoa
{

    //atributos

    public double peso, altura;

    //calculo


    public double calculo()
    {
        return peso / (altura * altura);
    }

    //situação

    public string situacao(double imc)
    {
        //variel
        string retorno;

        //condicional
        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "peso normal";
        }
        else if (imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        //retorno
        return retorno;
    }

    //mensagem
    public void mensagem()
    {

        //Obter calculo
        double obterCalculo = calculo();

        //obter situação

        string obterSituacao = situacao(obterCalculo);

        //Exibir mensagem
        Console.WriteLine("Seu IMC é de " + Math.Round(obterCalculo, 2));
        Console.WriteLine("Sua situação é " + obterSituacao);
    }
}