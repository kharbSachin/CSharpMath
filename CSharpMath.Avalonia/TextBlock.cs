using System;

using Avalonia;
using Avalonia.Media;
using AvaloniaTextBlock = Avalonia.Controls.TextBlock;

using CSharpMath.Rendering;

namespace CSharpMath.Avalonia {
  public class TextBlock : AvaloniaTextBlock {
    private readonly TextPainter _painter;

    public TextBlock() {
      _painter = new TextPainter();

      this.GetObservable(FontFamilyProperty).Subscribe(UpdateTypeface);
      this.GetObservable(FontSizeProperty).Subscribe(v => _painter.FontSize = (float)v);

      this.GetObservable(ForegroundProperty).Subscribe(
        v => _painter.TextColor = (v as ISolidColorBrush)?.Color ?? default);

      this.GetObservable(TextProperty).Subscribe(v => _painter.Source = new TextSource(v));
    }

    public override void Render(DrawingContext context) =>
        _painter.Draw(new AvaloniaCanvas(context, Bounds.Size));

    protected override Size MeasureOverride(Size availableSize) {
      var measure = _painter.Measure((float)availableSize.Width);

      if (measure.HasValue) {
        return new Size(measure.Value.Width, measure.Value.Height);
      }

      return default;
    }

    private void UpdateTypeface(FontFamily obj) {
      //throw new NotImplementedException();
    }
  }
}