// See https://aka.ms/new-console-template for more information
using restaurante;

Console.WriteLine("Restaurante");
Menu menu = new Menu();

string opcao;
bool menuAberto = true;
menu.LimparPrato();
int contador = 0;

while (menuAberto)
{
    Console.Clear();

    Console.WriteLine("Menu\n");
    Console.WriteLine("1 - Servir prato");
    Console.WriteLine("2 - Limpar prato");
    Console.WriteLine("3 - Sair\n");

    Console.WriteLine("Informe a opção desejada:\n");

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("O prato solicitado será servido em breve");
        contador = contador + 1;

        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadKey();

    }

    else if (opcao == "2")
    {
        menu.LimparPrato();
        
        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadKey();

    }
    else if (opcao == "3")
    {
        menu.SairDoRestaurante();
        Console.WriteLine($"Pratos pedidos: {contador}");
        menuAberto = menu.SairDoRestaurante();

    }

    else
    {
        Console.WriteLine("Não existe opcao...\n");
    }




}

    
