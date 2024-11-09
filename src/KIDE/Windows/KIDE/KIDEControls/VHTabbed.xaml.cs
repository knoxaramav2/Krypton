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
    /// Interaction logic for VHTabbed.xaml
    /// </summary>
    public partial class VHTabbed : UserControl, IVHContainer
    {
        public VHTabbed()
        {
            InitializeComponent();
        }

        private void TabControl_Drop(object sender, DragEventArgs e)
        {

        }

        public bool AddControl(UIElement child) => AddControl(child, "New Item");

        public bool AddControl(UIElement child, string tabTitle)
        {
            var tab = new TabItem
            {
                Header = tabTitle,
                Content = child,
            };
            TabBase.Items.Add(tab);
            return true;
        }

        public bool RemoveControl(UIElement control)
        {
            throw new NotImplementedException();
        }
    }
}
