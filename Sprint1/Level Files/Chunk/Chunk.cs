using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Chunk
    {
        public IList<IBlock> ListOfGameBlocks { get; }
        public IList<IEnemy> ListOfGameEnemies { get; }
        public IList<IItem> ListOfGameItems { get; }
        public IList<IProjectile> ListOfGameProjectiles { get; }
        public IList<IBackgroundObject> ListOfBackgroundItems { get; }
        public IList<IHUDElement> ListOfHUDElements { get; }
        public IList<FireBar> ListOfGameFireBars { get; }
        public Chunk()
        {
            ListOfBackgroundItems = new List<IBackgroundObject>();
            ListOfGameEnemies = new List<IEnemy>();
            ListOfGameBlocks = new List<IBlock>();
            ListOfGameItems = new List<IItem>();
            ListOfGameProjectiles = new List<IProjectile>();
            ListOfHUDElements = new List<IHUDElement>();
            ListOfGameFireBars = new List<FireBar>();

        }
        public static int GetChunkHashValue(int xLocation, int chunkSize, int numChunks)
        {
            int chunkNum = xLocation / chunkSize;
            if(chunkNum < 0)
            {
                chunkNum = 0;
            }
            if(chunkNum >= numChunks)
            {
                chunkNum = numChunks - 1;
            }
            return chunkNum;
        }
        public void Update(GameTime gameTime)
        {
            
            foreach (IEnemy enemy in ListOfGameEnemies)
            {
                enemy.Update(gameTime);
            }
            foreach (IItem item in ListOfGameItems)
            {
                item.Update(gameTime);
            }
            foreach (IBlock block in ListOfGameBlocks)
            {
                block.Update(gameTime);
            }
            foreach (IProjectile projectile in ListOfGameProjectiles)
            {
                projectile.Update(gameTime);
            }
            foreach(IHUDElement element in ListOfHUDElements)
            {
                element.Update(gameTime);
            }
            foreach (FireBar firebar in ListOfGameFireBars)
            {
                firebar.Update(gameTime);
            }

        }
        public bool IsActive(ICamera camera)
        {
            foreach (IBlock block in this.ListOfGameBlocks)
            {
                if (camera.HasEntityInView(block))
                {
                    return true;
                }
            }
            foreach (IEnemy enemy in this.ListOfGameEnemies)
            {
                
                if (camera.HasEntityInView(enemy) || enemy is Bowser)
                {
                    return true;
                }
            }
            foreach (IItem item in this.ListOfGameItems)
            {
                if (camera.HasEntityInView(item))
                {
                    return true;
                }
                
            }
            foreach (FireBar firebar in this.ListOfGameFireBars)
            {
                if (camera.HasEntityInView(firebar))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
