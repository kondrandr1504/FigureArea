using System;
using Xunit;

namespace FigureShape.Tests
{
  public class CompareArea
  {
    /// <summary>
    /// Тестирование площадей фигур
    /// </summary>
    [Fact]
    public void Compare()
    {
      var circleFigure = PrepateData("Circle");
      Assert.Equal((decimal)314, Math.Round((decimal)circleFigure.Calculate(), 2));

      var triangleFigure = PrepateData("Triangle");
      Assert.Equal((0.5 * 5 * 12), triangleFigure.Calculate());

      var reactangleFigure = PrepateData("Rectangle");
      Assert.Equal(5 * 12, reactangleFigure.Calculate());
    }

    #region PrepareData
    /// <summary>
    /// Метод по выбору типа фигуры
    /// </summary>
    /// <param name="figureForm">Название типа фигуры</param>
    public FigureContext PrepateData(string figureForm)
    {
      FigureContext figure = new FigureContext();
      var a = 5.0;
      var b = 12.0;
      var c = 13.0;
      var r = 10.0;

      switch (figureForm)
      {
        case "Circle":
          figure.SetFigure(new CircleArea(r));
          break;
        case "Rectangle":
          figure.SetFigure(new RectangleArea(a, b));
          break;
        case "Triangle":
          figure.SetFigure(new TriangleArea(a, b, c));
          break;
      }

      return figure;
    }
    #endregion
  }
}