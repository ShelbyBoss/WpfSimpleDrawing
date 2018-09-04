using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSimpleDrawing
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawControl_Paint(object sender, DrawingContext e)
        {
            DrawControl control = sender as DrawControl;

            Pen pen = new Pen(Brushes.Green, 5);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(control.ActualWidth, control.ActualHeight);

            e.DrawLine(pen, point1, point2);
        }

        private void DrawControl_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
