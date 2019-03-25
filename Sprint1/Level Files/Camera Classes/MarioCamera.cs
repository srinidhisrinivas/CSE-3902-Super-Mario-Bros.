using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class MarioCamera : ICamera
    {
        public Vector2 CameraPosition { get; set; }
        public Vector2 CameraDimensions { get; private set; }
        private int levelXLeftBound;
        private int levelXRightBound;
        private int levelYUpBound;
        private int levelYBottomBound;

        public MarioCamera(Vector2 xLimits, Vector2 yLimits, Vector2 screenDimensions)
        {
            this.SetCameraXLimits(xLimits);
            this.SetCameraYLimits(yLimits);
            CameraPosition = new Vector2();
            CameraDimensions = screenDimensions;
        }
        public void MoveUp(float displacement)
        {
            CameraPosition -= new Vector2(0, displacement);
            if (CameraPosition.Y < levelYUpBound)
            {
                CameraPosition = new Vector2(CameraPosition.X, levelYUpBound);
            }
        }
        public void MoveDown(float displacement)
        {
            CameraPosition += new Vector2(0, displacement);
            if (CameraPosition.Y > levelYBottomBound - CameraDimensions.Y)
            {
                CameraPosition = new Vector2(CameraPosition.X, levelYBottomBound - CameraDimensions.Y);
            }

        }
        public void MoveRight(float displacement)
        {
            CameraPosition += new Vector2(displacement, 0);
            if (CameraPosition.X > levelXRightBound - this.CameraDimensions.X)
            {
                CameraPosition = new Vector2(levelXRightBound - CameraDimensions.X, CameraPosition.Y);
            }

        }
        public void MoveLeft(float displacement)
        {
            CameraPosition -= new Vector2(displacement, 0);
            if (CameraPosition.X < levelXLeftBound)
            {
                CameraPosition = new Vector2(levelXLeftBound, CameraPosition.Y);
            }

        }
        public bool HasEntityInView(ILocateable entity)
        {
            Vector2 relativeLocation = new Vector2(entity.Location.X - CameraPosition.X, entity.Location.Y - CameraPosition.Y);
            bool hasEntityInView = relativeLocation.X < CameraDimensions.X && relativeLocation.X > 0;
            return hasEntityInView;
        }
        public void SetCameraXLimits(Vector2 limit)
        {
            this.levelXLeftBound = (int)limit.X;
            this.levelXRightBound = (int)limit.Y;
        }
        public void SetCameraYLimits(Vector2 limit)
        {
            this.levelYUpBound = (int)limit.X;
            this.levelYBottomBound = (int)limit.Y;
        }
    }
}
