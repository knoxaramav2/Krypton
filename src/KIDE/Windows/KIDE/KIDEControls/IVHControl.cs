using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KIDEControls
{
    public interface IVHControl
    {
        
    }

    public interface IVHContainer: IVHControl
    {
        public bool AddControl(UIElement control);
        public bool RemoveControl(UIElement control);
    }
}
