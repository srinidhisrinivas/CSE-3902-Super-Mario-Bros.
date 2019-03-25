using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class ProjectileCollisionManager
    {
        Dictionary<string, Type> projectileEnemyCollisionMap;
        Dictionary<string, Type> projectileBlockCollisionMap;
        Dictionary<string, Type> projectileActionCollisionMap;

        public static ProjectileCollisionManager Instance { get; } = new ProjectileCollisionManager();
        
        private ProjectileCollisionManager()
        {
            projectileEnemyCollisionMap = CollisionUtility.projectileEnemy;
            projectileBlockCollisionMap = CollisionUtility.projectileBlock;
            projectileActionCollisionMap = CollisionUtility.projectileAction;    
           
        }
        public void ManageProjectileCollisions(Chunk currentChunk, IList<IFloorPiece> listOfFloorPieces)
        {
            ICollision collisionType;
            IList<Tuple<IBlock, ICollision>> detectedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions;

            foreach (IProjectile projectile in currentChunk.ListOfGameProjectiles)
            {
                IList<IBlock> blockCollisionCandidates = (from block in currentChunk.ListOfGameBlocks
                                                          let distanceFromBlock = Vector2.Distance(projectile.Location, block.Location)
                                                          where distanceFromBlock <= CollisionManager.COLLISION_CHECK_RADIUS
                                                          select block).ToList();
                foreach (IBlock block in blockCollisionCandidates)
                {
                    collisionType = CollisionManager.GetCollisionType(projectile.HitBox, block.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }
                }
                validCollisions = CollisionManager.GetValidBlockCollisions(detectedCollisions);
                detectedCollisions.Clear();
                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    this.HandleProjectileBlockCollision(projectile, pair.Item1, pair.Item2);
                }

                IList<IEnemy> enemyCollisionCandidates = (from enemy in currentChunk.ListOfGameEnemies
                                                          let distanceFromEnemy = Vector2.Distance(projectile.Location, enemy.Location)
                                                          where distanceFromEnemy <= CollisionManager.COLLISION_CHECK_RADIUS
                                                          select enemy).ToList();
                foreach (IEnemy enemy in enemyCollisionCandidates)
                {
                    collisionType = CollisionManager.GetCollisionType(projectile.HitBox, enemy.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        this.HandleProjectileEnemyCollision(projectile, enemy);
                    }
                }
                foreach (IFloorPiece floorPiece in listOfFloorPieces)
                {
                    collisionType = CollisionManager.GetCollisionType(projectile.HitBox, floorPiece.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        this.HandleProjectileFloorCollision(projectile, collisionType);
                    }
                }
            }
        }

        private void HandleProjectileEnemyCollision(IProjectile projectile, IEnemy enemy)
        {
            
            string collisionString = projectile.GetType().Name;
            if (projectileEnemyCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(projectileEnemyCollisionMap[collisionString], projectile, enemy);
                collisionCommand.Execute();
            }
            
            
        }
        private void HandleProjectileBlockCollision(IProjectile projectile, IBlock block, ICollision side)
        {
            string collisionString = side.GetType().Name;
            if (!(block.GetType().Name.StartsWith(CollisionUtility.hiddenBlockName) && block.BlockState is BumpableBlockState))
            {
                if (projectileBlockCollisionMap.ContainsKey(collisionString))
                {
                    ICommand collisionCommand = (ICommand)Activator.CreateInstance(projectileBlockCollisionMap[collisionString], projectile, side);
                    collisionCommand.Execute();
                }
                if (projectileActionCollisionMap.ContainsKey(collisionString))
                {
                    ICommand collisionCommand = (ICommand)Activator.CreateInstance(projectileActionCollisionMap[collisionString], projectile);
                    collisionCommand.Execute();
                }
            }
           
        }
        private void HandleProjectileFloorCollision(IProjectile projectile, ICollision side)
        {
            string collisionString = side.GetType().Name;
            
            if (projectileBlockCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(projectileBlockCollisionMap[collisionString], projectile, side);
                collisionCommand.Execute();
            }
                
            

        }
    }
}

