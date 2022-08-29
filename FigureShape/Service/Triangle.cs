namespace FigureShape
{
  /// <summary>
  /// Вычисление площади треугольника
  /// </summary>
  public class TriangleArea : IFigureArea
  {
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public TriangleArea(double a, double b, double c)
    {
      _a = a;
      _b = b;
      _c = c;
    }

    /// <summary>
    /// Площадь треугольника
    /// </summary>
    public double AreaCalculate()
    {
      if (Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2))
      {
        return 0.5 * _a * _b;
      }

      var p = (_a + _b + _c) / 2;
      return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

  }
}