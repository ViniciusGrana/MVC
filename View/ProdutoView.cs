using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // Metodo para exibir os dados da lista de produtos
        public void  Listar(List<Produto> produtos)
        {
            Console.Clear();
            foreach (var item in produtos)
            {
                
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                
                
                
            }
        }
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o Código: ");
            novoProduto.Codigo = int.Parse (Console.ReadLine());

            Console.WriteLine($"Informe o Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o Preço: ");
            novoProduto.Preco = float.Parse (Console.ReadLine());

            return novoProduto;
            
            
            
            
            
            
        }
    }
}