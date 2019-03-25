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
    class TestLevelWriter
    {
        //FIX: Useless class. Remove.

        // private XmlWriter xmlWriter;
        public TestLevelWriter()
        {

        }
        public void WriteLevel()
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
            using (XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Level Files\testarea.xml"), xmlWriterSettings))
            {


                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("XnaContent");

                xmlWriter.WriteStartElement("LevelInfo");
                xmlWriter.WriteElementString("Width", "800");
                xmlWriter.WriteElementString("Height", "480");
                xmlWriter.WriteEndElement();

                BuildAWall(xmlWriter, new Vector2(-32, 416), 10);
                BuildAWall(xmlWriter, new Vector2(800, 416), 10);
                WriteCrackedBlockPair(xmlWriter, new Vector2(0, 448), 25);
                WriteItem(xmlWriter, "Mario", "Mario", new Vector2(160, 416));
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(320, 416));

                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(368, 416));
                WriteItem(xmlWriter, "Block", "ShortPipe", new Vector2(668, 416));
                WriteNormalBrickBlockSequence(xmlWriter, new Vector2(450, 152), 6);
                WriteNormalBrickBlockSequence(xmlWriter, new Vector2(418, 120), 1);
                WriteNormalBrickBlockSequence(xmlWriter, new Vector2(642, 120), 1);
                
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(546, 120));
                WriteItem(xmlWriter, "Enemy", "Koopa", new Vector2(600, 120));
                
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(528, 288));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(560, 288));
                WriteItem(xmlWriter, "Block", "HiddenBlockCoin", new Vector2(592, 288));
                
                WriteItem(xmlWriter, "Enemy", "Goomba", new Vector2(528, 416));
                WriteItem(xmlWriter, "Enemy", "Koopa", new Vector2(592, 416));
                
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(160, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(192, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockPowerUp", new Vector2(224, 320));
                WriteItem(xmlWriter, "Block", "QuestionBlockCoin", new Vector2(256, 320));
                WriteItem(xmlWriter, "Block", "BrickBlockCoin", new Vector2(0, 320));
                WriteItem(xmlWriter, "Block", "BrickBlockStar", new Vector2(64, 320));
                WriteItem(xmlWriter, "Block", "HiddenBlockPowerUp", new Vector2(32, 196));


                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }



        }
        private void BuildAWall(XmlWriter xmlWriter, Vector2 position, int height)
        {
            for (int i = 0; i < height; i++)
            {
                WriteItem(xmlWriter, "Block", "HardBlock", new Vector2(position.X, position.Y - i * 32));
            }
        }
        private void WriteLittleCloudPair(XmlWriter xmlWriter, Vector2 location)
        {
            for (int cloudGap = 0; cloudGap < 2; cloudGap++)
            {
                WriteItem(xmlWriter, "Background", "LittleCloud", new Vector2(location.X + cloudGap * 176, location.Y - cloudGap * 16));
            }
        }
        private void WriteItem(XmlWriter xmlWriter, String objectType, String objectName, Vector2 location)
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
        private void WriteNormalBrickBlockSequence(XmlWriter xmlWriter, Vector2 location, int brickCount)
        {
            for (int i = 0; i < brickCount; i++)
            {
                Vector2 currentPosition = new Vector2(location.X + i * 32, location.Y);
                WriteItem(xmlWriter, "Block", "BrickBlockBreakable", currentPosition);
            }
        }
        private void WriteCrackedBlockPair(XmlWriter xmlWriter, Vector2 startPosition, int pairCount)
        {
            for (int i = 0; i < pairCount; i++)
            {
                Vector2 currentPosition = new Vector2(startPosition.X + i * 32, startPosition.Y);
                WriteItem(xmlWriter, "Block", "CrackedBlock", currentPosition);
                currentPosition.Y += 32;
                WriteItem(xmlWriter, "Block", "CrackedBlock", currentPosition);
            }
        }

    }
}
