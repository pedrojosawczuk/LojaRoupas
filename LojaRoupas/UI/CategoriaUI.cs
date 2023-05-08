using LojaRoupas.Model;

namespace LojaRoupas.UI.Categoria;

public class CategoriaUI
{
    private List<CategoriaModel> _categorias;
    public CategoriaUI(List<CategoriaModel> categorias)
    {
        _categorias = categorias;
    }
    public void MenuCategoria()
    {
        bool continuar = true;
        do
        {
            Console.WriteLine(" 🔠 CATEGORIA 🔠 ");
            Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine(" 1 - Cadastrar Categoria");
            Console.WriteLine(" 2 - Alterar Categoria");
            Console.WriteLine(" 3 - Listar Todas as Categorias");
            Console.WriteLine(" 4 - Buscar Categoria por Id");
            Console.WriteLine(" 5 - Remover Categoria");
            Console.WriteLine(" 6 - Voltar");
            Console.Write(" 👉 ");

            try
            {
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine(" ");

                switch (opcao)
                {
                    case 1:
                        CadastrarCategoria();
                        break;
                    case 2:
                        AlterarCategoria();
                        break;
                    case 3:
                        ListarCategorias(_categorias);
                        break;
                    case 4:
                        BuscarCategoriaPorId();
                        break;
                    case 5:
                        RemoverCategoria();
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
    private void CadastrarCategoria()
    {
        Console.WriteLine(" 🔠 CADASTRAR CATEGORIA 🔠 ");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";

        long id;
        if (_categorias.Count < 1)
        {
            id = 1;
        }
        else
        {
            id = _categorias.Max((c) => c.CategoriaID) + 1;
        }
        CategoriaModel categoria = new CategoriaModel
        (
            id,
            nome,
            descricao
        );
        _categorias.Add(categoria);

        Console.Clear();
        Console.WriteLine(" 🧾 Categoria Cadastrada com Sucesso! ✅ ");
    }

    private void AlterarCategoria()
    {
        Console.Clear();
        Console.WriteLine(" 🔠 ALTERAÇÃO DE CATEGORIA 🔠 ");
        Console.Write(" -> ID da Categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        CategoriaModel? categoria = _categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.Clear();
            Console.WriteLine(" 🤷‍♂️ Categoria Não Encontrada! 🗺️");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";

        categoria.Nome = nome;
        categoria.Descricao = descricao;

        Console.Clear();
        Console.WriteLine(" 🧾 Categoria Alterada com Sucesso! ✅ ");
    }

    private void BuscarCategoriaPorId()
    {
        Console.Clear();
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE CATEGORIA POR ID 🕵️‍♀️ ");
        Console.Write(" -> ID da Categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        CategoriaModel? categoria = _categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.Clear();
            Console.WriteLine(" 🤷‍♂️ Categoria Não Encontrada! 🗺️");
            return;
        }

        Console.Clear();
        Console.WriteLine($" {categoria.CategoriaID} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
    }

    private void RemoverCategoria()
    {
        Console.Clear();
        Console.WriteLine(" 🗑️ REMOÇÃO DE CATEGORIA 🗑️ ");
        Console.Write(" -> ID da Categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        CategoriaModel? categoria = _categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.Clear();
            Console.WriteLine(" 🤷‍♂️ Categoria Não Encontrada! 🗺️");
            return;
        }

        _categorias.Remove(categoria);

        Console.Clear();
        Console.WriteLine(" 🧾 Categoria Removida com Sucesso! 🗑️ ");
    }

    public void ListarCategorias(List<CategoriaModel> categorias)
    {
        Console.Clear();
        Console.WriteLine(" 📜 TODAS AS CATEGORIAS 📜 ");

        if (categorias.Count < 1)
        {
            Console.WriteLine(" ");
            Console.Write("\x1B[3m"); // Change font to italic
            Console.WriteLine(" Não há Categorias Cadastradas.");
            Console.ResetColor(); // Reset font style to default
        }

        foreach (CategoriaModel categoria in categorias)
        {
            Console.WriteLine($" {categoria.CategoriaID} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
        }
        Console.WriteLine(" ");
    }
}