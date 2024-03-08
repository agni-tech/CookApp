using CookApp.Domain.Dtos;
using CookApp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    public const int grillArea = 20 * 30;

    public static async Task Main(string[] args)
    {
        GetDataFromEndpoint endpoint = new GetDataFromEndpoint();
        List<MenuDTO> menus = await endpoint.GetData();

        int totalRounds = 0;

        // Calculate rounds for each menu
        foreach (var menu in menus)
        {
            int rounds = menu.CalculateRounds(grillArea);
            Console.WriteLine($"{menu.Menu}: {rounds} rounds.");
            totalRounds += rounds;
        }
        Console.WriteLine("");
        Console.WriteLine("====================");
        Console.WriteLine($"  Total: {totalRounds} rounds.");
        Console.WriteLine("====================");
    }
}