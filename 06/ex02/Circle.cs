record Circle
(
    double Radius
) : Shape (Radius * 2, Radius * 2)
{
    public sealed override double Area => Radius * Radius * Math.PI;
}