internal class Program
{
    private static void Main(string[] args)
    {
        //AulaClasses();
        AulaPropriedadeSomenteLeitura();      
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