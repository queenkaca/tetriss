using System;

abstract public class Figura
{
    abstract int[,,] figura;
    int x;
    int y;

    public Figura(int[,,] figura, int x, int y)
    {

    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }
}
