using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Csharp
{
    class Veiculo
    {
        private String _Marca, _Modelo, _Placa, _Cor;
        private bool _isLigado;
        private int _LitrosCombustivel, _Velocidade;
        private double _Preco;

        public Veiculo(String marca, String modelo, String placa, String cor, bool isligado, int combustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.isLigado = isligado;
            this.LitrosCombustivel = combustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }
        public String Cor { get; set; }
        public bool isLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; }
        public string Marca { get; }
        public string Modelo { get; }
        public string Placa { get; }

        public void acelerar()
        {
            if (this.LitrosCombustivel > 0)
            {
                this.Velocidade += 20;
                this.LitrosCombustivel--;
            }
            else
            {
                Console.WriteLine("Você está sem combustível e não pode acelerar");
            }
        }
        public void abastecer(int qtdLitros)
        {
            if (qtdLitros >= 0)
            {
                this.LitrosCombustivel += qtdLitros;
                if (this.LitrosCombustivel > 100)
                {
                    this.LitrosCombustivel -= qtdLitros;
                    int sobra = 100 - this.LitrosCombustivel;
                    Console.WriteLine("Você abasteceu somente " + sobra + " Litros de combustível, pois excedeu o limite de 100 Litros.");
                    this.LitrosCombustivel = 100;
                }
            }
            else
            {
                Console.WriteLine("Você não pode abastecer essa quantidade.");
            }
        }
        public void frear()
        {
            if (this.Velocidade > 0)
            {
                this.Velocidade -= 10;
            }
        }
        public void pintar(String cor)
        {
            this.Cor = cor;
        }
        public void ligar()
        {
            if (this.isLigado == false)
            {
                this.isLigado = true;
                this.Velocidade = 20;
            }
        }
        public void desligar()
        {
            this.isLigado = false;
        }
    }
}
