System.Console.WriteLine("Bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Agora, por favor digite o preço por hora:");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

bool menu = true;

List <string> carros = new List<string>();

while (menu)
{
    System.Console.WriteLine("Digite a opção:");
    System.Console.WriteLine("1 - Cadastrar veículo");
    System.Console.WriteLine("2 - Remover veículo");
    System.Console.WriteLine("3 - Listar veículos");
    System.Console.WriteLine("4 - Encerrar programa");

    int opcao = Convert.ToInt32(Console.ReadLine());
    switch(opcao)
    {
        case 1: 
            Cadastro();
            break;
        
        case 2:
            Remover();
            break;

        case 3:
            Listagem();
            break;

        case 4: 
            menu = false; 
            break;

        default: 
            System.Console.WriteLine("valor digitado inválido, tente novamente.");
            break;

    }
}

void Cadastro()
{
    System.Console.WriteLine("Digite a placa do veículo que deseja cadastrar");
    carros.Add(Console.ReadLine());
    System.Console.WriteLine("Adicionado com sucesso! Aperte qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
}

void Remover()
{
    System.Console.WriteLine("Digite a placa do veículo que deseja remover");
    string placa = Console.ReadLine();

    if (carros.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        System.Console.WriteLine("Qual a quantidade de horas que o veículo ficou?");
        int hora = Convert.ToInt32(Console.ReadLine());
        carros.Remove(placa);
        System.Console.WriteLine($"O veículo {placa} foi removido! O preço total ficou: R${(precoHora * hora) + precoInicial}");
        System.Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

    else
    {
       
        System.Console.WriteLine($"A placa do veículo digitado não está estacionado aqui, confira se a placa está correta: {placa}");
        Console.WriteLine("Aperte qualquer tecla para continuar!");
        Console.ReadKey();
        Console.Clear();
    }
}

void Listagem()
{
    if (carros.Any())
    {
        foreach (string placa in carros)
        {
            Console.WriteLine($"Placa: {placa}");
        }
        Console.WriteLine($"Total de veículos no estacionamento: {carros.Count}\n");
        Console.WriteLine("Aperte qualquer tecla para continuar!");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Não possui veículos encontrados");
        Console.WriteLine("Aperte qualquer tecla para continuar!");
        Console.ReadKey();
        Console.Clear();
    }
}