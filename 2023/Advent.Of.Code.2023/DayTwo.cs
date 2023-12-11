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
            var powerOfFewest = new List<int>();

            for (int i = 0; i < lines.Length; i++)
            {
                string? line = lines[i];

                var validRound = false;

                var gameId = int.Parse(line.Substring(0, line.IndexOf(":")).Replace("Game", string.Empty));

                line = line.Replace($"Game {gameId}:", string.Empty);

                var rounds = line.Split(";");

                var highestRed = 0;
                var highestGreen = 0;
                var highestBlue = 0;

                for (int r = 0; r < rounds.Length; r++)
                {
                    var redTakenOut = 0;
                    var greenTakenOut = 0;
                    var blueTakenOut = 0;

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

                    if (redTakenOut > highestRed)
                    {
                        highestRed = redTakenOut;
                    }

                    if (greenTakenOut > highestGreen)
                    {
                        highestGreen = greenTakenOut;
                    }

                    if (blueTakenOut > highestBlue)
                    {
                        highestBlue = blueTakenOut;
                    }

                    //part 1
                    //if (totalRedCubes >= redTakenOut && totalGreenCubes >= greenTakenOut && totalBlueCubes >= blueTakenOut)
                    //{
                    //    validRound = true;
                    //}
                    //else
                    //{
                    //    validRound = false;
                    //    break;
                    //}
                }

                //part 1
                //if (validRound)
                //{
                //    validGames.Add(gameId);
                //}

                powerOfFewest.Add(highestRed * highestGreen * highestBlue);
            }

            //part 1
            //Console.WriteLine(validGames.Sum(gameId => gameId));

            Console.WriteLine(powerOfFewest.Sum(x => x));

            Console.Read();
        }
    }
}
