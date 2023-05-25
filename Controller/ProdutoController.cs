using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // instanciar objeto produto e produtoView
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            // Lista de produtos chamada pela model
           List<Produto> produtos = produto.Ler();
            // chamada do método de exibição VIEW recebendo como argumento a lista
           produtoView.Listar(produtos);
        }
        public void CadastrarProduto()
        {
           Produto novoProduto = produtoView.Cadastrar();

           produto.Inserir(novoProduto);
           
        }
    }
}