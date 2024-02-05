using Cadastro;

internal class Program
{
    private static void Main(string[] args)
    {
        //AulaClasses();
        //AulaPropriedadeSomenteLeitura(); 
        AulaHeranca();     

    }

    private static void AulaHeranca()
    {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Mamede Freire 60";
        pessoaFisica.Cidade = "São Paulo";
        pessoaFisica.Cep = "12345612";
        pessoaFisica.CPF = "12345678912";

        pessoaFisica.ImprimirDados();
        pessoaFisica.ImprimirCPF();
    }

    private static void AulaClasses()
    {
          var resultado = Cadastro.Calculos.SomarNumeros(2,3);
        Console.WriteLine(resultado);

        /*var produto = new Cadastro.Produto();
        produto.SetId(1);
        produto.GetId();

        produto.Descricao = "Teclado";


        produto.ImprimirDescricao();
        Console.WriteLine(produto.GetId());
        */
    }

    private static void AulaPropriedadeSomenteLeitura()
    {
    
        var produto = new Cadastro.Produto();  
        produto.Descricao = "Mause";
        //produto.Estoque = 1;  
        Console.WriteLine(produto.Estoque);  
        
    }

}