using System;

public class Munitions
{
    protected int Mass;
    protected double Angle;

	protected Munitions()
	{
        Mass = 0;
        Angle = 0;
	}
    // Basic Constructor
    public Munitions(int mass, double angle)
    {
        this.Mass = mass;
        this.Angle = angle;
    }
}
