﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO.Operacje
{
    interface IFilter
    {
        /// <summary>
        /// Konwertuje obraz wlasnych kryteriów
        /// </summary>
        /// <returns>Obraz po konwersji</returns>
        void Convert();

        /// <summary>
        /// Informuje czy filtr używa dialogu
        /// </summary>
        bool hasDialog { get; }

        /// <summary>
        /// Pobiera obraz na którym ma dokonać konwersji
        /// </summary>
        /// <param name="image">Obraz do konwersji</param>
        void setImage(Image image);

        bool showDialog();
    }
}
