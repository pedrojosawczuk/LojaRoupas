using LojaRoupas.Model;
using LojaRoupas.UI.Categoria;

namespace LojaRoupas.UI.Produto;

public class ProdutoUI
{
    private List<ProdutoModel> _produtos;
    private List<CategoriaModel> _categorias;

    public ProdutoUI(List<ProdutoModel> produtos, List<CategoriaModel> categorias)
    {
        _produtos = produtos;
        _categorias = categorias;
    }

    public void MenuProduto()
    {
        bool continuar = true;
        do
        {
            Console.WriteLine(" 👗 PRODUTO 👗 ");
            //Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine(" 1 - Cadastrar Produto");
            Console.WriteLine(" 2 - Alterar Produto");
            Console.WriteLine(" 3 - Listar Todos os Produtos");
            Console.WriteLine(" 4 - Buscar Produto por Id");
            Console.WriteLine(" 5 - Remover Produto");
            Console.WriteLine(" 6 - Voltar");
            Console.Write(" 👉 ");

            try
            {
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        CadastrarProduto();
                        break;
                    case 2:
                        Console.Clear();
                        AlterarProduto();
                        break;
                    case 3:
                        Console.Clear();
                        ListarProdutos(_produtos);
                        break;
                    case 4:
                        Console.Clear();
                        BuscarProdutoPorId();
                        break;
                    case 5:
                        Console.Clear();
                        RemoverProduto();
                        break;
                    case 6:
                        Console.Clear();
                        continuar = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(" 😳 Opção Inválida!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
            }
        } while (continuar);
    }
    private void CadastrarProduto()
    {
        Console.WriteLine(" 👗 CADASTRAR PRODUTO 👗 ");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "";
        Console.Write(" -> Preço: ");
        double preco = double.Parse(Console.ReadLine() ?? "");
        Console.Write(" -> Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "");

        CategoriaUI listarCategoria = new CategoriaUI(_categorias);
        Console.Clear();
        listarCategoria.ListarCategorias(_categorias);

        Console.Write(" -> ID da categoria: ");
        int idCategoria = int.Parse(Console.ReadLine() ?? "0");

        CategoriaModel? categoria = _categorias.Find(c => c.CategoriaID == idCategoria);

        if (categoria == null)
        {
            Console.Clear();
            Console.WriteLine(" 🤷‍♂️ Categoria Não Encontrada! 🗺️");
            return;
        }

        ProdutoModel produto = new ProdutoModel(
            _produtos.Max((p) => p.ProdutoID) + 1,
            nome,
            descricao,
            preco,
            quantidade,
            categoria
        );
        _produtos.Add(produto);

        Console.Clear();
        Console.WriteLine(" 👗 Produto Cadastrado com Sucesso! ✅ ");
    }

    private void AlterarProduto()
    {
        Console.WriteLine(" 👗 ALTERAÇÃO DE PRODUTO");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ProdutoModel? produto = _produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.Clear();
            Console.WriteLine(" 👗 Produto Não Encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";
        Console.Write(" -> Preço: ");
        double preco = double.Parse(Console.ReadLine() ?? "0");
        Console.Write(" -> Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "");

        CategoriaUI listarCategoria = new CategoriaUI(_categorias);
        Console.Clear();
        listarCategoria.ListarCategorias(_categorias);

        Console.Write(" -> ID da categoria: ");
        int idCategoria = int.Parse(Console.ReadLine() ?? "0");

        CategoriaModel? categoria1 = _categorias.Find(c => c.CategoriaID == idCategoria);

        if (categoria1 == null)
        {
            Console.Clear();
            Console.WriteLine(" 🤷‍♂️ Categoria Não Encontrada! 🗺️");
            return;
        }
        produto.Categoria = categoria1;

        produto.Nome = nome;
        produto.Descricao = descricao;
        produto.Preco = preco;
        produto.Quantidade = quantidade;
        produto.Categoria = produto.Categoria;

        Console.Clear();
        Console.WriteLine(" 👗 Produto Alterado com Sucesso! ✅ ");
    }

    private void BuscarProdutoPorId()
    {
        Console.WriteLine(" 👗 BUSCA DE PRODUTO POR ID");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ProdutoModel? produto = _produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.Clear();
            Console.WriteLine(" 👗 Produto Não Encontrado! 🗺️ ");
            return;
        }

        Console.WriteLine($" {produto.ProdutoID} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade} | Categoria: {produto.Categoria.Nome}");
    }

    private void RemoverProduto()
    {
        Console.WriteLine(" 🗑️ REMOÇÃO DE PRODUTO 🗑️ ");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ProdutoModel? produto = _produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.Clear();
            Console.WriteLine(" 👗 Produto Não Encontrado! 🗺️ ");
            return;
        }

        _produtos.Remove(produto);

        Console.Clear();
        Console.WriteLine(" 👗 Produto Removido com Sucesso! 🗑️ ");
    }

    public void ListarProdutos(List<ProdutoModel> produtos)
    {
        Console.Clear();
        Console.WriteLine(" 📜 TODOS OS PRODUTOS 📜 ");

        if (produtos.Count < 1)
        {
            Console.WriteLine(" ");
            Console.Write("\x1B[3m"); // Change font to italic
            Console.WriteLine(" Não há Produtos Cadastrados.");
            Console.ResetColor(); // Reset font style to default
        }

        foreach (ProdutoModel produto in produtos)
        {
            Console.WriteLine($" {produto.ProdutoID} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade} | Categoria: {produto.Categoria.Nome}");
        }

        Console.WriteLine(" ");
    }
}