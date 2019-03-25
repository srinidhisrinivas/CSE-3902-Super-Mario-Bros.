using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class EnemyStateUtility
    {
        public readonly static float deadGoombaYVelocity = -10f;
        public readonly static int deadGoombaYLocation = 520;
        public readonly static float leftMovingGoombaXVelocity = -0.75f;
        public readonly static float rightMovingGoombaXVelocity = 0.75f;
        public readonly static int stompedGoombaSquashTimer = 60;
        public readonly static int stompedGoombaSquashTimerZero = 0;
        public readonly static float deadKoopaYVelocity = -10f;
        public readonly static int deadKoopaYLocation = 520;
        public readonly static float leftMovingKoopaXVelocity = -0.75f;
        public readonly static int leftMovingShellXVelocity = -2;
        public readonly static float rightMovingKoopaXVelocity = 0.75f;
        public readonly static int rightMovingShellXVelocity = 2;
        public readonly static int stompedKoopaHideTimer = 600;
        public readonly static int stompedKoopaHideTimerZero = 0;
        public readonly static string content = "content";
        public readonly static string enemySpritesheet = "misc-3";
    }
}
