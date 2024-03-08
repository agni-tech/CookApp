using System;
using System.Collections.Generic;
using System.Text;

namespace CookApp.Domain.Entities
{
    public class MenuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string Duration { get; set; }
        public int Quantity { get; set; }

        public int Area => Length * Width;
    }
}
