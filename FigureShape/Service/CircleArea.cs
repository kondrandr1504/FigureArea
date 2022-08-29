namespace FigureShape
{
  /// <summary>
  /// Вычисление площади круга
  /// </summary>
  public class CircleArea : IFigureArea
  {
    private readonly double _r;

    public CircleArea(double r)
    {
      _r = r;
    }

    /// <summary>
    /// Площадь круга
    /// </summary>
    public double AreaCalculate()
    {
      return Math.PI * Math.Pow(_r, 2);
    }

  }
}