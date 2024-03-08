using CookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookApp.Domain.Dtos
{
    public class MenuDTO
    {
        public string Id { get; set; }
        public string Menu { get; set; }
        public List<MenuItem> Items { get; set; }

        public int TotalAreaRequired()
        {
            int totalArea = 0;
            foreach (var item in Items)
            {
                totalArea += item.Area * item.Quantity;
            }
            return totalArea;
        }

        public int CalculateRounds(int grillArea)
        {
            int totalAreaRequired = TotalAreaRequired();
            int rounds = (int)Math.Ceiling((double)totalAreaRequired / grillArea);
            return rounds;
        }
    }
}
