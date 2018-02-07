using System;

public class Vehicle
{

    protected int NumWheels;
    protected int Horsepower;
    protected int Weight;

    public Vehicle()
	{
        NumWheels = 0;
        Horsepower = 0;
        Weight = 0;
	}
    public Vehicle(int numWheels, int hp, int weight)
    {
        NumWheels = numWheels;
        Horsepower = hp;
        Weight = weight;
    }
    public Vehicle(Vehicle V)
    {
        NumWheels = V.NumWheels;
        Horsepower = V.Horsepower;
        Weight = V.Weight;
    }
    public void DisplayInformation()
    {
        Console.WriteLine("# of wheels: " + NumWheels);
        Console.WriteLine("HP: " + Horsepower);
        Console.WriteLine("Weight: " + Weight);
    }
    public override string ToString()
    {
        string info = "The number of wheels: " + NumWheels 
            + "\r\n Horsepower: " + Horsepower 
            + "\r\n Weight: " + Weight;
        return info;
    }
}
