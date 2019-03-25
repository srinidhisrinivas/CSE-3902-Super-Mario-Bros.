using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class HeaderText : HUDElement
    {
        
        public HeaderText(ITextContent textContent, Vector2 location) : base(textContent, location)
        {
            this.font = FontFactory.Instance.CreateHeaderFont();
        }
       
    }
}
