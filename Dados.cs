using System;

class Dados 
{
    
    Filme[] CadFilme = new Filme[2];

    Filme filme;

    int Indice = 0;

    public void CadastrarFilme()
    {

        do { 
            filme = new Filme();
            Console.Write("Nome do Filme: " );
            filme.Nome = Console.ReadLine();

            Console.Write("Duração: ");
            filme.Duração = Console.ReadLine();

            Console.Write("Nome do diretor: ");
            filme.NomeDiretor = Console.ReadLine();

            Console.Write("Categoria: ");
            filme.Categoria = Console.ReadLine();


            CadFilme[Indice] = filme;
            Indice++;

            Console.Clear();
            Console.WriteLine("\nDeseja cadastrar outro filme? (ESC cancela...)");
        } while(Console.ReadKey().Key != ConsoleKey.Escape);

        Console.ReadKey();

    }

    public void ListarFilmes()
        {
            foreach (Filme x in CadFilme)
            {
                Console.WriteLine(" Nome do Filme: {0}", x.Nome );
                Console.WriteLine(" Duração: {0} ", x.Duração);
                Console.WriteLine(" Nome do diretor: {0} ", x.NomeDiretor);
                Console.WriteLine(" Categoria: {0} \n", x.Categoria);            
            }
        }

  public void ListarFilmeCategoria()
    {
        string Cat ="";
        Console.WriteLine("Qual categoria você deseja filtrar?");
        Cat = Console.ReadLine();

        foreach(Filme x in CadFilme)
        {
            if (x.Categoria == Cat)
            {
                Console.WriteLine(" Nome do Filme: {0}", x.Nome );
                Console.WriteLine(" Duração: {0} ", x.Duração);
                Console.WriteLine(" Nome do diretor: {0} ", x.NomeDiretor);
                Console.WriteLine(" Categoria: {0} \n", x.Categoria);
            }
        }
        Console.ReadKey();
    }
}

