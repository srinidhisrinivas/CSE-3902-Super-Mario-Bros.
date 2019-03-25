using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class ItemCollisionManager
    {
        Dictionary<string, Type> itemBlockCollisionMap;

        public static ItemCollisionManager Instance { get; } = new ItemCollisionManager();
        
        private ItemCollisionManager()
        {
           
            itemBlockCollisionMap = CollisionUtility.itemBlock;
            
        }
        public void ManageItemCollisions(Chunk currentChunk, IList<IFloorPiece> listOfFloorPieces)
        {
            ICollision collisionType;
            IList<Tuple<IBlock, ICollision>> detectedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions;

            foreach (IItem item in currentChunk.ListOfGameItems)
            {
                IList<IBlock> blockCollisionCandidates = (from block in currentChunk.ListOfGameBlocks
                                                          let distanceFromBlock = Vector2.Distance(item.Location, block.Location)
                                                          where distanceFromBlock <= CollisionManager.COLLISION_CHECK_RADIUS
                                                          select block).ToList();
                foreach (IBlock block in blockCollisionCandidates)
                {
                    collisionType = CollisionManager.GetCollisionType(item.HitBox, block.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }
                }
                validCollisions = CollisionManager.GetValidBlockCollisions(detectedCollisions);
                detectedCollisions.Clear();
                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    this.HandleItemBlockCollision(item, pair.Item1, pair.Item2);
                }

                foreach(IFloorPiece floorPiece in listOfFloorPieces)
                {
                    collisionType = CollisionManager.GetCollisionType(item.HitBox, floorPiece.HitBox);
                    if (!(collisionType is NullCollision))
                    {
                        this.HandleItemFloorCollision(item, collisionType);
                    }
                }
            }
        }
        private void HandleItemBlockCollision(IItem item, IBlock block, ICollision side)
        {
            if (!(block.GetType().Name.StartsWith(CollisionUtility.hiddenBlockName) && block.BlockState.GetType().Name.StartsWith("Bumpable")))
            {
                string collisionString = side.GetType().Name;
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(itemBlockCollisionMap[collisionString], item, side);
                collisionCommand.Execute();
            }

        }
        private void HandleItemFloorCollision(IItem item, ICollision side)
        {
            string collisionString = side.GetType().Name;
            if (itemBlockCollisionMap.ContainsKey(collisionString))
            {
                ICommand collisionCommand = (ICommand)Activator.CreateInstance(itemBlockCollisionMap[collisionString], item, side);
                collisionCommand.Execute();
            }

        }

    }
}

