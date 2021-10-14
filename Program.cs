using System;

namespace FilmeDvd
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados getDados = new Dados();
            getDados.CadastrarFilme();

            getDados.ListarFilmes();

            getDados.ListarFilmeCategoria();
            
        }

    }
}
