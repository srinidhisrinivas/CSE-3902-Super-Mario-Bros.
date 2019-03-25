using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class MarioCentricCameraController : ICameraController
    {
        private ICamera camera;
        private Vector2 cameraCenter;
        public MarioCentricCameraController(ICamera camera)
        {
            
            this.camera = camera;
            cameraCenter = new Vector2(camera.CameraPosition.X + camera.CameraDimensions.X/GameUtility.centerCameraOffset, camera.CameraPosition.Y + camera.CameraDimensions.Y/ GameUtility.centerCameraOffset);
        }
        public void Update(GameTime gameTime, Vector2 subjectLocation)
        {
            cameraCenter = new Vector2(camera.CameraPosition.X + camera.CameraDimensions.X / GameUtility.centerCameraOffset, camera.CameraPosition.Y + camera.CameraDimensions.Y / GameUtility.centerCameraOffset);
            Vector2 marioCenterOffset = subjectLocation - cameraCenter;
            if(marioCenterOffset.X > 0)
            {
                camera.MoveRight(marioCenterOffset.X);
            }
            else
            {
                camera.MoveLeft(Math.Abs(marioCenterOffset.X));
            }
            if (marioCenterOffset.Y < 0)
            {
                camera.MoveUp(Math.Abs(marioCenterOffset.Y));
            }
            else
            {
                camera.MoveDown(marioCenterOffset.Y);
            }
        }
    }
}
