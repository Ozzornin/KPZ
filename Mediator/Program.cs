// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, World!");

CommandCentre centre = new CommandCentre();

Runway[] runways = { new Runway(centre), new Runway(centre)};
Aircraft[] aircrafts =
    {
        new Aircraft("First Aircraft", centre),
        new Aircraft("Second Aircraft", centre),
        new Aircraft("Third Aircraft", centre)
    };


centre.SetUp(runways, aircrafts);

aircrafts[0].TakeOff();
Console.WriteLine();
aircrafts[0].Land(runways[0].Id);
Console.WriteLine();
aircrafts[1].Land(runways[0].Id);

Console.WriteLine();
aircrafts[2].Land(runways[1].Id);

