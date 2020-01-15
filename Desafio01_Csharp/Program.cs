using System;

namespace Desafio01_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String marca = "Hyundai", modelo = "HB20", placa = "22222", cor = "Preto";
            bool isligado = false, isAcelerar=false, isFrear=false, isPintar=false;
            int qtdabastecer, combustivel = 100, velocidade = 0, preco = 2;

            Veiculo meucarro = new Veiculo(marca, modelo, placa, cor, isligado, combustivel, velocidade, preco);
            while(true)
            {
                Console.WriteLine("Ligar/Desligar o veículo?");
                String escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "Ligar":
                        meucarro.ligar();
                        break;
                    case "Desligar":
                        meucarro.desligar();
                        break;
                }
                if (meucarro.isLigado == true)
                {
                    Console.WriteLine("Deseja pintar seu veículo?(Sim/Não)");
                    String escolhapintar = Console.ReadLine();
                    switch (escolhapintar)
                    {
                        case "Sim":
                            Console.WriteLine("Qual cor?");
                            String newcor = Console.ReadLine();
                            meucarro.pintar(newcor);
                            break;
                    }
                    Console.WriteLine("Deseja acelerar?(Sim/Não)");
                    String escolhaacelerar = Console.ReadLine();
                    switch (escolhaacelerar)
                    {
                        case "Sim":
                            meucarro.acelerar();
                            break;
                    }
                    if (meucarro.Velocidade > 0)
                    {
                        Console.WriteLine("Deseja frear?(Sim/Não)");
                        String escolhafrear = Console.ReadLine();
                        switch (escolhafrear)
                        {
                            case "Sim":
                                meucarro.frear();
                                break;
                        }
                    }
                    Console.WriteLine("Deseja abastecer?(Sim/Não)");
                    String escolhaabastecer = Console.ReadLine();
                    switch (escolhaabastecer)
                    {
                        case "Sim":
                            Console.WriteLine("Quantos litros deseja abastecer?");
                            int qtdlitros = Convert.ToInt32(Console.ReadLine());
                            meucarro.abastecer(qtdlitros);
                            break;
                    }
                }
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("MEU VEÍCULO:");
                Console.WriteLine("Marca: "+meucarro.Marca);
                Console.WriteLine("Modelo: "+meucarro.Modelo);
                Console.WriteLine("Placa: "+meucarro.Placa);
                Console.WriteLine("Cor: "+meucarro.Cor);
                if (meucarro.isLigado == true) 
                {
                    Console.WriteLine("O veículo está ligado com velocidade de " + meucarro.Velocidade + "Km/h.");
                }
                else
                {
                    Console.WriteLine("O veículo está desligado.");
                }
                    Console.WriteLine("Está com "+meucarro.LitrosCombustivel+" litros de combustível.");
                Console.WriteLine("___________________________________________________");
            }
        }
    }
}
