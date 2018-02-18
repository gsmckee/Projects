using System;

public class Munitions
{
    protected int X;
    protected int Y;
    protected int VX;
    protected int VY;
    protected int Mass;
    protected double Angle;

	protected Munitions()
	{
        X = 0;
        Y = 0;
        VX = 0;
        VY = 0;
	}
    // Basic Constructor
    public Munitions(int x, int y, int vX, int vY, double angle)
    {
        this.X = x;
        this.Y = y;
        this.VX = vX;
        this.VY = vY;
        this.Angle = angle;
    }
}
