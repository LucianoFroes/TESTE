﻿using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.CursoCSharp.Colecoes {
     class ColecoesArrayList {

        public static void Executar() {

            var arrayList = new ArrayList() {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);
            foreach(var item in arrayList) {
                Console.WriteLine($"{item} {item.GetType()}");
            }
        }
    }
}
