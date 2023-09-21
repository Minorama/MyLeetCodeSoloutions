string input = "MCMXCIV";
int result = 0;

IDictionary<char,int> romanNumerals = new Dictionary<char,int>()
{
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000}
};

for(int i = 0; i < input.Length; i++)
{
    if(i + 1 < input.Length && romanNumerals[input[i]] < romanNumerals[input[i+1]])
    {
        result -= romanNumerals[input[i]];
    }
    else
    {
        result += romanNumerals[input[i]];
    }
}

Console.WriteLine(result);