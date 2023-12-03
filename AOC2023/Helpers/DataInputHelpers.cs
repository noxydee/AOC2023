namespace AOC2023.Helpers
{
    public static class DataInputHelpers
    {
        public static async Task<List<string>> GetInputLinesAsync(string wholeInput)
        {
            List<string> inputLines = new List<string>();
            
            StringReader reader = new(wholeInput);

            while (true)
            {
                string? line = await reader.ReadLineAsync();

                if (line == null)
                {
                    break;
                }

                inputLines.Add(line);
            }

            return inputLines;
        }
    }
}
