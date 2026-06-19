using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus;
using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.excecao;
using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.Interfaces;
using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.modelos;
using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.repositorio;

IRepositorioLivro repo = new RepositorioLivro();

repo.Adicionar(new Livro(1, "Dom Casmurro", "Machado de Assis", 1899, true));
repo.Adicionar(new Livro(2, "O Cortiço", "Aluísio Azevedo", 1890, false));
repo.Adicionar(new Livro(3, "Iracema", "José de Alencar", 1865, true));
repo.Adicionar(new Livro(4, "Memórias Póstumas", "Machado de Assis", 1881, true));
repo.Adicionar(new Livro(5, "O Guarani", "José de Alencar", 1857, false));

Console.WriteLine("=== Todos os livros (ordenados por título) ===");
foreach (var l in repo.ListarTodos())
{
    Console.WriteLine($"[{l.Id}] {l.Titulo} | {l.Autor} | {l.Ano} | {(l.Disponivel ? "Disponível" : "Indisponível")}");
}

Console.WriteLine("\n=== Buscar por autor: Machado de Assis ===");
foreach (var l in repo.BuscarPorAutor("Machado de Assis"))
{
    Console.WriteLine($"[{l.Id}] {l.Titulo} | {l.Ano}");
}

Console.WriteLine("\n=== Buscar por Id ===");
Console.Write("Digite o Id do livro: ");
int id = int.Parse(Console.ReadLine());

try
{
    var encontrado = repo.BuscarPorId(id);
    Console.WriteLine($"Encontrado: {encontrado.Titulo} | {encontrado.Autor}");
}
catch (LivroNaoEncontradoException ex)
{
    Console.WriteLine(ex.Message);
}