using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class MarioUtility
    {
        public readonly static int timerElapse = 0;
        public readonly static int minColor = 0;
        public readonly static int maxColor = 255;
        public readonly static int decoratorTimer= 120;
        public readonly static int invincibleMarioSpriteFrames = 5;
        public readonly static int zero = 0;
        public readonly static float pipeTransitionMarioYAcceleration = 0f;
        public readonly static int pipeTransitionMariodecoratorTimer = 85;
        public readonly static int starMariodecoratorTimer = 700;
        public readonly static int magicMariodecoratorTimer = 1100;
        public readonly static int starMarioreminder = 10;
        public readonly static int stompChainInit = 0;
        public readonly static int marioYLocation = 480;
        public readonly static Vector2 marioLocation = new Vector2(0, 2);
        public readonly static Vector2 marioLocation360 = new Vector2(34, 0);
        public readonly static float marioYVelocity = -8f;
        public readonly static string characterTexture = "characters";
        public readonly static float marioXVelocity = 0f;
        public readonly static float marioYAcceleration = 0.23f;
        public readonly static int stateTimerZero = 0;
        public readonly static int bigMarioLeftFlagPoleTimer = 50;
        public readonly static int fireMarioLeftFlagPoleTimer = 50;
        public readonly static int marioYLocation360 = 360;
        public readonly static int smallMarioLeftFlagPoleTimer = 50;
        public readonly static int transitionMarioStateTimer = 70;
        public readonly static int transitionMarioSpriteFrames = 14;
        public readonly static int deadMarioTimer = 70;
        public readonly static int deadMarioYAcceleration = 0;
        public readonly static int movingMarioYAcceleration = 1;
        public readonly static float deadMarioYVelocity = -15f;
        public readonly static float screenYLimit = 520;
        public readonly static Vector2 jumpingMarioDisplacement = new Vector2(2, 0);
        public readonly static float runningVelocityFactor = 1.6f;
        public readonly static int marioLeftXVelocity = -3;
        public readonly static int marioRightXVelocity = 3;
        public readonly static int flagPoleMarioYVelocity = 2;
        public readonly static string marioDie = "MarioDie";
        public readonly static int leftFlagPoleMarioStateTimer = 50;
        public readonly static int leftFlagPoleMarioXVelocity = 2;
        public readonly static int autoRightRunStateTimer = 100;

    }
}
