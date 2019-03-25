using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class MarioCollisionManager
    {
        private Dictionary<string, Type> marioBlockCollisionMap;
        private Dictionary<string, Type> marioItemCollisionMap;
        private Dictionary<string, Type> marioEnemyCollisionMap;
        private Dictionary<string, Type> enemyActionCollisionMap;
        private Dictionary<string, Type> marioActionCollisionMap;
        private Dictionary<string, Type> marioMovementCollisionMap;
        private Dictionary<string, Type> marioFloorCollisionMap;
        private Dictionary<string, Type> marioPortalCollisionMap;
        private Dictionary<string, Type> marioFireBarCollisionMap;





        public static MarioCollisionManager Instance { get; } = new MarioCollisionManager();
        
        private MarioCollisionManager()
        {
            marioBlockCollisionMap = CollisionUtility.marioBlock;
            marioEnemyCollisionMap = CollisionUtility.marioEnemy;
            enemyActionCollisionMap = CollisionUtility.enemyAction;
            marioActionCollisionMap = CollisionUtility.marioAction;
            marioMovementCollisionMap = CollisionUtility.marioMovement;
            marioItemCollisionMap = CollisionUtility.marioItem;
            marioFloorCollisionMap = CollisionUtility.marioFloor;
            marioPortalCollisionMap = CollisionUtility.marioPortal;
            marioFireBarCollisionMap = CollisionUtility.marioFireBar;

        }
        public void ManageMarioCollisions(IMario mario, Chunk currentChunk, IList<IPortal> listOfGamePortals, IList<IFloorPiece> listOfFloorPieces)
        {
            IList<Tuple<IBlock, ICollision>> detectedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions;

            ICollision collisionType;
            IList<IBlock> blockCollisionCandidates = (from block in currentChunk.ListOfGameBlocks
                                                      let distanceFromBlock = Vector2.Distance(mario.Location, block.Location)
                                                      where distanceFromBlock <= CollisionManager.COLLISION_CHECK_RADIUS
                                                      select block).ToList();
            foreach (IBlock block in blockCollisionCandidates)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, block.HitBox);
                if (!(collisionType is NullCollision))
                {
                    detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                }
            }
            validCollisions = CollisionManager.GetValidBlockCollisions(detectedCollisions);
            foreach (Tuple<IBlock, ICollision> pair in validCollisions)
            {
                    this.HandleMarioBlockCollision(mario, pair.Item1, pair.Item2);
            }
            IList<IItem> itemCollisionCandidates = (from item in currentChunk.ListOfGameItems
                                                      let distanceFromItem = Vector2.Distance(item.Location, item.Location)
                                                      where distanceFromItem <= CollisionManager.COLLISION_CHECK_RADIUS
                                                      select item).ToList();
            foreach (IItem item in itemCollisionCandidates)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, item.HitBox);
                if (!(collisionType is NullCollision))
                {
                    this.HandleMarioItemCollision(mario, item);
                }
            }
            IList<IEnemy> enemyCollisionCandidates = (from enemy in currentChunk.ListOfGameEnemies
                                                      let distanceFromEnemy = Vector2.Distance(mario.Location, enemy.Location)
                                                      where distanceFromEnemy <= CollisionManager.COLLISION_CHECK_RADIUS
                                                      select enemy).ToList();
            foreach (IEnemy enemy in enemyCollisionCandidates)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, enemy.HitBox);
                if (!(collisionType is NullCollision))
                {
                    this.HandleMarioEnemyCollision(mario, enemy, collisionType);
                }
            }
            IList<FireBar> fireBarCollisionCandidates = (from fireBar in currentChunk.ListOfGameFireBars
                                                         let distanceFromFireBar = Vector2.Distance(mario.Location, fireBar.Location)
                                                         where distanceFromFireBar <= CollisionManager.COLLISION_CHECK_RADIUS
                                                         select fireBar).ToList();
            foreach (FireBar firebar in fireBarCollisionCandidates)
            {
                foreach (ElipticFireball fireBall in firebar.FireBallArray)
                {
                    collisionType = CollisionManager.GetCollisionType(mario.HitBox, fireBall.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        this.HandleMarioFireBarCollision(mario, firebar);
                    }

                }

            }
            IList<IProjectile> projectileCollisionCandidates = (from projectile in currentChunk.ListOfGameProjectiles
                                                      let distanceFromProjectile = Vector2.Distance(mario.Location, projectile.Location)
                                                      where distanceFromProjectile <= CollisionManager.COLLISION_CHECK_RADIUS
                                                      select projectile).ToList();
            foreach (IProjectile projectile in projectileCollisionCandidates)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, projectile.HitBox);
                if (!(collisionType is NullCollision))
                {
                    this.HandleMarioProjectileCollision(mario, projectile);
                }
            }

            foreach (IPortal portal in listOfGamePortals)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, portal.HitBox);
                if (!(collisionType is NullCollision))
                {
                    this.HandleMarioPortalCollision(mario, portal);
                }
            }

            foreach (IFloorPiece floorPiece in listOfFloorPieces)
            {
                collisionType = CollisionManager.GetCollisionType(mario.HitBox, floorPiece.HitBox);
                if (!(collisionType is NullCollision))
                {
                    this.HandleMarioFloorCollision(mario, collisionType);
                }
            }

        }

        private void HandleMarioBlockCollision(IMario mario, IBlock block, ICollision side)
        {

            string marioBlockCollision = mario.PowerType.GetType().Name + CollisionUtility.commaSeparator + block.GetType().Name + CollisionUtility.commaSeparator+ block.BlockState.GetType().Name + CollisionUtility.commaSeparator + side.GetType().Name;
            if (marioBlockCollisionMap.ContainsKey(marioBlockCollision))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioBlockCollisionMap[marioBlockCollision], mario, block, side);
                collisionCommand.Execute();
            }
            if (marioMovementCollisionMap.ContainsKey(marioBlockCollision))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioMovementCollisionMap[marioBlockCollision], mario, side);
                collisionCommand.Execute();
            }
            string marioCollision = block.BlockState.GetType().Name + CollisionUtility.commaSeparator + side.GetType().Name;
            if (marioMovementCollisionMap.ContainsKey(marioCollision))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioMovementCollisionMap[marioCollision], mario, side);
                collisionCommand.Execute();
            }

        }

        private void HandleMarioItemCollision(IMario mario, IItem item)
        {

            string collisionString = item.GetType().Name;
            if (marioItemCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioItemCollisionMap[collisionString], mario, item);
                collisionCommand.Execute();
            }

        }
        private void HandleMarioFireBarCollision(IMario mario, FireBar fireBar)
        {

            string collisionString = fireBar.GetType().Name;
            if (marioFireBarCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioFireBarCollisionMap[collisionString], mario);
                collisionCommand.Execute();
            }

        }
        private void HandleMarioProjectileCollision(IMario mario, IProjectile projectile)
        {

            string collisionString = mario.GetType().Name + ", " + projectile.GetType().Name;
            if (marioActionCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioActionCollisionMap[collisionString], mario);
                collisionCommand.Execute();
            }

        }
        private void HandleMarioFloorCollision(IMario mario, ICollision collisionType)
        {

            string collisionString = collisionType.GetType().Name;
            if (marioFloorCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioFloorCollisionMap[collisionString], mario, collisionType);
                collisionCommand.Execute();
            }

        }

        private void HandleMarioEnemyCollision(IMario mario, IEnemy enemy, ICollision side)
        {
            string collisionString = mario.GetType().Name + CollisionUtility.commaSeparator + enemy.State.GetType().Name + CollisionUtility.commaSeparator + side.GetType().Name;
            if (marioEnemyCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioEnemyCollisionMap[collisionString], mario, enemy, side);
                collisionCommand.Execute();
            }
            string enemyKillCollisionString = mario.GetType().Name;

            if (enemyActionCollisionMap.ContainsKey(enemyKillCollisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyActionCollisionMap[enemyKillCollisionString], mario, enemy);
                collisionCommand.Execute();
            }
            if (marioActionCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioActionCollisionMap[collisionString], mario);
                collisionCommand.Execute();
            }
        }
        private void HandleMarioPortalCollision(IMario mario, IPortal portal)
        {
            string collisionString = portal.GetType().Name;
            if (marioPortalCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioPortalCollisionMap[collisionString], mario, portal);
                collisionCommand.Execute();
            }
        }
       


    }
}

