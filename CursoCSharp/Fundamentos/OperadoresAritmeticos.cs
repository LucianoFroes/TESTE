﻿using System;
using System.Globalization;

namespace CursoCSharp.CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Math.pow potência, primeiro é a base e depois o expoente
            Console.WriteLine($"IMC é {imc}.");

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} / 2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0} / 2 tem resto {1}", impar, impar % 2);
        }
    }
}
