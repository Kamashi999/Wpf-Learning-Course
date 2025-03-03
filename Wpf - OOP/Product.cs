using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf___OOP
{
    //nazwe klasy zazwyczaj to rzeczownik w l.poj.
    class Product
    {
        //string name - nazywamy polem. Bez podania żadnego modyfikatora, to domyślnie jest to
        //zmienna prywatna. Oznacza to że dzięki temu będzie dostępne tylko wewnątrz tej klasy.
        private string _name; //przed nazwą prywatnego pola, dajemy _.
        public Product(string name)
        {
            _name = name;   
        }
    }
}
