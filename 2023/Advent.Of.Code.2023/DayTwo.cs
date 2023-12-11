namespace Advent.Of.Code._2023
{
    public static class DayTwo
    {
        public static void Solve()
        {
            var lines = File.ReadAllLines("day-2.txt");

            var totalRedCubes = 12;
            var totalGreenCubes = 13;
            var totalBlueCubes = 14;

            var validGames = new List<int>();

            for (int i = 0; i < lines.Length; i++)
            {
                string? line = lines[i];

                var validRound = false;

                var gameId = int.Parse(line.Substring(0, line.IndexOf(":")).Replace("Game", string.Empty));

                line = line.Replace($"Game {gameId}:", string.Empty);

                var rounds = line.Split(";");

                for (int r = 0; r < rounds.Length; r++)
                {
                    var redTakenOut = 0;
                    var greenTakenOut = 0;
                    var blueTakenOut = 0;

                    var lowestRed = 100;
                    var lowestGreen = 100;
                    var lowestBlue = 100;

                    var cubes = rounds[r].Split(",");

                    for (int c = 0; c < cubes.Length; c++)
                    {
                        string? cube = cubes[c];
                        cubes[c] = cube.Substring(1, cube.Length - 1);
                    }

                    for (int c = 0; c < cubes.Length; c++)
                    {
                        var amountTakenOut = int.Parse(cubes[c].Substring(0, 2));

                        cubes[c] = cubes[c].Replace(amountTakenOut.ToString(), string.Empty);

                        var colour = cubes[c].Trim();

                        switch (colour)
                        {
                            case "red":
                                redTakenOut += amountTakenOut;
                                break;
                            case "green":
                                greenTakenOut += amountTakenOut;
                                break;
                            case "blue":
                                blueTakenOut += amountTakenOut;
                                break;
                            default:
                                break;
                        }
                    }

                    if (totalRedCubes >= redTakenOut && totalGreenCubes >= greenTakenOut && totalBlueCubes >= blueTakenOut)
                    {
                        validRound = true;
                    }
                    else
                    {
                        validRound = false;
                        break;
                    }
                }

                if (validRound)
                {
                    validGames.Add(gameId);
                }
            }

            Console.WriteLine(validGames.Sum(gameId => gameId));

            Console.Read();
        }
    }
}
