var acc = 0;
var callories = new List<int>();

await foreach (var line in File.ReadLinesAsync("./data.txt"))
{
    if (string.IsNullOrEmpty(line))
    {
        callories.Add(acc);
        acc = 0;
    }
    else
    {
        acc += Int32.Parse(line);
    }
}

var maxCallories = callories.Max();
var totalCalloriesOfThreeElves = callories.OrderDescending().Take(3).Sum();

Console.WriteLine($"Max calories: {maxCallories}");
Console.WriteLine($"Total callories of 3 elves: {totalCalloriesOfThreeElves}");