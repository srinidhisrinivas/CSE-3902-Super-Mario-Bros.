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
    public class BlockSpriteFactory
    {
        private Texture2D objectSpritesheet;
        private Texture2D pipeSpritesheet;

        public static BlockSpriteFactory Instance { get; } = new BlockSpriteFactory();
       
        private BlockSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            objectSpritesheet = content.Load<Texture2D>("misc-3");
            pipeSpritesheet = content.Load<Texture2D>("misc-2");
        }

        public ISprite CreateRedBrickBlockSprite()
        {
            return new RedBrickBlockSprite(objectSpritesheet);
        }

        public ISprite CreateRedCrackedBlockSprite()
        {
            return new RedCrackedBlockSprite(objectSpritesheet);
        }
        public ISprite CreateBlueBrickBlockSprite()
        {
            return new BlueBrickBlockSprite(objectSpritesheet);
        }
        public ISprite CreateHellBlockSprite()
        {
            return new HellBlockSprite(objectSpritesheet);
        }
        public ISprite CreateBridgeLinkSprite()
        {
            return new BridgeLinkSprite(objectSpritesheet);
        }
        public ISprite CreateLavaBlockSprite()
        {
            return new LavaBlockSprite(objectSpritesheet);
        }
        public ISprite CreateLavaSurfaceSprite()
        {
            return new LavaSurfaceSprite(objectSpritesheet);
        }

        public ISprite CreateBlueCrackedBlockSprite()
        {
            return new BlueCrackedBlockSprite(objectSpritesheet);
        }

        public ISprite CreateHardBlockSprite()
        {
            return new HardBlockSprite(objectSpritesheet);
        }


        public ISprite CreateHiddenBlockSprite()
        {
            return new HiddenBlockSprite(objectSpritesheet);
        }
        public ISprite CreateEmptySprite()
        {
            return new EmptySprite(objectSpritesheet);
        }

        public ISprite CreateQuestionBlockSprite()
        {
            return new QuestionBlockSprite(objectSpritesheet);
        }

        public ISprite CreateUsedBlockSprite()
        {

            return new UsedBlockSprite(objectSpritesheet);
        }

        public ISprite CreateShortPipeSprite()
        {
            return new ShortPipeSprite(pipeSpritesheet);
        }
        public ISprite CreateMediumPipeSprite()
        {
            return new MediumPipeSprite(pipeSpritesheet);

        }
        public ISprite CreateTallPipeSprite()
        {
            return new TallPipeSprite(pipeSpritesheet);
        }
        
        public ISprite CreateAscensionPipeSprite()
        {
            return new AscensionPipeSprite(objectSpritesheet);
        }
        public ISprite CreateLeftPipeSprite()
        {
            return new LeftPipeSprite(pipeSpritesheet);
        }
        public ISprite CreateFlagpoleSprite()
        {
            return new FlagpoleSprite(objectSpritesheet);
        }
        public ISprite CreatePlatformSprite()
        {
            return new PlatformSprite(objectSpritesheet);
        }




    }
}
