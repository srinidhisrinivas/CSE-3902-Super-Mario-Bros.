using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class FontFactory
    {
        public static FontFactory Instance { get; } = new FontFactory();
        private SpriteFont headerFont;
        private SpriteFont pointFont;
        private SpriteFont screenTextFont;


        private FontFactory()
        {

        }
        public void LoadAllFonts(ContentManager content)
        {
            headerFont = content.Load<SpriteFont>(ScoreUtility.headerFontName);
            pointFont = content.Load<SpriteFont>(ScoreUtility.pointFontName);
            screenTextFont = content.Load<SpriteFont>(ScoreUtility.screenFontName);
        }
        public SpriteFont CreateHeaderFont()
        {
            return headerFont;
        }
        public SpriteFont CreatePointFont()
        {
            return pointFont;
        }
        public SpriteFont CreateScreenTextFont()
        {
            return screenTextFont;
        }

    }
}
