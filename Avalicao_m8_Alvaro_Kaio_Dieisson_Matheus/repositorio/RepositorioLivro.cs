using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.excecao;
using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.repositorio.RepositorioLivro;

namespace Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus
{
    internal class RepositorioLivro
    {
        internal class RepositorioProduto : IRepositorioLivro
        {
            private List<Livro> livros = new();
          

            public void Adicionar(Livro L)
            {
                Livro.Add(L);
            }

            public List<Livro> ListarTodos()
            {
                return livros;
            }

            public List<Livro> BuscarPorAutor(string autor)
            {
                return livros
                    .Where(p => p.Autor == autor)
                    .ToList();
            }

            public Livro BuscarPorId(int id)
            {
                var livro = livros.FirstOrDefault(p => p.Id == id);
                return livro ?? throw new LivroNaoEncontradoException($"Id {id} nao encontrado");
            }

            public List<Livro> BuscarPorCategoria(string categoria)
            {
                throw new NotImplementedException();
            }
        }
    }
}
}
