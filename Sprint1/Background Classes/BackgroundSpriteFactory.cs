using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BackgroundSpriteFactory
    {
        private Texture2D backgroundSpritesheet;


        public static BackgroundSpriteFactory Instance { get; } = new BackgroundSpriteFactory();
       
        private BackgroundSpriteFactory() {
        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            backgroundSpritesheet = content.Load<Texture2D>("misc-3");
            
        }

        public ISprite CreateLittleCloudSprite()
        {
            return new LittleCloudSprite(backgroundSpritesheet);
        }

        public ISprite CreateBigCloudSprite()
        {
            return new BigCloudSprite(backgroundSpritesheet);
        }
        public ISprite CreateMediumCloudSprite()
        {
            return new MediumCloudSprite(backgroundSpritesheet);
        }
        public ISprite CreateBigHillSprite()
        {
            return new BigHillSprite(backgroundSpritesheet);
        }
        public ISprite CreateLittleHillSprite()
        {
            return new LittleHillSprite(backgroundSpritesheet);
        }
        public ISprite CreateBigBushSprite()
        {
            return new BigBushSprite(backgroundSpritesheet);
        }
        public ISprite CreateLittleBushSprite()
        {
            return new LittleBushSprite(backgroundSpritesheet);
        }
        public ISprite CreateMediumBushSprite()
        {
            return new MediumBushSprite(backgroundSpritesheet);
        }
        public ISprite CreateCastleSprite()
        {
            return new CastleSprite(backgroundSpritesheet);
        }
    }
}
