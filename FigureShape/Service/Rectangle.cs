namespace FigureShape
{
  /// <summary>
  /// Вычисление площади прямоугольника
  /// </summary>
  public class RectangleArea : IFigureArea
  {
    private readonly double _a;
    private readonly double _b;

    public RectangleArea(double a, double b)
    {
      _a = a;
      _b = b;
    }

    /// <summary>
    /// Площадь прямоугольника
    /// </summary>
    public double AreaCalculate()
    {
      return _a * _b;
    }

  }
}