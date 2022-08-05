class PessoaJuridica : Padrao
{
    //metodo obrigatorio

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para pessoa Juridica R$ "+(valor * 0.2));
    }
}