using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class LevelInfoPacket
    {
        public int LevelHeight { get; set; }
        public int LevelWidth { get; set; }
        public int LevelTime { get; set; }
        public int WarningTime { get; set; }
        public string WorldNum { get; set; }
        public Vector2 OverworldXBounds { get; set; }
        public Vector2 UnderworldXBounds { get; set; }
        public Vector2 OverworldYBounds { get; set; }
        public Vector2 UnderworldYBounds { get; set; }
        public Color OverworldBGColor { get; set; }
        public Color UnderworldBGColor { get; set; }
        public string NextLevel { get; set; }
        public string Music { get; set; }
    }
}
