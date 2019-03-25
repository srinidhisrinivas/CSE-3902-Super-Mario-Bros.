using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class MarioSpriteFactory
    {
        private Texture2D smallMarioSpritesheet;
        private Texture2D bigMarioSpritesheet;
        private Texture2D fireMarioSpritesheet;
        private Texture2D deadMarioSpritesheet;


        public static MarioSpriteFactory Instance { get; } = new MarioSpriteFactory();
        
        private MarioSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            smallMarioSpritesheet = content.Load<Texture2D>(MarioUtility.characterTexture);
            bigMarioSpritesheet = content.Load<Texture2D>(MarioUtility.characterTexture);
            fireMarioSpritesheet = content.Load<Texture2D>(MarioUtility.characterTexture);
            deadMarioSpritesheet = content.Load<Texture2D>(MarioUtility.characterTexture);

        }

        public ISprite CreateSmallMarioLeftIdleSprite()
        {
            return new SmallMarioLeftIdleSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioRightIdleSprite()
        {
            return new SmallMarioRightIdleSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioLeftRunSprite()
        {
            return new SmallMarioLeftRunSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioRightRunSprite()
        {
            return new SmallMarioRightRunSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioLeftJumpSprite()
        {
            return new SmallMarioLeftJumpSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioRightJumpSprite()
        {
            return new SmallMarioRightJumpSprite(smallMarioSpritesheet);
        }

        public ISprite CreateBigMarioLeftIdleSprite()
        {
            return new BigMarioLeftIdleSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioRightIdleSprite()
        {
            return new BigMarioRightIdleSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioLeftRunSprite()
        {
            return new BigMarioLeftRunSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioRightRunSprite()
        {
            return new BigMarioRightRunSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioLeftJumpSprite()
        {
            return new BigMarioLeftJumpSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioRightJumpSprite()
        {
            return new BigMarioRightJumpSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioLeftCrouchSprite()
        {
            return new BigMarioLeftCrouchSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioRightCrouchSprite()
        {
            return new BigMarioRightCrouchSprite(bigMarioSpritesheet);
        }

        public ISprite CreateFireMarioLeftIdleSprite()
        {
            return new FireMarioLeftIdleSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioRightIdleSprite()
        {
            return new FireMarioRightIdleSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioLeftRunSprite()
        {
            return new FireMarioLeftRunSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioRightRunSprite()
        {
            return new FireMarioRightRunSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioLeftJumpSprite()
        {
            return new FireMarioLeftJumpSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioRightJumpSprite()
        {
            return new FireMarioRightJumpSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioLeftCrouchSprite()
        {
            return new FireMarioLeftCrouchSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioRightCrouchSprite()
        {
            return new FireMarioRightCrouchSprite(fireMarioSpritesheet);
        }

        public ISprite CreateDeadMarioSprite()
        {
            return new DeadMarioSprite(deadMarioSpritesheet);
        }


        public ISprite CreateFireMarioLeftFlagpoleSprite()
        {
            return new FireMarioLeftFlagpoleSprite(fireMarioSpritesheet);
        }

        public ISprite CreateFireMarioRightFlagpoleSprite()
        {
            return new FireMarioRightFlagpoleSprite(fireMarioSpritesheet);
        }

        public ISprite CreateBigMarioLeftFlagpoleSprite()
        {
            return new BigMarioLeftFlagpoleSprite(bigMarioSpritesheet);
        }

        public ISprite CreateBigMarioRightFlagpoleSprite()
        {
            return new BigMarioRightFlagpoleSprite(bigMarioSpritesheet);
        }

        public ISprite CreateSmallMarioLeftFlagpoleSprite()
        {
            return new SmallMarioLeftFlagpoleSprite(smallMarioSpritesheet);
        }

        public ISprite CreateSmallMarioRightFlagpoleSprite()
        {
            return new SmallMarioRightFlagpoleSprite(smallMarioSpritesheet);
        }


    }
}
