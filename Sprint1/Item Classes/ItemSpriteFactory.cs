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
    public class ItemSpriteFactory
    {
        private Texture2D coinSpritesheet;
        private Texture2D stillCoinSpritesheet;
        private Texture2D axeSpritesheet;
        private Texture2D flowerSpritesheet;
        private Texture2D starSpritesheet;
        private Texture2D redMushroomSpritesheet;
        private Texture2D greenMushroomSpritesheet;
        private Texture2D magicMushroomSpritesheet;


        public static ItemSpriteFactory Instance { get; } = new ItemSpriteFactory();
       
        private ItemSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            coinSpritesheet = content.Load<Texture2D>("items");
            stillCoinSpritesheet = content.Load<Texture2D>("misc-3");
            axeSpritesheet = content.Load<Texture2D>("misc-3");
            flowerSpritesheet = content.Load<Texture2D>("items");
            starSpritesheet = content.Load<Texture2D>("items");
            redMushroomSpritesheet = content.Load<Texture2D>("items");
            greenMushroomSpritesheet = content.Load<Texture2D>("items");
            magicMushroomSpritesheet = content.Load<Texture2D>("items");

        }

        public ISprite CreateSpinningCoinSprite()
        {
            return new SpinningCoinSprite(coinSpritesheet);
        }
        public ISprite CreateStationaryCoinSprite()
        {
            return new StationaryCoinSprite(stillCoinSpritesheet);
        }
        public ISprite CreateAxeSprite()
        {
            return new AxeSprite(axeSpritesheet);
        }

        public ISprite CreateFlowerSprite()
        {
            return new FlowerSprite(flowerSpritesheet);
        }
        public ISprite CreateStarSprite()
        {
            return new StarSprite(starSpritesheet);
        }
        public ISprite CreateRedMushroomSprite()
        {
            return new RedMushroomSprite(redMushroomSpritesheet);
        }
        public ISprite CreateMagicMushroomSprite()
        {
            return new MagicMushroomSprite(magicMushroomSpritesheet);
        }
        public ISprite CreateGreenMushroomSprite()
        {
            return new GreenMushroomSprite(greenMushroomSpritesheet);
        }
        public ISprite CreateEmptySprite()
        {
            return new EmptySprite(flowerSpritesheet);
        }
    }
}
