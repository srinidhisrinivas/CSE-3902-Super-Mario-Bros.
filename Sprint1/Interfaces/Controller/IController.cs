using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CSE3902
{
    public interface IController
    {        
        void Update(GameTime gameTime);

    }
}
