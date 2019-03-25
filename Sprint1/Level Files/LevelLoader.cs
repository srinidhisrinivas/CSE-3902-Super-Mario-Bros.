using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSE3902
{
    public static class LevelLoader
    {
        public static LevelInfoPacket ReadLevelInfo(String filePath)
        {
            string uBounds, oBounds;
            LevelInfoPacket levelInfo = new LevelInfoPacket();
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                reader.MoveToContent();
                reader.ReadToDescendant("LevelInfo");
                reader.ReadStartElement("LevelInfo");
                reader.ReadStartElement("World");
                levelInfo.WorldNum = reader.ReadContentAsString();
                reader.ReadEndElement();
                reader.ReadStartElement("Width");
                levelInfo.LevelWidth = int.Parse(reader.ReadContentAsString());
                reader.ReadEndElement();
                reader.ReadStartElement("Height");
                levelInfo.LevelHeight = int.Parse(reader.ReadContentAsString());
                reader.ReadEndElement();
                reader.ReadStartElement("Time");
                levelInfo.LevelTime = int.Parse(reader.ReadContentAsString());
                reader.ReadEndElement();
                reader.ReadStartElement("WarningTime");
                levelInfo.WarningTime = int.Parse(reader.ReadContentAsString());
                reader.ReadEndElement();
                reader.ReadStartElement("Music");
                levelInfo.Music = reader.ReadContentAsString();
                reader.ReadEndElement();

                reader.ReadStartElement("OverworldXBounds");
                oBounds = reader.ReadContentAsString();
                levelInfo.OverworldXBounds = new Vector2(float.Parse(oBounds.Substring(0, oBounds.IndexOf(' '))), float.Parse(oBounds.Substring(oBounds.IndexOf(' ') + 1)));
                reader.ReadEndElement();
                reader.ReadStartElement("UnderworldXBounds");
                uBounds = reader.ReadContentAsString();
                levelInfo.UnderworldXBounds = new Vector2(float.Parse(uBounds.Substring(0, uBounds.IndexOf(' '))), float.Parse(uBounds.Substring(uBounds.IndexOf(' ') + 1)));
                reader.ReadEndElement();
                reader.ReadStartElement("OverworldYBounds");
                oBounds = reader.ReadContentAsString();
                levelInfo.OverworldYBounds = new Vector2(float.Parse(oBounds.Substring(0, oBounds.IndexOf(' '))), float.Parse(oBounds.Substring(oBounds.IndexOf(' ') + 1)));
                reader.ReadEndElement();
                reader.ReadStartElement("UnderworldYBounds");
                uBounds = reader.ReadContentAsString();
                levelInfo.UnderworldYBounds = new Vector2(float.Parse(uBounds.Substring(0, uBounds.IndexOf(' '))), float.Parse(uBounds.Substring(uBounds.IndexOf(' ') + 1)));
                reader.ReadEndElement();
                reader.ReadStartElement("OverworldBGColor");
                PropertyInfo pinfo = typeof(Color).GetProperty(reader.ReadContentAsString());
                Color color = (Color)pinfo.GetValue(Activator.CreateInstance(typeof(Color)));
                levelInfo.OverworldBGColor = color;
                reader.ReadEndElement();
                reader.ReadStartElement("UnderworldBGColor");
                pinfo = typeof(Color).GetProperty(reader.ReadContentAsString());
                color = (Color)pinfo.GetValue(Activator.CreateInstance(typeof(Color)));
                levelInfo.UnderworldBGColor = color;
                reader.ReadEndElement();
                reader.ReadStartElement("NextLevel");
                levelInfo.NextLevel = reader.ReadContentAsString();
                reader.ReadEndElement();

            }
            return levelInfo ;
        }
        public static void LoadLevelElements(String filePath, ChunkManager chunkManager)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                string objectType;
                string objectName;
                string locationString;
                Vector2 location;
                reader.MoveToContent();
                reader.ReadToDescendant("Item");
                while (reader.IsStartElement("Item"))
                {
                    reader.ReadStartElement("Item");
                    reader.ReadStartElement("ObjectType");
                    objectType = reader.ReadContentAsString();
                    reader.ReadEndElement();
                    reader.ReadStartElement("ObjectName");
                    objectName = reader.ReadContentAsString();
                    reader.ReadEndElement();
                    reader.ReadStartElement("Location");
                    locationString = reader.ReadContentAsString();
                    int locationStringSpaceIndex = locationString.IndexOf(' ');
                    string locationXString = locationString.Substring(3, locationStringSpaceIndex - 3);
                    location.X = float.Parse(locationXString, CultureInfo.InvariantCulture);
                    string locationYString = locationString.Substring(locationStringSpaceIndex + 3, locationString.Length - locationStringSpaceIndex - 4);
                    location.Y = float.Parse((locationYString), CultureInfo.InvariantCulture);
                    reader.ReadEndElement();
                    reader.ReadEndElement();
                   

                    switch (objectType)
                    {
                        case "Mario":
                            Game1.Instance.Mario.Location = location;
                            break;
                        case "Block":
                            chunkManager.AddBlock(GameObjectFactory.GetBlockObject(objectName, location));
                            break;
                        case "Enemy":
                            chunkManager.AddEnemy(GameObjectFactory.GetEnemyObject(objectName, location));
                            break;
                        case "Item":
                            chunkManager.AddItem(GameObjectFactory.GetItemObject(objectName, location));
                            break;
                        case "Background":
                            chunkManager.AddBackground(GameObjectFactory.GetBackgroundObject(objectName, location));
                            break;
                        case "HUDElement":
                            chunkManager.AddHUDElement(GameObjectFactory.GetHUDObject(objectName, location));
                            break;
                        default:
                            break;
                    }

                }
                
            }
        }
        public static void LoadPortals(String filePath, PortalManager portalManager)
        {
            using(XmlReader reader = XmlReader.Create(filePath))
            {
                string type;
                string locationSource;
                int tag;
                int width, height;
                Vector2 sourceLocation;

                reader.MoveToContent();
                reader.ReadToDescendant("Portal");
                while (reader.IsStartElement("Portal"))
                {
                    reader.ReadStartElement("Portal");
                    reader.ReadStartElement("Type");
                    type = reader.ReadContentAsString();
                    reader.ReadEndElement();
                    reader.ReadStartElement("Source");
                    locationSource = reader.ReadContentAsString();
                    int locationSourceSpaceIndex = locationSource.IndexOf(' ');
                    string locationXString = locationSource.Substring(3, locationSourceSpaceIndex - 3);
                    sourceLocation.X = float.Parse(locationXString, CultureInfo.InvariantCulture);
                    string locationYString = locationSource.Substring(locationSourceSpaceIndex + 3, locationSource.Length - locationSourceSpaceIndex - 4);
                    sourceLocation.Y = float.Parse((locationYString), CultureInfo.InvariantCulture);
                    reader.ReadEndElement();
                    reader.ReadStartElement("Tag");
                    tag = int.Parse(reader.ReadContentAsString());
                    
                    reader.ReadEndElement();
                    reader.ReadStartElement("Width");
                    width = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();
                    reader.ReadStartElement("Height");
                    height = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();
                    reader.ReadStartElement("MotionDirection");
                    int entryDir = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();
                    Portal.MotionDirection entryFace = (Portal.MotionDirection)entryDir;
                    reader.ReadEndElement();
                    portalManager.ListOfGamePortals.Add(GameObjectFactory.GetPortalObject(type, sourceLocation, tag, width, height, entryFace));
                }
                  
            }
           
        }

        public static void LoadFloors(String filePath, FloorManager floorManager)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                string floorType;
                string blockType;
                string locationString;
                int width, height;
                Vector2 location;

                reader.MoveToContent();
                reader.ReadToDescendant("Floor");
                while (reader.IsStartElement("Floor"))
                {
                    reader.ReadStartElement("Floor");
                    reader.ReadStartElement("Type");
                    floorType = reader.ReadContentAsString();
                    reader.ReadEndElement();
                    reader.ReadStartElement("Location");
                    locationString = reader.ReadContentAsString();
                    int locationSourceSpaceIndex = locationString.IndexOf(' ');
                    string locationXString = locationString.Substring(3, locationSourceSpaceIndex - 3);
                    location.X = float.Parse(locationXString, CultureInfo.InvariantCulture);
                    string locationYString = locationString.Substring(locationSourceSpaceIndex + 3, locationString.Length - locationSourceSpaceIndex - 4);
                    location.Y = float.Parse((locationYString), CultureInfo.InvariantCulture);
                    reader.ReadEndElement();
                    
                    reader.ReadStartElement("Width");
                    width = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();
                    reader.ReadStartElement("Height");
                    height = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();
                    reader.ReadStartElement("BlockType");
                    blockType = reader.ReadContentAsString();
                    reader.ReadEndElement();
                    reader.ReadEndElement();

                    floorManager.ListOfFloorPieces.Add(GameObjectFactory.GetFloorObject(floorType, location, width, height, blockType));
                }

            }

        }

        public static void LoadFireBars(String filePath, ChunkManager chunkManager)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                string locationSource;
                string objectName;

                Vector2 sourceLocation;
                int numOfFireballs;
                float angularVelocity;
                double initAngle;
                FireBar.FireBarDirections fireBarDirection;

                reader.MoveToContent();
                reader.ReadToDescendant("FireBar");
                while (reader.IsStartElement("FireBar"))
                {
                    reader.ReadStartElement("FireBar");

                    reader.ReadStartElement("ObjectName");
                    objectName = reader.ReadContentAsString();
                    reader.ReadEndElement();

                    reader.ReadStartElement("Location");
                    locationSource = reader.ReadContentAsString();
                    int locationSourceSpaceIndex = locationSource.IndexOf(' ');
                    string locationXString = locationSource.Substring(3, locationSourceSpaceIndex - 3);
                    sourceLocation.X = float.Parse(locationXString, CultureInfo.InvariantCulture);
                    string locationYString = locationSource.Substring(locationSourceSpaceIndex + 3, locationSource.Length - locationSourceSpaceIndex - 4);
                    sourceLocation.Y = float.Parse((locationYString), CultureInfo.InvariantCulture);
                    reader.ReadEndElement();

                    reader.ReadStartElement("NumberOfFireballs");
                    numOfFireballs = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();

                    reader.ReadStartElement("AngularVelocity");
                    angularVelocity = float.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();

                    reader.ReadStartElement("InitialAngle");
                    initAngle = double.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();

                    reader.ReadStartElement("RotationDirection");
                    int rotatDir = int.Parse(reader.ReadContentAsString());
                    reader.ReadEndElement();

                    fireBarDirection = (FireBar.FireBarDirections)rotatDir;
                    reader.ReadEndElement();
                    chunkManager.AddFireBar(GameObjectFactory.GetFireBarObject(objectName, sourceLocation, numOfFireballs, angularVelocity, initAngle, fireBarDirection));
                }

            }

        }
    }
}

