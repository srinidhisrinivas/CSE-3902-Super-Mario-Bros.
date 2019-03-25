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
    public static class GameObjectFactory
    {
        public static IMario GetMarioObject(Vector2 location)
        {
            return new Mario(location);
        }
        public static IBlock GetBlockObject(String objectName, Vector2 location)
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;
            Type blockType = Type.GetType(objectFullName);
            return (IBlock)Activator.CreateInstance(blockType, location);
        }

        public static IEnemy GetEnemyObject(String objectName, Vector2 location)
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;

            Type enemyType = Type.GetType(objectFullName);
            return (IEnemy)Activator.CreateInstance(enemyType, location);
        }
        public static IItem GetItemObject(String objectName, Vector2 location)
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;
            Type itemType = Type.GetType(objectFullName);
            return (IItem)Activator.CreateInstance(itemType, location);

        }
        public static IHUDElement GetHUDObject(String objectName, Vector2 location)
        {
            string objectFUllName = ScoreUtility.fullNamePrefix + objectName;
            Type HUDType = Type.GetType(objectFUllName);
            return (IHUDElement)Activator.CreateInstance(HUDType, Game1.Instance.Mario, location);
        }

        public static IBackgroundObject GetBackgroundObject(String objectName, Vector2 location)
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;
            Type bgObjectType = Type.GetType(objectFullName);
            return (IBackgroundObject)Activator.CreateInstance(bgObjectType, location);
        }
        public static IPortal GetPortalObject(String objectName, Vector2 source, int tag, int width, int height, Portal.MotionDirection entryFace)
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;
            Type portalObjectType = Type.GetType(objectFullName);
            return (IPortal)Activator.CreateInstance(portalObjectType, source, tag, width, height, entryFace);
        }
        public static IFloorPiece GetFloorObject(string floorType, Vector2 location, int width, int height, string blockType)
        {
            string block = ScoreUtility.fullNamePrefix + blockType;
            Type blockObjectType = Type.GetType(block);
            IFloorPiece floorPiece;
            switch (floorType)
            {
                case "Block":
                    floorPiece = (IFloorPiece)Activator.CreateInstance(typeof(FloorPiece), location, width, height, blockObjectType);
                    break;
                case "Lava":
                    floorPiece = (IFloorPiece)Activator.CreateInstance(typeof(Lava), location, width, height);
                    break;
                case "Bridge":
                    floorPiece = (IFloorPiece)Activator.CreateInstance(typeof(Bridge), location, width);
                    break;
                default:
                    floorPiece = new NullFloorPiece();
                    break;

            }
            return floorPiece;
        }
        public static FireBar GetFireBarObject(String objectName, Vector2 location, int numOfFireballs, float angularVelocity, double initAngle, FireBar.FireBarDirections fireBarDirection
            )
        {
            string objectFullName = ScoreUtility.fullNamePrefix + objectName;
            Type firebarObjectType = Type.GetType(objectFullName);
            return (FireBar)Activator.CreateInstance(firebarObjectType, location, numOfFireballs, angularVelocity, initAngle, fireBarDirection);
        }

    }
}
