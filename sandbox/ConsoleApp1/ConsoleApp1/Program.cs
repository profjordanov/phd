Console.WriteLine("Start");

var records = File.ReadAllLines("benl.csv");

var results = records
    .Select((x, i) => new { Index = i, Value = x })
    .GroupBy(x => x.Index / 380)
    .Select(x => x.Select(v => v.Value).ToList())
    .ToList();

for (int i = 0; i < results.Count; i++)
{
    File.WriteAllLines($"./batch{i+1}.csv", results[i]);
    Console.WriteLine($"./batch{i+1}.csv");
}

Console.WriteLine("Done");