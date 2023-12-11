namespace Advent.Of.Code._2023
{
    public static class DayOne
    {
        public static void Solve()
        {
            var lines = File.ReadAllLines("puzzle-1.txt");
            var numbers = new List<int>();

            changeToNumbers(lines);

            foreach (var line in lines)
            {
                int firstDigit = 0;
                int lastDigit = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (int.TryParse(line[i].ToString(), out firstDigit))
                        break;
                }

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    if (int.TryParse(line[i].ToString(), out lastDigit))
                        break;
                }

                var num = firstDigit + "" + lastDigit;

                numbers.Add(int.Parse(num));
            }

            int total = 0;

            foreach (var number in numbers)
            {
                total += number;
            }

            Console.Out.WriteLine(total.ToString());

            void changeToNumbers(string[] lines)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    do
                    {
                        lines[i] = transformLine(lines[i]);
                    } while (containsWordNumbers(lines[i]));
                }
            }

            bool containsWordNumbers(string line)
            {
                if (line.Contains("one"))
                {
                    return true;
                }

                if (line.Contains("two"))
                {
                    return true;
                }

                if (line.Contains("three"))
                {
                    return true;
                }

                if (line.Contains("four"))
                {
                    return true;
                }

                if (line.Contains("five"))
                {
                    return true;
                }

                if (line.Contains("six"))
                {
                    return true;
                }

                if (line.Contains("seven"))
                {
                    return true;
                }

                if (line.Contains("eight"))
                {
                    return true;
                }

                if (line.Contains("nine"))
                {
                    return true;
                }

                return false;
            }

            string transformLine(string line)
            {
                if (line.Contains("one"))
                {
                    line = line.Replace("one", "o1e");
                }

                if (line.Contains("two"))
                {
                    line = line.Replace("two", "t2o");
                }

                if (line.Contains("three"))
                {
                    line = line.Replace("three", "t3e");
                }

                if (line.Contains("four"))
                {
                    line = line.Replace("four", "f4r");
                }

                if (line.Contains("five"))
                {
                    line = line.Replace("five", "f5e");
                }

                if (line.Contains("six"))
                {
                    line = line.Replace("six", "s6x");
                }

                if (line.Contains("seven"))
                {
                    line = line.Replace("seven", "s7n");
                }

                if (line.Contains("eight"))
                {
                    line = line.Replace("eight", "e8t");
                }

                if (line.Contains("nine"))
                {
                    line = line.Replace("nine", "n9e");
                }

                return line;
            }
        }
    }
}
