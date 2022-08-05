class PessoaFisica : Padrao
{
    //metodo obrigatorio

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para pessoa fisica R$ "+(valor * 0.1));
    }
}