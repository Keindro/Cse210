using System;

public class Cycling : Activity
{
    private double _speed;  //mph

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return ((_speed * _minutes) / 60);
    }
    public override double Speed()
    {
        return _speed;
    }

}