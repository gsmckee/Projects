using System;

abstract public class Munitions
{
    protected static int gravity = -1;
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
    virtual public void moveObj()
    {
    }
}
