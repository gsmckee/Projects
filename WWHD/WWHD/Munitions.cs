using System;

abstract public class Munitions
{
    protected const int gravity = -1;
    public float X, Y, VelX, VelY, Ax, Ay, adx, ady;
    public double Angle, AngleV;
    public float mass;
    public const float agx = 0f;
    public float agy = -9.8f;
    public float frontalArea = 1f;
    public float coefDrag = 0.1f;
    public const float rho = 1.2754f;
    //protected Enum Shape;
	protected Munitions()
	{
	}
    public Munitions(int x, int y, int mass, double angle, double angleV)
    {
        this.X = x;
        this.Y = y;
        this.VelX = 10;
        this.VelY = 10;
        this.Angle = angle;
        this.AngleV = angleV;
        this.mass = mass;
    }
    virtual public void moveObj(float timeStep)
    {        
        calcAirDrag();
        Ax = agx + adx;
        Ay = agy + ady;
        VelX += Ax * timeStep;
        VelY += Ay * timeStep;

        if (Y < 0 && VelY < 0)
        {
            VelY *= -0.5f;
        }


        X += VelX * timeStep;
        Y += VelY * timeStep;
        Angle += AngleV * timeStep;
    }
    virtual public void calcAirDrag()
    {
        
        adx = ((coefDrag * rho * (VelX * VelX) * frontalArea) / 2) / mass;
        if(VelX > 0)
        {
            adx = adx * -1;
        }
        ady = ((coefDrag * rho * (VelY * VelY) * frontalArea) / 2) / mass;
        if(VelY > 0)
        {
            ady = ady * -1;
        }
    }
}
