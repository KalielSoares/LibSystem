using LibrarySystem.Models;

class Program
{
    static void Main(string[] args)
    {
        //Inicialização das Variaveis
        Librarian? librarianL = null;
        bool exibirMenu = true;
        List<Member> members = new();

        Book book;
        Console.Clear();
     


        string l = "";
        Console.WriteLine($"Library ***** ");
        Console.WriteLine("Qual o nome da library?");
        l = Console.ReadLine();
        
        Library nameLibrary = new Library(l);
        
        

        
        // Loop do menu
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine($"Library {l}");
            Console.WriteLine();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar Membro");
            Console.WriteLine("2 - Cadastrar Bibliotecário");
            Console.WriteLine("3 - Cadastrar Livro");
            Console.WriteLine("4 - Remover Livro");
            Console.WriteLine("5 - Listar Livros");
            Console.WriteLine("6 - Emprestar livro para um membro");
            Console.WriteLine("7 - Listar Membros com livros emprestados");
            Console.WriteLine("8 - Encerrar");
            Console.WriteLine();

            //Depois que entender o funcionamento da conexão com Db refatorar esse trecho ->
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Digite o nome do novo membro: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o email do novo membro: ");
                    string email = Console.ReadLine();
                    Member novoMembro = new Member(nome, email);
                    members.Add(novoMembro);
                    nameLibrary.Members.Add(novoMembro);
                    Console.WriteLine("Membro adicionado com sucesso.");
                
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Digite o nome do novo Funcionário da biblioteca: ");
                    string nomeL = Console.ReadLine();
                    Console.WriteLine("Digite o email: ");
                    string emailL = Console.ReadLine();
                    librarianL = new Librarian(nomeL, emailL);
                    Console.WriteLine("\nMembro adicionado com sucesso.\n");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite o titulo do livro: ");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Digite o autor do livro: ");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Digite o código ISBN do livro: ");
                    string isbn = Console.ReadLine();
                    book = new Book(titulo, autor, isbn);
                    librarianL.AddBookToLibrary(nameLibrary,book);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Digite o titulo do livro para ser removido: ");
                    string tituloRemovido = Console.ReadLine();
                    librarianL.RemoveBook(nameLibrary,tituloRemovido);
                    break;
                case "5":
                    Console.Clear();
                    nameLibrary.ListBooks();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Digite o nome do membro que vai pegar o livro emprestado: ");
                    string membroEmprestado = Console.ReadLine();
                    Console.WriteLine("Digite o nome do livro: ");
                    string nomeLivro = Console.ReadLine();
                    Book tituloLivro = nameLibrary.FindBook(nomeLivro);
                    librarianL.AddBookToMember(membroEmprestado,tituloLivro,nameLibrary);
                    break;
                case "7":
                    Console.Clear();

                    nameLibrary.MemberWithBook();

                    
                    break;
                case "8":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        
        
    }
}

