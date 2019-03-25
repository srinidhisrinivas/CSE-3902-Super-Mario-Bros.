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
    public static class LevelEditFactory
    {
       
        public static void AddItem(IItem item)
        {
            Game1.Instance.Level.ChunkManager.AddItem(item);
        }
        public static void RemoveItem(IItem item)
        {
            Game1.Instance.Level.ChunkManager.RemoveItem(item);
        }
        public static void RemoveBlock(IBlock block)
        {
            Game1.Instance.Level.ChunkManager.RemoveBlock(block);
        }
        public static void RemoveEnemy(IEnemy enemy)
        {
            Game1.Instance.Level.ChunkManager.RemoveEnemy(enemy);

        }
        public static void ResetLevel()
        {
            Game1.Instance.ReloadLevel();
        }
        public static void RemoveProjectile(IProjectile projectile)
        {
            Game1.Instance.Level.ChunkManager.RemoveProjectile(projectile);
        }
        public static void AddProjectile(IProjectile projectile)
        {
            Game1.Instance.Level.ChunkManager.AddProjectile(projectile);
        }
        public static void AddHUDElement(IHUDElement element)
        {
            Game1.Instance.Level.ChunkManager.AddHUDElement(element);
        }
        public static void RemoveHUDElement(IHUDElement element)
        {
            Game1.Instance.Level.ChunkManager.RemoveHUDElement(element);
        }
        public static void SetUnderWorldConditions()
        {
            Game1.Instance.Level.SetUnderWorldConditions();
        }
        public static void SetOverWorldConditions()
        {
            Game1.Instance.Level.SetOverWorldConditions();
        }

    }
}
