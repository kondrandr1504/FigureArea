namespace FigureShape
{
  public class FigureContext
  {
    private IFigureArea _figure = default!;

    public FigureContext()
    {
    }

    public void SetFigure(IFigureArea figure)
    {
      _figure = figure;
    }

    public double Calculate()
    {
      try
      {
        return _figure.AreaCalculate();
      }
      catch (NullReferenceException ex)
      {
        Console.WriteLine(ex);
      }
      return default;
    }
  }
}