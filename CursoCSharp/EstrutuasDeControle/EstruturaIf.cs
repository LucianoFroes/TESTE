﻿using System;


namespace CursoCSharp.CursoCSharp.EstrutuasDeControle {
     class EstruturaIf {
        public static void Executar() {

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            if(entrada == "S" || entrada == "s") 
                bomComportamento = true;
            
            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quador de honra!");
            }
        }
    }
}
