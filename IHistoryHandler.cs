using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOOP_Hivers_2024
{
    internal interface IHistoryHandler
    {
        //methodes a implementer pour les classes qui implementent cette interface
        void Write();
        string[] Read();

    }
}
