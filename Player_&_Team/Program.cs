using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerTeamLibrary;

namespace Player___Team
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter \n 1: To Add Player \n 2: To Remove Player by Id \n 3: Get Player By Id \n 4: Get Player by Name\n 5: Get All Players \n 6: Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerId = playerId,
                            PlayerName = playerName,
                            PlayerAge = playerAge
                        };

                        team.Add(newPlayer);
                        break;
                    case 2:
                        Console.WriteLine("Enter Player Id to remove:");
                        int removeId = int.Parse(Console.ReadLine());
                        team.Remove(removeId);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player Id to retrieve:");
                        int retrieveId = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(retrieveId);
                        Console.WriteLine(playerById != null ? $"Player found: {playerById.PlayerName}" : "Player not found.");
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name to retrieve:");
                        string retrieveName = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(retrieveName);
                        Console.WriteLine(playerByName != null ? $"Player found: {playerByName.PlayerName}" : "Player not found.");
                        break;
                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        if (allPlayers.Count > 0)
                        {
                            Console.WriteLine("All Players:");
                            foreach (var player in allPlayers)
                            {
                                Console.WriteLine($"PlayerId: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No players in the team.");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
