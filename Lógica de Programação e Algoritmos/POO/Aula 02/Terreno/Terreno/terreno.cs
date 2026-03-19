using System;
using System.Collections.Generic;
using System.Text;

namespace Terreno
{
    internal class terreno
    {
        // campos
        public double largura, comprimento, valor;

        // construtor
        public terreno(double largura, double comprimento, double valor)
        {
          
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }
        // métodos
        public double area()
        {
            return largura * comprimento;
        }
    
        public double preco()
        {
            return area() * valor;
        }
    public void Saida() 
            {
            Console.WriteLine($"Área do terreno: {area()}");
            Console.WriteLine($"Preço do terreno = R$ {preco()}");
        }
    }



}
