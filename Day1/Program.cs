var input = File.ReadAllLines(@"../../../input.txt");
var result = 0;

var left = new List<int>();
var right = new List<int>();
foreach (var line in input)
{
    var parts = line.Split("   ");
    left.Add(int.Parse(parts[0]));
    right.Add(int.Parse(parts[1]));
}

//Part 1
left.Sort();
right.Sort();

for (var i = 0; i < left.Count; i++)
{
    result += Math.Abs(left[i] - right[i]); 
}

Console.WriteLine($"Part1: {result}");

//Part 2
var result2 = (from number in left let count = right.Count(x => x.Equals(number)) select count * number).Sum();

Console.WriteLine($"Part2: {result2}");