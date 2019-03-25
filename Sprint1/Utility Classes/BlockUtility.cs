using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class BlockUtility
    {
        

        public readonly static float blockGravity = 0f;
        public readonly static float blockBumpVelocity = -5f;
        public readonly static float blockBumpAcceleration = 7f;
        public readonly static float topBrickYVelocity = -4f;
        public readonly static float bottomBrickYVelocity = -3f;
        public readonly static float bottomBrickLeftVelocity = -1f;
        public readonly static float bottomBrickRightVelocity = 1f;
        public readonly static float topBrickLeftVelocity = -2f;
        public readonly static float topBrickRightVelocity = 2f;
        public readonly static int brickOffset = 16;
        public readonly static int multipleCoinCount = 12;
        public readonly static int flagWidth = 32;
        public readonly static int flagpoleHeight = 254;
        public readonly static Vector2 fireBarNewLocation = new Vector2(8, -8);
        public readonly static int zeroCheck = 0;
        public readonly static int radius16 = 16;
        public readonly static int eight = 8;
        public readonly static int two = 2;
        public readonly static Vector2 platformSpriteFrameSource = new Vector2(143, 54);
        public readonly static int one = 1;
        public readonly static int platformXlocation = 32;
        public readonly static int platformYlocation = 8;
        public readonly static float platformInitialVelocity = 2f;
        public readonly static int platformRange= 200;
        public readonly static float platformChangeDirectrion = -1f;
        public readonly static Vector2 lavaBlockSpriteFrameSource = new Vector2(622, 462);
        public readonly static int lavaBlockXlocation = 16;
        public readonly static int lavaBlockYlocation = 16;
        public readonly static Vector2 lavaSurfaceSpriteFrameSource = new Vector2(622, 449);
        public readonly static int lavaSurfaceXlocation = 16;
        public readonly static int lavaSurfaceYlocation = 11;
        public readonly static Vector2 bridgeLinkSpriteFrameSource = new Vector2(576, 468);
        public readonly static int bridgeLinkXlocation = 4;
        public readonly static int bridgeLinkYlocation = 16;
        public readonly static Vector2 axeSpriteFrameSource = new Vector2(575, 430);
        public readonly static int axeXlocation = 16;
        public readonly static int axeYlocation = 16;
        public readonly static float axeFrameOffset = 19f;
        public readonly static int three = 3;
        public readonly static int marioRunRight = 150;
        public readonly static Vector2 leftFacingBowserSpriteFrameSource = new Vector2(13, 896);
        public readonly static int leftFacingBowserXlocation = 32;
        public readonly static int leftFacingBowserYlocation = 32;
        public readonly static float leftFacingBowserFrameOffset = 40f;
        public readonly static int four = 4;
        public readonly static Vector2 rightFacingBowserSpriteFrameSource = new Vector2(13, 896);
        public readonly static int rightFacingBowserXlocation = 32;
        public readonly static int rightFacingBowserYlocation = 32;
        public readonly static float rightFacingBowserFrameOffset = 40f;
        public readonly static Vector2 bowserFireballSpriteFrameSource = new Vector2(56, 938);
        public readonly static int bowserFireballXlocation = 24;
        public readonly static int bowserFireballYlocation = 8;
        public readonly static float bowserFireballFrameOffset = 30f;
        public readonly static int bowserHealthPotion = 2000;
        public readonly static float bowserYAcceleration = 0.3f;
        public readonly static int bowserHealthPotionDamage = 200;
        public readonly static float leftMovingBowserXVelocity = -0.5f;
        public readonly static float leftMovingBowserYVelocity = -7f;
        public readonly static String BowserFire = "BowserFire";
        public readonly static float rightMovingBowserXVelocity = 0.5f;
        public readonly static float StationaryLeftFacingBowserYVelocity = -7f;
        public readonly static Vector2 deadGrayGoombaSpriteFrameSource = new Vector2(310, 894);
        public readonly static int deadGrayGoombaXlocation = 16;
        public readonly static int deadGrayGoombaYlocation = 16;
        public readonly static int fireballTimer = 50;
        public readonly static int sixteen = 16;
        public readonly static int six = 6;
        public readonly static int marioLocation104 = 104;
        public readonly static int marioYLocation200 = 200;
        public readonly static int bowserYLocation480 = 480;
        public readonly static int bowserXLocation126 = 126;
        public readonly static float bowserFireballYAcceleration = 0f;
        public readonly static float projectileXVelocity = -3f;
        public readonly static int fifty = 50;
        public readonly static int next255 = 255;







        public readonly static float suspendedGravity = 0f;

    }
}
