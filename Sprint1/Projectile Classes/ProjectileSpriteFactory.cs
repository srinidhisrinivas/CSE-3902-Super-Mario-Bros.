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
    public class ProjectileSpriteFactory
    {
        
        private Texture2D projectileSpritesheet;
        
        public static ProjectileSpriteFactory Instance { get; } = new ProjectileSpriteFactory();
        

        private ProjectileSpriteFactory() {
        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            projectileSpritesheet = content.Load<Texture2D>("misc-3");
            

        }


        public ISprite CreateInactiveFireballSprite()
        {
            return new InactiveFireballSprite(projectileSpritesheet);
        }
        public ISprite CreateActiveFireballSprite()
        {
            return new ActiveFireballSprite(projectileSpritesheet);
        }
        public ISprite CreateBowserFireballSprite()
        {
            return new BowserFireballSprite(projectileSpritesheet);
        }
        public ISprite CreateRightRedBrickSprite()
        {
            return new RightRedBrickSprite(projectileSpritesheet);
        }
        public ISprite CreateLeftRedBrickSprite()
        {
            return new LeftRedBrickSprite(projectileSpritesheet);
        }
        public ISprite CreateRightBlueBrickSprite()
        {
            return new RightBlueBrickSprite(projectileSpritesheet);
        }
        public ISprite CreateLeftBlueBrickSprite()
        {
            return new LeftBlueBrickSprite(projectileSpritesheet);
        }
        public ISprite CreateWhiteFlagSprite()
        {
            return new WhiteFlagSprite(projectileSpritesheet);
        }
    }
}
