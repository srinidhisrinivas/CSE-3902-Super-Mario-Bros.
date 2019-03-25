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
    public class EnemySpriteFactory
    {
        private Texture2D goombaSpritesheet;
        private Texture2D koopaSpritesheet;
        private Texture2D bowserSpritesheet;



        public static EnemySpriteFactory Instance { get; } = new EnemySpriteFactory();
       
        private EnemySpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException(EnemyStateUtility.content);
            }
            goombaSpritesheet = content.Load<Texture2D>(EnemyStateUtility.enemySpritesheet);
            koopaSpritesheet = content.Load<Texture2D>(EnemyStateUtility.enemySpritesheet);
            bowserSpritesheet = content.Load<Texture2D>(EnemyStateUtility.enemySpritesheet);
        }

        public ISprite CreateGoombaSprite()
        {
            return new GoombaSprite(goombaSpritesheet);
        }
        public ISprite CreateDeadGoombaSprite()
        {
            return new DeadGoombaSprite(goombaSpritesheet);
        }
        public ISprite CreateDeadGrayGoombaSprite()
        {
            return new DeadGrayGoombaSprite(goombaSpritesheet);
        }
        public ISprite CreateLeftBowserSprite()
        {
            return new LeftFacingBowserSprite(bowserSpritesheet);
        }
        public ISprite CreateRightBowserSprite()
        {
            return new RightFacingBowserSprite(bowserSpritesheet);
        }
        public ISprite CreateStompedGoombaSprite()
        {
            return new StompedGoombaSprite(goombaSpritesheet);
        }

        public ISprite CreateLeftKoopaSprite()
        {
            return new LeftKoopaSprite(koopaSpritesheet);
        }
        public ISprite CreateRightKoopaSprite()
        {
            return new RightKoopaSprite(koopaSpritesheet);
        }
        public ISprite CreateStompedKoopaSprite()
        {
            return new StompedKoopaSprite(koopaSpritesheet);
        }
        public ISprite CreateDeadKoopaSprite()
        {
            return new DeadKoopaSprite(koopaSpritesheet);
        }
        public ISprite CreateEmptySprite()
        {
            return new EmptySprite(goombaSpritesheet);
        }
    }
}
