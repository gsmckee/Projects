using System;

public class Munitions
{
    protected int X, Y, VelX, VelY;
    protected double Angle;
    protected Enum Shape;
	public Munitions()
	{
	}
    public Munitions(int x, int y, double angle)
    {
        this.X = x;
        this.Y = y;
        this.VelX = 1;
        this.VelY = 1;
        this.Angle = angle;
    }
    public void moveObj()
    {
        X = X + VelX;
        Y = Y + VelY;
    }
    public void gravity()
    {
        Y = VelY - 1;
    }
}
