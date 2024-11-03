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

namespace KIDEControls
{
    /// <summary>
    /// Interaction logic for VHSplit.xaml
    /// </summary>
    public partial class VHSplit : UserControl
    {
        public VHSplit()
        {
            InitializeComponent();
        }

        private void DockPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(UIElement)))
            {
                var dropElt = e.Data.GetData(typeof(UIElement)) as UIElement;
                if(dropElt != null)
                {
                    var pos = e.GetPosition(DockBase);
                    var dock = GetDockPos(pos);

                    DockPanel.SetDock(dropElt, dock);
                    DockBase.Children.Add(dropElt);
                }
            }
        }

        private Dock GetDockPos(Point pos)
        {
            double w = DockBase.ActualWidth;
            double h = DockBase.ActualHeight;

            if(pos.X < w / 4)
            {
                return Dock.Left;
            } else if (pos.X > 3 * w / 4)
            {
                return Dock.Right;
            } else if (pos.Y > 3 * h / 4)
            {
                return Dock.Bottom;
            } else
            {
                return Dock.Top;
            }
        }
    }
}
