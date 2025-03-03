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
        //przed nazwą prywatnego pola, dajemy _.
        
        //private string _name; 
        //public Product(string name)
        //{
        //    _name = name;   
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName (string name)
        //{
        //    _name = name;
        //}

        // Sposób podany powyżej jest opcjonalny, dzięki publicznym funkcjom możemy sprawdzać różne parametry, np
        //sprawdzenie czy dana nazwa nie jest już w systemie, aby jej nie nadpisać. Dlatego blokujemy klasę sekwencją private.

        //drugi sposób natomiast jest częściej stosowany.

        //W publicznych nazwach podajemy nazwę z dużej litery.

        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }

        public void SetName (string name = "Default")
        {
            Name = name;
        }

    }
}
