using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpControlWork
{
    class Button
    {
        public delegate void ClickHandler();

        public event ClickHandler OnClick;

        public void Click()
        {
            if (OnClick != null) OnClick();
        }
    }
}
