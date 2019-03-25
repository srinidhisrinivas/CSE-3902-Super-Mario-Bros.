using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{

    public class ChunkManager
    {
        private Chunk[] chunkArray;
        private int chunkSize;
        private int numChunks;

        private IList<IEnemy> enemiesToRemove;
        private IList<IBlock> blocksToRemove;
        private IList<IItem> itemsToRemove;
        private IList<IProjectile> projectilesToRemove;
        private IList<IHUDElement> HUDElementsToRemove;
        private IList<FireBar> firebarsToRemove;

        public ChunkManager(int levelWidth, int numChunks)
        {
            this.numChunks = numChunks;
            this.chunkSize = levelWidth / numChunks;

            chunkArray = new Chunk[numChunks];
            for (int i = 0; i < chunkArray.Length; i++)
            {
                chunkArray[i] = new Chunk();
            }

            enemiesToRemove = new List<IEnemy>();
            blocksToRemove = new List<IBlock>();
            itemsToRemove = new List<IItem>();
            projectilesToRemove = new List<IProjectile>();
            HUDElementsToRemove = new List<IHUDElement>();
            firebarsToRemove = new List<FireBar>();
    }
        public void DrawBackground(SpriteBatch spriteBatch, Color color)
        {
            foreach(Chunk chunk in chunkArray)
            {
                foreach(IBackgroundObject bgObject in chunk.ListOfBackgroundItems)
                {
                    bgObject.Draw(spriteBatch, color);
                }
            }
            
        }
        public void DrawAllEntities(SpriteBatch spriteBatch, Color color)
        {
            foreach (Chunk chunk in chunkArray)
            {
                foreach (IItem item in chunk.ListOfGameItems)
                {
                    item.Draw(spriteBatch, color);
                }
                foreach (IBlock block in chunk.ListOfGameBlocks)
                {
                    block.Draw(spriteBatch, color);
                }

                foreach (IProjectile projectile in chunk.ListOfGameProjectiles)
                {
                    projectile.Draw(spriteBatch, color);
                }

                foreach (IEnemy enemy in chunk.ListOfGameEnemies)
                {
                    enemy.Draw(spriteBatch, color);

                }
                foreach (IHUDElement element in chunk.ListOfHUDElements)
                {
                    element.Draw(spriteBatch);

                }
                foreach (FireBar firebar in chunk.ListOfGameFireBars)
                {
                    firebar.Draw(spriteBatch, color);
                }
            }
        }
        public void Reset()
        {
            for (int i = 0; i < chunkArray.Length; i++)
            {
                chunkArray[i] = new Chunk();
            }
        }
        public IList<Chunk> GetActiveChunks(ICamera camera)
        {
            IList<Chunk> activeChunks = (from chunk in chunkArray
                                         where chunk.IsActive(camera)
                                         select chunk).ToList();

            return activeChunks;
        }
        public void AddEnemy(IEnemy enemy)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)enemy.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfGameEnemies.Add(enemy);
        }
        public void AddBlock(IBlock block)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)block.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfGameBlocks.Add(block);
        }
        public void AddBackground(IBackgroundObject bgObject)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)bgObject.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfBackgroundItems.Add(bgObject);
        }
        public void AddItem(IItem item)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)item.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfGameItems.Add(item);
        }
        public void AddProjectile(IProjectile projectile)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)projectile.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfGameProjectiles.Add(projectile);
        }
        public void AddHUDElement(IHUDElement element)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)element.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfHUDElements.Add(element);
        }
        public void AddFireBar(FireBar firebar)
        {
            Chunk currentChunk = chunkArray[Chunk.GetChunkHashValue((int)firebar.Location.X, chunkSize, numChunks)];
            currentChunk.ListOfGameFireBars.Add(firebar);
        }
        public void RemoveEnemy(IEnemy enemy)
        {
            this.enemiesToRemove.Add(enemy);
        }
        public void RemoveBlock(IBlock block)
        {
            this.blocksToRemove.Add(block);
        }
        public void RemoveHUDElement(IHUDElement element)
        {
            this.HUDElementsToRemove.Add(element);
        }
        public void RemoveItem(IItem item)
        {
            this.itemsToRemove.Add(item);
        }
        public void RemoveProjectile(IProjectile projectile)
        {
            this.projectilesToRemove.Add(projectile);
        }
        public void RemoveFireBar(FireBar firebar)
        {
            this.firebarsToRemove.Add(firebar);
        }
        public void ReparentStrayEntities()
        {
            for (int i = 0; i < chunkArray.Length; i++)
            {
                Chunk currentChunk = chunkArray[i];

                IList<IItem> itemsToReparent = (from item in currentChunk.ListOfGameItems
                                   let currentChunkNum = i
                                   let correctChunkNum = Chunk.GetChunkHashValue((int)item.Location.X, chunkSize, numChunks)
                                   where currentChunkNum != correctChunkNum
                                   select item).ToList();
                
                foreach (IItem item in itemsToReparent)
                {
                    currentChunk.ListOfGameItems.Remove(item);
                    this.AddItem(item);
                }

                IList<IProjectile> projectilesToReparent = (from projectile in currentChunk.ListOfGameProjectiles
                                                let currentChunkNum = i
                                                let correctChunkNum = Chunk.GetChunkHashValue((int)projectile.Location.X, chunkSize, numChunks)
                                                where currentChunkNum != correctChunkNum
                                                select projectile).ToList();
                foreach (IProjectile projectile in projectilesToReparent)
                {
                    currentChunk.ListOfGameProjectiles.Remove(projectile);
                    this.AddProjectile(projectile);
                }
                IList<IEnemy> enemiesToReparent = (from enemy in currentChunk.ListOfGameEnemies
                                                let currentChunkNum = i
                                                let correctChunkNum = Chunk.GetChunkHashValue((int)enemy.Location.X, chunkSize, numChunks)
                                                where currentChunkNum != correctChunkNum
                                                select enemy).ToList();
                foreach (IEnemy enemy in enemiesToReparent)
                {
                    currentChunk.ListOfGameEnemies.Remove(enemy);
                    this.AddEnemy(enemy);
                }
                IList<FireBar> firebarsToReparent = (from firebar in currentChunk.ListOfGameFireBars
                                                   let currentChunkNum = i
                                                   let correctChunkNum = Chunk.GetChunkHashValue((int)firebar.Location.X, chunkSize, numChunks)
                                                   where currentChunkNum != correctChunkNum
                                                   select firebar).ToList();
                foreach (FireBar firebar in firebarsToReparent)
                {
                    currentChunk.ListOfGameFireBars.Remove(firebar);
                    this.AddFireBar(firebar);
                }
            }
        }
        public void CleanLevel()
        {
            foreach (IEnemy enemy in this.enemiesToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)enemy.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfGameEnemies.Remove(enemy);
            }
            this.enemiesToRemove.Clear();
            foreach (IBlock block in this.blocksToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)block.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfGameBlocks.Remove(block);
            }
            this.blocksToRemove.Clear();
            foreach (IItem item in this.itemsToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)item.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfGameItems.Remove(item);
            }
            this.itemsToRemove.Clear();
            foreach (IProjectile projectile in this.projectilesToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)projectile.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfGameProjectiles.Remove(projectile);
            }
            this.projectilesToRemove.Clear();
            foreach (IHUDElement HUDElement in this.HUDElementsToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)HUDElement.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfHUDElements.Remove(HUDElement);
            }
            this.HUDElementsToRemove.Clear();
            foreach (FireBar firebar in this.firebarsToRemove)
            {
                int chunkNum = Chunk.GetChunkHashValue((int)firebar.Location.X, chunkSize, numChunks);
                chunkArray[chunkNum].ListOfGameFireBars.Remove(firebar);
            }
            this.firebarsToRemove.Clear();


        }
    }
}
