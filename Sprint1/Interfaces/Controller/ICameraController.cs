using Microsoft.Xna.Framework;

namespace CSE3902
{
    public interface ICameraController
    {
        void Update(GameTime gameTime, Vector2 subjectLocation);
    }
}