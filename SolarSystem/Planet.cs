using System;
using System.Text.Json;
using SolarSystem;

public class Planet
{
    public static void CompletedRotation() { }
    public static void CompletedRotation(Planet planet)
    {
        planet.Rotate();
        CompletedRotation();
    }

    public double Diameter { get; set; }
    public string? Composition { get; set; }    
    public double Mass { get; set; }


    public Planet(double diameter, string? composition, double mass)
    {
        Diameter = diameter;
        Composition = composition;
        Mass = mass;
    }
    protected virtual void Rotate() { }
}
