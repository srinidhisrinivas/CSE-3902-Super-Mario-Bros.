using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class ItemUtility
    {

        public readonly static float coinVelocity = -13f;
        public readonly static int coinDisappearHeight = 40;
        public readonly static int fireballTimer = 30;
        public readonly static int flagThresholdLocation = 270;


        public readonly static Vector2 coinBlockDisplacement = new Vector2(8, 0);

        public readonly static float starBounceVelocity = -14f;
        public readonly static float fireballBounceVelocity = -8f;
        public readonly static float fireballYVelocity = 2f;
        public readonly static float fireballXVelocity = 6f;
        public readonly static float fireballLocation = 2f;
        public readonly static float flagVelocity = 2f;




        public readonly static float starXVelocity = 3f;
        public readonly static Vector2 emergingItemDisplacement = new Vector2(0, 0.5f);









    }
}
