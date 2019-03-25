using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSE3902
{
    class HellWriter
    {
        //FIX: Exclude this class before submitting.
        // private XmlWriter xmlWriter;
        public HellWriter()
        {
            //xmlWriter = XmlWriter.Create("testarea.xml");

        }
        public void WriteLevel()
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
            using (XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Level Files\hell.xml"), xmlWriterSettings))
            {


                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("XnaContent");

                //Level info:
                xmlWriter.WriteStartElement("LevelInfo");
                //7584
                xmlWriter.WriteElementString("World", "1 - 4");
                xmlWriter.WriteElementString("Width", "5120");
                xmlWriter.WriteElementString("Height", "480");
                xmlWriter.WriteElementString("Time", "300");
                xmlWriter.WriteElementString("WarningTime", "100");
                xmlWriter.WriteElementString("Music", "CastleSong");

                xmlWriter.WriteElementString("OverworldXBounds", "0 5120");
                xmlWriter.WriteElementString("UnderworldXBounds", "0 0");
                xmlWriter.WriteElementString("OverworldYBounds", "0 480");
                xmlWriter.WriteElementString("UnderworldYBounds", "0 480");
                xmlWriter.WriteElementString("OverworldBGColor", "Black");
                xmlWriter.WriteElementString("UnderworldBGColor", "Black");
                xmlWriter.WriteElementString("NextLevel", @"END");

                xmlWriter.WriteEndElement();



                //Level 1
                //Level barriers: not visible
                BuildAWall(xmlWriter, new Vector2(-32, 480), 15);
                BuildAWall(xmlWriter, new Vector2(5120, 480), 15);
                //2*16*120
                WriteItem(xmlWriter, "Mario", "Mario", new Vector2(50, 480 - 2 * 16 * 9));

                //foreground blocks
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(2 * 16 * 30, 480 - 2 * 16 * 8));

                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 106, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 107, 480 - 2 * 16 * 9));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 109, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 110, 480 - 2 * 16 * 9));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 112, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(2 * 16 * 113, 480 - 2 * 16 * 9));
                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 23, 2 * 16 * 4));
                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 80, 2 * 16 * 2));
                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 88, 2 * 16 * 2));
                WriteItem(xmlWriter, "Item", "Axe", new Vector2(2 * 16 * 141, 480 - 2 * 16 * 6));
                WriteItem(xmlWriter, "Enemy", "Bowser", new Vector2(2 * 16 * 137, 480 - 2 * 16 * 5));


                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 23, 480 - 2 * 16 * 10));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 30, 480 - 2 * 16 * 4));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 37, 480 - 2 * 16 * 10));

                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 49, 480 - 2 * 16 * 10));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 49, 480 - 2 * 16 * 9));

                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 60, 480 - 2 * 16 * 10));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 60, 480 - 2 * 16 * 9));

                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 67, 480 - 2 * 16 * 10));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 67, 480 - 2 * 16 * 9));

                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 75, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 84, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 92, 480 - 2 * 16 * 5));
                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 80, 480 - 2 * 16 * 12));
                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(2 * 16 * 88, 480 - 2 * 16 * 12));

                WriteItem(xmlWriter, "Block", "UsedBlock", new Vector2(2 * 16 * 88, 480 - 2 * 16 * 11));
                WriteItem(xmlWriter, "Block", "HorizontalMovingPlatform", new Vector2(2 * 16 * 134, 480 - 2 * 16 * 9));








                WriteHellBlockSequence(xmlWriter, new Vector2(0, 2 * 16 * 1), 160);

                WriteFireBar(xmlWriter, "FireBar",  new Vector2(2 * 16 * 30, 480 - 2 * 16 * 4), 6, (float)(Math.PI/50), Math.PI/2, 0);
                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 49, 480 - 2 * 16 * 9), 9, (float)(Math.PI/50), Math.PI / 2, 0);
                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 60, 480 - 2 * 16 * 9), 9, (float)(Math.PI / 50), Math.PI / 2, 0);
                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 67, 480 - 2 * 16 * 9), 9, (float)(Math.PI / 50), Math.PI / 2, 0);

                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 75, 480 - 2 * 16 * 5), 8, (float)(Math.PI / 50), Math.PI / 2, 0);
                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 84, 480 - 2 * 16 * 5), 8, (float)(Math.PI / 50), Math.PI / 2, 0);
                WriteFireBar(xmlWriter, "FireBar", new Vector2(2 * 16 * 88, 480 - 2 * 16 * 11), 8, (float)(Math.PI / 50), Math.PI / 2, 0);

                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 2 * 16 * 3), 24, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 480 - 2 * 16 * 7), 3, 1, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 480 - 2 * 16 * 6), 4, 1, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 480 - 2 * 16 * 5), 5, 1, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 480), 13, 5, "HellBlock");
                WriteFloorPiece(xmlWriter, "Lava", new Vector2(2 * 16 * 13, 480), 2, 3, "NullBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 15, 480), 11, 5, "HellBlock");
                WriteFloorPiece(xmlWriter, "Lava", new Vector2(2 * 16 * 26, 480), 3, 2, "NullBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 29, 480), 3, 5, "HellBlock");
                WriteFloorPiece(xmlWriter, "Lava", new Vector2(2 * 16 * 32, 480), 3, 2, "NullBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 35, 480), 69, 5, "HellBlock");
                //WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 35, 480 - 2 * 16 * 5), 37, 1, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 37, 2 * 16 * 4), 35, 3, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 97, 2 * 16 * 3), 7, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 104, 480), 24, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 116, 480 - 2 * 16 * 2), 4, 3, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 123, 480 - 2 * 16 * 2), 5, 3, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 123, 2 * 16 * 3), 5, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Lava", new Vector2(2 * 16 * 128, 480), 13, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Bridge", new Vector2(2 * 16 * 128, 480 - 2 * 16 * 4), 52, 1, "NullBlock");

                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 141, 480), 20, 2, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 141, 480 - 2 * 16 * 2), 3, 4, "HellBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 16 * 142, 2 * 16 * 4), 2, 3, "HellBlock");




                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }



        }
        private void WriteStationaryCoinSequence(XmlWriter xmlWriter, Vector2 location, int numCoins)
        {
            for (int i = 0; i < numCoins; i++)
            {
                WriteItem(xmlWriter, "Item", "StationaryCoin", new Vector2(location.X + i * 32, location.Y));
            }
        }
        private void WriteBlueBrickWall(XmlWriter xmlWriter, Vector2 position, int height)
        {
            for (int i = 0; i < height; i++)
            {
                WriteItem(xmlWriter, "Block", "BlueBrickBlockBreakable", new Vector2(position.X, position.Y - i * 32));
            }
        }
        private void WriteBlueCrackedBlockPair(XmlWriter xmlWriter, Vector2 startPosition, int pairCount)
        {
            for (int i = 0; i < pairCount; i++)
            {
                Vector2 currentPosition = new Vector2(startPosition.X + i * 32, startPosition.Y);
                WriteItem(xmlWriter, "Block", "BlueCrackedBlock", currentPosition);
                currentPosition.Y -= 32;
                WriteItem(xmlWriter, "Block", "BlueCrackedBlock", currentPosition);
            }
        }
        private void WriteRedBrickBlockSequence(XmlWriter xmlWriter, Vector2 location, int numBlocks)
        {
            for (int i = 0; i < numBlocks; i++)
            {
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(location.X + i * 32, location.Y));
            }
        }
        private void WriteHellBlockSequence(XmlWriter xmlWriter, Vector2 location, int numBlocks)
        {
            for (int i = 0; i < numBlocks; i++)
            {
                WriteItem(xmlWriter, "Block", "HellBlock", new Vector2(location.X + i * 32, location.Y));
            }
        }
        private void WriteBlueBrickBlockSequence(XmlWriter xmlWriter, Vector2 location, int numBlocks)
        {
            for (int i = 0; i < numBlocks; i++)
            {
                WriteItem(xmlWriter, "Block", "BlueBrickBlockBreakable", new Vector2(location.X + i * 32, location.Y));
            }
        }
        private void BuildAWall(XmlWriter xmlWriter, Vector2 position, int height)
        {
            for (int i = 0; i < height; i++)
            {
                WriteItem(xmlWriter, "Block", "HardBlock", new Vector2(position.X, position.Y - i * 32));
            }
        }
        private void WriteCloudSequence(XmlWriter xmlWriter, Vector2 location, int numSequences)
        {
            Vector2 cloudLocation = location;
            for (int i = 0; i < numSequences; i++)
            {
                WriteItem(xmlWriter, "Background", "LittleCloud", cloudLocation);
                cloudLocation = new Vector2(cloudLocation.X + 2 * 176, cloudLocation.Y - 2 * 16);
                WriteItem(xmlWriter, "Background", "LittleCloud", cloudLocation);
                cloudLocation = new Vector2(cloudLocation.X + 2 * 128, cloudLocation.Y + 2 * 16);
                WriteItem(xmlWriter, "Background", "BigCloud", cloudLocation);
                cloudLocation = new Vector2(cloudLocation.X + 2 * 144, cloudLocation.Y - 2 * 16);
                WriteItem(xmlWriter, "Background", "MediumCloud", cloudLocation);
                cloudLocation = new Vector2(cloudLocation.X + 2 * 320, cloudLocation.Y + 2 * 16);

            }
        }
        private void WriteHardBlockTower(XmlWriter xmlWriter, Vector2 location, int height, int width, string face)
        {
            Vector2 blockLocation = location;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    WriteItem(xmlWriter, "Block", "HardBlock", blockLocation);
                    blockLocation += new Vector2(32, 0);
                }
                width -= 1;
                blockLocation = new Vector2(location.X, blockLocation.Y - 32);
                if (String.Equals(face, "Forward"))
                {
                    blockLocation += new Vector2(i * 32, 0);
                }
            }
        }

        private void WriteHillSequence(XmlWriter xmlWriter, Vector2 startLocation, int numSequences)
        {
            Vector2 hillLocation = startLocation;
            for (int i = 0; i < numSequences; i++)
            {
                WriteItem(xmlWriter, "Background", "BigHill", hillLocation);
                hillLocation += new Vector2(2 * 256, 0);
                WriteItem(xmlWriter, "Background", "LittleHill", hillLocation);
                hillLocation += new Vector2(2 * 512, 0);



            }
        }
        private void WriteBushSequence(XmlWriter xmlWriter, Vector2 startLocation, int numSequences)
        {
            Vector2 bushLocation = startLocation;
            for (int i = 0; i < numSequences; i++)
            {
                WriteItem(xmlWriter, "Background", "BigBush", bushLocation);
                bushLocation.X = bushLocation.X + 2 * 192;
                WriteItem(xmlWriter, "Background", "LittleBush", bushLocation);
                bushLocation.X = bushLocation.X + 2 * 288;
                WriteItem(xmlWriter, "Background", "MediumBush", bushLocation);
                bushLocation.X = bushLocation.X + 2 * 288;

            }
        }
        private void WriteItem(XmlWriter xmlWriter, string objectType, string objectName, Vector2 location)
        {
            xmlWriter.WriteStartElement("Item");
            xmlWriter.WriteStartElement("ObjectType");
            xmlWriter.WriteString(objectType);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("ObjectName");
            xmlWriter.WriteString(objectName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Location");
            xmlWriter.WriteString(location.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }
        private void WriteFireBar(XmlWriter xmlWriter, string objectName, Vector2 location, int numOfFireballs, float angularVelocity, double initAngle, int fireBarDirection)
        {
            xmlWriter.WriteStartElement("FireBar");
            xmlWriter.WriteStartElement("ObjectName");
            xmlWriter.WriteString(objectName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Location");
            xmlWriter.WriteString(location.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("NumberOfFireballs");
            xmlWriter.WriteString(numOfFireballs.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("AngularVelocity");
            xmlWriter.WriteString(angularVelocity.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("InitialAngle");
            xmlWriter.WriteString(initAngle.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("RotationDirection");
            xmlWriter.WriteString(fireBarDirection.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }
        private void WritePortal(XmlWriter xmlWriter, string objectType, Vector2 source, int portalTag, int width, int height, int entryDir)
        {
            xmlWriter.WriteStartElement("Portal");
            xmlWriter.WriteStartElement("Type");
            xmlWriter.WriteString(objectType);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Source");
            xmlWriter.WriteString(source.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Tag");
            xmlWriter.WriteString(portalTag.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Width");
            xmlWriter.WriteString(width.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Height");
            xmlWriter.WriteString(height.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("MotionDirection");
            xmlWriter.WriteString(entryDir.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }

        private void WriteFloorPiece(XmlWriter xmlWriter, string floorType, Vector2 location, int width, int height, string blockType)
        {
            xmlWriter.WriteStartElement("Floor");
            xmlWriter.WriteElementString("Type", floorType);
            xmlWriter.WriteStartElement("Location");
            xmlWriter.WriteString(location.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Width");
            xmlWriter.WriteString(width.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Height");
            xmlWriter.WriteString(height.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("BlockType");
            xmlWriter.WriteString(blockType);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }
        private void WriteNormalRedBrickBlockSequence(XmlWriter xmlWriter, Vector2 location, int brickCount)
        {
            for (int i = 0; i < brickCount; i++)
            {
                Vector2 currentPosition = new Vector2(location.X + i * 32, location.Y);
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", currentPosition);
            }
        }
        private void WriteRedCrackedBlockPair(XmlWriter xmlWriter, Vector2 startPosition, int pairCount)
        {
            for (int i = 0; i < pairCount; i++)
            {
                Vector2 currentPosition = new Vector2(startPosition.X + i * 32, startPosition.Y);
                WriteItem(xmlWriter, "Block", "RedCrackedBlock", currentPosition);
                currentPosition.Y -= 32;
                WriteItem(xmlWriter, "Block", "RedCrackedBlock", currentPosition);
            }
        }

    }
}
