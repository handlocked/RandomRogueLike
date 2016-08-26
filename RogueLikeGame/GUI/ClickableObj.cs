using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame.GUI
{
    class ClickableObj
    {
        public delegate void MouseClick();
        public event MouseClick Click;
        public void EventFired()
        {

        }
    }
}
