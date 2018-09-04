using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfSimpleDrawing
{
    class DrawControl : UserControl
    {
        public event EventHandler<DrawingContext> Paint;

        protected override void OnRender(DrawingContext drawingContext)
        {
            Paint?.Invoke(this, drawingContext);
        }
    }
}