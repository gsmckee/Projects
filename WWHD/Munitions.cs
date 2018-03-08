using System;

public class Munitions
{
    protected int Mass, VelX, VelY;
    protected double Angle;

	protected Munitions()
	{
        Mass = 0;
        Angle = 0;
	}
    // Basic Constructor
    public Munitions(int mass, double angle, int velX, int velY)
    {
        this.VelX = velX;
        this.VelY = velY;
        this.Mass = mass;
        this.Angle = angle;
    }
}
