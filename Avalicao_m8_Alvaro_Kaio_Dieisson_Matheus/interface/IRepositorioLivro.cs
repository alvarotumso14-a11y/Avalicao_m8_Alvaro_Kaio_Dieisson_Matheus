using Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalicao_m8_Alvaro_Kaio_Dieisson_Matheus
{
    interface IRepositorioLivro
    {

        void Adicionar(Livro p);

        List<Livro> ListarTodos();

        List<Livro> BuscarPorCategoria(string categoria);

        public Livro BuscarPorId(int id);
    }
}
