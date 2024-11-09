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
    /// Interaction logic for VHGrid.xaml
    /// </summary>
    public partial class VHGrid : UserControl, IVHContainer
    {
        private GridDirection? Direction;

        public VHGrid()
        {
            InitializeComponent();
        }

        private void Grid_Drop(object sender, DragEventArgs e)
        {

        }

        public VHGrid AddGridSegment()
        {
            var numChildren = BaseGrid.Children.Count;

            if (numChildren > 0)
            {
                BaseGrid.Children.Add(new GridSplitter());
            }

            var idx = BaseGrid.Children.Add(new VHGrid());
            return (VHGrid)BaseGrid.Children[idx];
        }

        public bool AddControl(UIElement elt)
        {
            var container = GetActiveContainer();
            if(container is VHTabbed tabbed)
            {
                tabbed.AddControl(elt);
            } else if (container is VHGrid grid)
            {
                grid.AddControl(elt);
            } else
            {
                tabbed = new VHTabbed();
                tabbed.AddControl(elt);
                BaseGrid.Children.Add(tabbed);
            }

            return true;
        }

        public bool RemoveControl(UIElement control)
        {
            throw new NotImplementedException();
        }

        private object? GetActiveContainer()
        {
            var idx = BaseGrid.Children.Count > 0 ? 0 : -1;
            return idx >= 0 ? BaseGrid.Children[idx] : null;
        }

        public void SetDirect(GridDirection direction)
        {
            if(Direction == null || Direction == direction)
            {
                Direction = direction;  
            } else
            {
                //Reorganize
                throw new NotImplementedException();
            }
        }

        public enum GridDirection
        {
            VH_HORIZONTAL,
            VH_VERTICAL,
        }
    }
}
