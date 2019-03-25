using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class EnemyCollisionManager
    {
        Dictionary<string, Type> enemyBlockCollisionMap;
        Dictionary<string, Type> enemyEnemyCollisionMap;
        Dictionary<string, Type> enemyActionCollisionMap;
        Dictionary<string, Type> enemyShellActionCollisionMap;
        Dictionary<string, Type> enemyFloorCollisionMap;

        public static EnemyCollisionManager Instance { get; } = new EnemyCollisionManager();
       
        private EnemyCollisionManager()
        {
            enemyBlockCollisionMap = CollisionUtility.enemyBlock;
            enemyEnemyCollisionMap = CollisionUtility.enemyEnemy;
            enemyActionCollisionMap = CollisionUtility.enemyAction;
            enemyShellActionCollisionMap = CollisionUtility.enemyShell;
            enemyFloorCollisionMap = CollisionUtility.enemyFloor;
            

        }
        public void ManageEnemyCollisions(IMario mario, Chunk currentChunk, IList<IFloorPiece> listOfFloorPieces)
        {
            ICollision collisionType;
            IList<Tuple<IBlock, ICollision>> detectedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions;

            foreach (IEnemy enemy in currentChunk.ListOfGameEnemies)
            {
                IList<IBlock> blockCollisionCandidates = (from block in currentChunk.ListOfGameBlocks
                                                          let distanceFromBlock = Vector2.Distance(enemy.Location, block.Location)
                                                          where distanceFromBlock <= CollisionManager.COLLISION_CHECK_RADIUS
                                                          select block).ToList();

                foreach (IBlock block in blockCollisionCandidates)
                {
                    collisionType = CollisionManager.GetCollisionType(enemy.HitBox, block.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }
                }
                validCollisions = CollisionManager.GetValidBlockCollisions(detectedCollisions);
                detectedCollisions.Clear();
                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    this.HandleEnemyBlockCollision(mario, enemy, pair.Item1, pair.Item2);
                }

                IList<IEnemy> enemyCollisionCandidates = (from secondEnemy in currentChunk.ListOfGameEnemies
                                                          let distanceFromEnemy = Vector2.Distance(enemy.Location, secondEnemy.Location)
                                                          where distanceFromEnemy <= CollisionManager.COLLISION_CHECK_RADIUS
                                                          select secondEnemy).ToList();

                foreach (IEnemy secondEnemy in enemyCollisionCandidates)
                {
                    
                    collisionType = CollisionManager.GetCollisionType(secondEnemy.HitBox, enemy.HitBox);
                    if (!(collisionType is NullCollision) && secondEnemy != enemy)
                    {
                        this.HandleEnemyEnemyCollision(mario, secondEnemy, enemy, collisionType);
                    }
                }

                foreach (IFloorPiece floorPiece in listOfFloorPieces)
                {
                    collisionType = CollisionManager.GetCollisionType(enemy.HitBox, floorPiece.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        this.HandleEnemyFloorCollision(enemy, collisionType);
                    }
                }
            }
        }
        private void HandleEnemyBlockCollision(IMario mario, IEnemy enemy, IBlock block, ICollision side)
        {
            if(enemy is Bowser)
            {
                return;
            }
            string collisionString = block.BlockState.GetType().Name + CollisionUtility.commaSeparator + side.GetType().Name;
            if (!(block.GetType().Name.StartsWith(CollisionUtility.hiddenBlockName) && block.BlockState.GetType().Name.StartsWith("Bumpable")) && enemyBlockCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyBlockCollisionMap[collisionString], enemy, side);
                collisionCommand.Execute();
            }
            if (enemyActionCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyActionCollisionMap[collisionString], mario, enemy);
                collisionCommand.Execute();
            }

        }
        private void HandleEnemyFloorCollision(IEnemy enemy, ICollision side)
        {
            string collisionString = side.GetType().Name;
            
            if (enemyFloorCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyFloorCollisionMap[collisionString], enemy, side);
                collisionCommand.Execute();
            }

        }
        private void HandleEnemyEnemyCollision(IMario mario, IEnemy secondEnemy, IEnemy enemy, ICollision side)
        {
            string collisionString = secondEnemy.State.GetType().Name + CollisionUtility.commaSeparator + side.GetType().Name;
            if (enemyEnemyCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyEnemyCollisionMap[collisionString], enemy, side);
                collisionCommand.Execute();
            }
            if (enemyActionCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyActionCollisionMap[collisionString], mario, enemy, side);
                collisionCommand.Execute();
            }
            string shellCollisionString = secondEnemy.State.GetType().Name;

            if (enemyShellActionCollisionMap.ContainsKey(shellCollisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyShellActionCollisionMap[shellCollisionString], mario, secondEnemy, enemy, side);
                collisionCommand.Execute();
            }

        }
    }
}

