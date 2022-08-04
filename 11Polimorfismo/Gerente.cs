class Gerente : Imposto
{
    
    //metodo
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$ "+(salario * 0.15));
    }

}