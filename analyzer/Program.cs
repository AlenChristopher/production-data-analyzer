using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "../data/sample_production_data.csv";

        var lines = File.ReadAllLines(filePath).Skip(1);

        var records = lines.Select(line =>
        {
            var cols = line.Split(',');
            return new
            {
                Station = cols[1],
                ProcessingTime = double.Parse(cols[2]),
                Failure = int.Parse(cols[3])
            };
        });

        var grouped = records.GroupBy(r => r.Station);

        Console.WriteLine("---- Production Analysis ----");

        foreach (var g in grouped)
        {
            Console.WriteLine($"{g.Key}: Total Time = {g.Sum(x => x.ProcessingTime)}, Failures = {g.Sum(x => x.Failure)}");
        }

        var bottleneck = grouped
            .OrderByDescending(g => g.Sum(x => x.ProcessingTime))
            .First();

        Console.WriteLine($"\n🔥 Bottleneck: {bottleneck.Key}");
    }
}
