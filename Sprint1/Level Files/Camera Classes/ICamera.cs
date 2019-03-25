using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{ 
    public interface ICamera
    {
        Vector2 CameraPosition { get; set; }
        Vector2 CameraDimensions { get; }

        void MoveLeft(float displacement);
        void MoveRight(float displacement);
        void MoveUp(float displacement);
        void MoveDown(float displacement);
        bool HasEntityInView(ILocateable entity);
        void SetCameraXLimits(Vector2 limits);
        void SetCameraYLimits(Vector2 limits);
    }
}
