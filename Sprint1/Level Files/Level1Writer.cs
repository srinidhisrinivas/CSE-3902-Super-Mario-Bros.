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
    class Level1Writer
    {
        //FIX: Exclude this class before submitting.
        // private XmlWriter xmlWriter;
        public Level1Writer()
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
            using (XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Level Files\level-1-1.xml"), xmlWriterSettings))
            {


                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("XnaContent");

                //Level info:
                xmlWriter.WriteStartElement("LevelInfo");
                //7584
                xmlWriter.WriteElementString("World", "1 - 1");
                xmlWriter.WriteElementString("Width", "9344");
                xmlWriter.WriteElementString("Height", "480");
                xmlWriter.WriteElementString("Time", "300");
                xmlWriter.WriteElementString("WarningTime", "100");
                xmlWriter.WriteElementString("Music", "MainTheme");

                xmlWriter.WriteElementString("OverworldXBounds", "0 7584");
                xmlWriter.WriteElementString("UnderworldXBounds", "8416 9216");
                xmlWriter.WriteElementString("OverworldYBounds", "0 480");
                xmlWriter.WriteElementString("UnderworldYBounds", "0 480");
                xmlWriter.WriteElementString("OverworldBGColor", "CornflowerBlue");
                xmlWriter.WriteElementString("UnderworldBGColor", "Black");
                xmlWriter.WriteElementString("NextLevel", @"Level Files\hell.xml");

                xmlWriter.WriteEndElement();

                //Test level:

                //WriteRedCrackedBlockPair(xmlWriter, new Vector2(0, 480), 25);
                //star is at 2*16*120
                //test level is at 160
                //flagpole is at 2*16*202
                //Underworld is at 7584 + 2*16*32
                WriteItem(xmlWriter, "Mario", "Mario", new Vector2(160, 400));
                //WriteItem(xmlWriter, "Item", "Star", new Vector2(320, 416));
                /*
                WriteItem(xmlWriter, "Block", "LeftPipe", new Vector2(320, 416));
                WriteItem(xmlWriter, "Block", "AscensionPipe", new Vector2(384, 352));
                */
                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(368, 416));
                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(668, 416));
                WriteNormalRedBrickBlockSequence(xmlWriter, new Vector2(450, 152), 6);
                WriteNormalRedBrickBlockSequence(xmlWriter, new Vector2(418, 120), 1);
                WriteNormalRedBrickBlockSequence(xmlWriter, new Vector2(642, 120), 1);


                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(546, 120));
                WriteItem(xmlWriter, "Enemy", "Koopa", new Vector2(600, 120));

                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(528, 288));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(560, 288));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(592, 288));

                //WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(496, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(528, 416));
                //WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(560, 416));

                WriteItem(xmlWriter, "Enemy", "Koopa", new Vector2(592, 416));

                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(160, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(192, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(224, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(256, 320));
                WriteItem(xmlWriter, "Block", "RedBrickBlockCoin", new Vector2(0, 320));
                WriteItem(xmlWriter, "Block", "RedBrickBlockStar", new Vector2(64, 320));
                WriteItem(xmlWriter, "Block", "HiddenBlockPowerUp", new Vector2(32, 196));


                //Level 1
                //Level barriers: not visible
                //BuildAWall(xmlWriter, new Vector2(-32, 416), 10);
                BuildAWall(xmlWriter, new Vector2(-32, 416), 10);
                BuildAWall(xmlWriter, new Vector2(7584, 416), 10);

                //Background and ground blocks
                WriteCloudSequence(xmlWriter, new Vector2(1072, 130), 4);

                /*
                WriteRedCrackedBlockPair(xmlWriter, new Vector2(800, 480), 69);
                WriteRedCrackedBlockPair(xmlWriter, new Vector2(2 * 1536, 480), 15);
                WriteRedCrackedBlockPair(xmlWriter, new Vector2(2 * 1824, 480), 64);
                WriteRedCrackedBlockPair(xmlWriter, new Vector2(2 * 2880, 480), 57);
                */
                WriteBushSequence(xmlWriter, new Vector2(1168, 416), 4);
                WriteHillSequence(xmlWriter, new Vector2(800, 416), 4);
                WriteItem(xmlWriter, "Background", "Castle", new Vector2(2 * 16 * 227, 416));


                //pipes
                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(2 * 848, 416));
                WriteItem(xmlWriter, "Block", "MediumPipe", new Vector2(2 * 1008, 416));
                WriteItem(xmlWriter, "Block", "TallPipe", new Vector2(2 * 1152, 416));
                WriteItem(xmlWriter, "Block", "TallPipe", new Vector2(2 * 1312, 416));

                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(2 * 3008, 416));
                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(2 * 3264, 416));

                //hardblocks
                WriteHardBlockTower(xmlWriter, new Vector2(2 * 2544, 416), 4, 4, "Forward");
                WriteHardBlockTower(xmlWriter, new Vector2(2 * 2640, 416), 4, 4, "Backward");
                WriteHardBlockTower(xmlWriter, new Vector2(2 * 2768, 416), 4, 5, "Forward");
                WriteHardBlockTower(xmlWriter, new Vector2(2 * 2880, 416), 4, 4, "Backward");
                WriteHardBlockTower(xmlWriter, new Vector2(2 * 3296, 416), 8, 9, "Forward");
                WriteItem(xmlWriter, "Block", "HardBlock", new Vector2(2 * 16 * 223, 416));
                WriteItem(xmlWriter, "Block", "Flagpole", new Vector2(2 * 16 * 223 + 14, 384));



                //foreground blocks
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 41, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 45, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockMagicMushroom", new Vector2(2 * 16 * 46, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 47, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 48, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 49, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 47, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "HiddenBlockGreenMushroom", new Vector2(2 * 16 * 89, 416 - 2 * 16 * 4));

                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 102, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(2 * 16 * 103, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 104, 416 - 2 * 16 * 3));
                WriteRedBrickBlockSequence(xmlWriter, new Vector2(2 * 16 * 105, 416 - 2 * 16 * 7), 8);
                WriteRedBrickBlockSequence(xmlWriter, new Vector2(2 * 16 * 116, 416 - 2 * 16 * 7), 3);
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 119, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "RedBrickBlockMultipleCoin", new Vector2(2 * 16 * 119, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 123, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockStar", new Vector2(2 * 16 * 124, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 129, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 132, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 135, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(2 * 16 * 132, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 143, 416 - 2 * 16 * 3));
                WriteRedBrickBlockSequence(xmlWriter, new Vector2(2 * 16 * 146, 416 - 2 * 16 * 7), 3);
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 153, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 154, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 155, 416 - 2 * 16 * 7));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 156, 416 - 2 * 16 * 7));
                WriteRedBrickBlockSequence(xmlWriter, new Vector2(2 * 16 * 154, 416 - 2 * 16 * 3), 2);
                WriteRedBrickBlockSequence(xmlWriter, new Vector2(2 * 16 * 193, 416 - 2 * 16 * 3), 2);
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(2 * 16 * 195, 416 - 2 * 16 * 3));
                WriteItem(xmlWriter, "Block", "RedBrickBlockBreakable", new Vector2(2 * 16 * 196, 416 - 2 * 16 * 3));

                //FIX: Add flagpole

                //enemies
                //WriteItem(xmlWriter, "Mario", "Mario", new Vector2(960, 416));

                //WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 52, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 71, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 79, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 81, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 108, 416 - 2 * 16 * 8));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 110, 416 - 2 * 16 * 8));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 153, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 152 - 8, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 150, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 149 - 8, 416));
                WriteItem(xmlWriter, "Enemy", "Koopa", new Vector2(2 * 16 * 137, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 127 - 8, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 128, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 198 - 8, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(2 * 16 * 199, 416));

                //Underworld

                //WriteBlueCrackedBlockPair(xmlWriter, new Vector2(7584 + 2 * 16 * 15, 480), 40);
                for (int i = 15; i <= 30; i++)
                {
                    WriteBlueBrickWall(xmlWriter, new Vector2(7584 + 2 * 16 * i, 416), 13);
                }
                WriteStationaryCoinSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 320), 7);
                WriteStationaryCoinSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 272), 7);
                WriteStationaryCoinSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 35, 224), 5);

                WriteItem(xmlWriter, "Block", "LeftPipe", new Vector2(7584 + 2 * 16 * 46, 416));
                WriteItem(xmlWriter, "Block", "AscensionPipe", new Vector2(7584 + 2 * 16 * 48, 352));

                for (int i = 50; i <= 59; i++)
                {
                    WriteBlueBrickWall(xmlWriter, new Vector2(7584 + 2 * 16 * i, 416), 13);
                }

                WriteBlueBrickBlockSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 416), 7);
                WriteBlueBrickBlockSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 384), 7);
                WriteBlueBrickBlockSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 352), 7);
                WriteBlueBrickBlockSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 352), 7);
                WriteBlueBrickBlockSequence(xmlWriter, new Vector2(7584 + 2 * 16 * 34, 32), 7);

                WritePortal(xmlWriter, "UnderworldClosedPortal", new Vector2(2632, 286), 1, 32, 20, 1);
                WritePortal(xmlWriter, "OverworldOpenPortal", new Vector2(8959 + 2 * 16 * 3, 352), 2, 15, 48, 3);
                WritePortal(xmlWriter, "ExitPortal", new Vector2(7584 + 2 * 16 * 32 + 16, -5), 1, 15, 48, 1);
                WritePortal(xmlWriter, "ExitPortal", new Vector2(6037, 397), 2, 15, 48, 0);

                WriteFloorPiece(xmlWriter, "Block", new Vector2(0, 480), 94, 2, "RedCrackedBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 1536, 480), 15, 2, "RedCrackedBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 1824, 480), 64, 2, "RedCrackedBlock");
                WriteFloorPiece(xmlWriter, "Block", new Vector2(2 * 2880, 480), 57, 2, "RedCrackedBlock");

                WriteFloorPiece(xmlWriter, "Block", new Vector2(7584 + 2 * 16 * 15, 480), 40, 2, "BlueCrackedBlock");



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
