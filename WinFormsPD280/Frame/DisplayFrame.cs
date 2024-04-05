using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280.Frame
{
    class DisplayFrame : IDisaplyFrame
    {

        public List<IItem> items;

        public DisplayFrame() 
        {

        }
        public void DisplayMyself(DisplayManager displayManager)
        {
            throw new NotImplementedException();
        }
    }
}
