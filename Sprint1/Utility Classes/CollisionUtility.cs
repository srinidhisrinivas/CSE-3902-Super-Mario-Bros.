using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class CollisionUtility
    {
        public const float collisionRadius=200f;
        public readonly static int blockMod = 32;
        public readonly static int intersectBuffer = 5;
        public readonly static int stompAdd = 1;
        public readonly static float shellPushThreshold = 2f;

        public readonly static Dictionary<string, Type> enemyFloor = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> enemyBlock = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> enemyEnemy = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> enemyAction = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> enemyShell = new Dictionary<string, Type>();

        public readonly static Dictionary<string, Type> marioPortal = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioBlock = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioEnemy = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioAction = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioMovement = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioItem = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type>marioFloor = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> marioFireBar = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> itemBlock = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> projectileEnemy = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> projectileBlock = new Dictionary<string, Type>();
        public readonly static Dictionary<string, Type> projectileAction = new Dictionary<string, Type>();
        public readonly static string hiddenBlockName = "HiddenBlock";
        public readonly static string bumpStateName = "BumpableBlockState";
        public readonly static string commaSeparator = ", ";

        public static void Initialize()
        {
            enemyFloor.Clear();
            enemyBlock.Clear();
            enemyAction.Clear();
            enemyEnemy.Clear();
            enemyShell.Clear();
            marioAction.Clear();
            marioBlock.Clear();
            marioMovement.Clear();
            marioFloor.Clear();
            marioEnemy.Clear();
            marioItem.Clear();
            marioPortal.Clear();
            marioFireBar.Clear();
            projectileAction.Clear();
            projectileBlock.Clear();
            projectileEnemy.Clear();
            itemBlock.Clear();
            enemyFloor.Add("TopCollision", typeof(CommandMoveEntityUp));
            enemyFloor.Add("BottomCollision", typeof(CommandMoveEntityDown));
            enemyFloor.Add("LeftCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyFloor.Add("RightCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyBlock.Add("BreakableBlockState, TopCollision", typeof(CommandMoveEntityUp));
            enemyBlock.Add("BumpableBlockState, TopCollision", typeof(CommandMoveEntityUp));
            enemyBlock.Add("RigidBlockState, TopCollision", typeof(CommandMoveEntityUp));
            enemyAction.Add("BumpedUsedBlock, TopCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BumpedBrickBlock, TopCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BrokenBlock, TopCollision", typeof(CommandMarioKillEnemy));

            enemyBlock.Add("BreakableBlockState, RightCollision", typeof(CommandMoveEnemyRightAndGoRight));
            enemyBlock.Add("BumpableBlockState, RightCollision", typeof(CommandMoveEnemyRightAndGoRight));
            enemyBlock.Add("RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndGoRight));
            enemyAction.Add("BumpedUsedBlock, RightCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BumpedBrickBlock, RightCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BrokenBlock, RightCollision", typeof(CommandMarioKillEnemy));

            enemyBlock.Add("BreakableBlockState, BottomCollision", typeof(CommandMoveEntityDown));
            enemyBlock.Add("BumpableBlockState, BottomCollision", typeof(CommandMoveEntityDown));
            enemyBlock.Add("RigidBlockState, BottomCollision", typeof(CommandMoveEntityDown));
            enemyBlock.Add("BumpedUsedBlock, BottomCollision", typeof(CommandMoveEntityDown));
            enemyBlock.Add("BumpedBrickBlock, BottomCollision", typeof(CommandMoveEntityDown));
            enemyAction.Add("BrokenBlock, BottomCollision", typeof(CommandMarioKillEnemy));

            enemyBlock.Add("BreakableBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyBlock.Add("BumpableBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyBlock.Add("RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyAction.Add("BumpedUsedBlock, LeftCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BumpedBrickBlock, LeftCollision", typeof(CommandMarioKillEnemy));
            enemyAction.Add("BrokenBlock, LeftCollision", typeof(CommandMarioKillEnemy));

            enemyAction.Add("StarMario", typeof(CommandMarioKillEnemy));
           
            enemyEnemy.Add("LeftMovingGoombaState, TopCollision", typeof(CommandSlideEnemyOff));
            enemyEnemy.Add("LeftMovingGoombaState, RightCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyEnemy.Add("LeftMovingGoombaState, LeftCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyEnemy.Add("RightMovingGoombaState, TopCollision", typeof(CommandSlideEnemyOff));
            enemyEnemy.Add("RightMovingGoombaState, RightCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyEnemy.Add("RightMovingGoombaState, LeftCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyEnemy.Add("LeftMovingKoopaState, TopCollision", typeof(CommandSlideEnemyOff));
            enemyEnemy.Add("LeftMovingKoopaState, RightCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyEnemy.Add("LeftMovingKoopaState, LeftCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyEnemy.Add("StompedKoopaState, TopCollision", typeof(CommandSlideEnemyOff));
            enemyEnemy.Add("StompedKoopaState, RightCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyEnemy.Add("StompedKoopaState, LeftCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyEnemy.Add("RightMovingKoopaState, TopCollision", typeof(CommandSlideEnemyOff));
            enemyEnemy.Add("RightMovingKoopaState, RightCollision", typeof(CommandMoveEnemyLeftAndGoLeft));
            enemyEnemy.Add("RightMovingKoopaState, LeftCollision", typeof(CommandMoveEnemyRightAndGoRight));

            enemyShell.Add("RightMovingShellState", typeof(CommandShellKillEnemy));
            enemyShell.Add("LeftMovingShellState", typeof(CommandShellKillEnemy));

            marioPortal.Add("OverworldOpenPortal", typeof(CommandGoThroughPortal));
            marioPortal.Add("UnderworldClosedPortal", typeof(CommandGoThroughPortal));

            marioFloor.Add("TopCollision", typeof(CommandMoveMarioUp));
            marioFloor.Add("BottomCollision", typeof(CommandMoveMarioDown));
            marioFloor.Add("LeftCollision", typeof(CommandMoveMarioLeft));
            marioFloor.Add("RightCollision", typeof(CommandMoveMarioRight));

            marioBlock.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandSmallMarioBumpPowerUpBlock));
            marioMovement.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, QuestionBlockMagicMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, QuestionBlockMagicMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, QuestionBlockMagicMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, QuestionBlockMagicMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("SmallMarioType, HiddenBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("SmallMarioType, HiddenBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandSmallMarioBumpPowerUpBlock));

            marioBlock.Add("SmallMarioType, RedBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, RedBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, RedBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, RedBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, BlueBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, BlueBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, BlueBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, BlueBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, RedBrickBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, RedBrickBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, RedBrickBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, RedBrickBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("SmallMarioType, RedBrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("SmallMarioType, RedBrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("SmallMarioType, RedBrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("SmallMarioType, RedBrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));
            marioMovement.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, QuestionBlockMagicMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("BigMarioType, QuestionBlockMagicMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, QuestionBlockMagicMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, QuestionBlockMagicMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("BigMarioType, HiddenBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("BigMarioType, HiddenBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));

            marioBlock.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, RedBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioMovement.Add("BigMarioType, RedBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, RedBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, RedBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, BlueBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioMovement.Add("BigMarioType, BlueBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, BlueBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, BlueBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));


            marioBlock.Add("BigMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("BigMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, RedBrickBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("BigMarioType, RedBrickBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, RedBrickBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, RedBrickBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("BigMarioType, RedBrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("BigMarioType, RedBrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("BigMarioType, RedBrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BigMarioType, RedBrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));
            marioMovement.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, QuestionBlockMagicMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("FireMarioType, QuestionBlockMagicMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, QuestionBlockMagicMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, QuestionBlockMagicMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("FireMarioType, HiddenBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));

            marioBlock.Add("FireMarioType, HiddenBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));

            marioBlock.Add("FireMarioType, RedBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioMovement.Add("FireMarioType, RedBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, RedBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, RedBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, BlueBrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioMovement.Add("FireMarioType, BlueBrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, BlueBrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, BlueBrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("FireMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, RedBrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, RedBrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("FireMarioType, RedBrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, RedBrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, RedBrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioBlock.Add("FireMarioType, RedBrickBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBlock));
            marioMovement.Add("FireMarioType, RedBrickBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveMarioLeft));
            marioMovement.Add("FireMarioType, RedBrickBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("FireMarioType, RedBrickBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveMarioUp));

            marioItem.Add("GreenMushroom", typeof(CommandConsumeGreenMushroom));
            marioItem.Add("RedMushroom", typeof(CommandConsumeRedMushroom));
            marioItem.Add("MagicMushroom", typeof(CommandConsumeMagicMushroom));
            marioItem.Add("Star", typeof(CommandConsumeStar));
            marioItem.Add("Flower", typeof(CommandConsumeFlower));
            marioItem.Add("StationaryCoin", typeof(CommandConsumeCoin));
            marioItem.Add("Axe", typeof(CommandCollectAxe));


            marioBlock.Add("FireMarioType, Flagpole, RigidBlockState, TopCollision", typeof(CommandDropFlag));
            marioBlock.Add("FireMarioType, Flagpole, RigidBlockState, BottomCollision", typeof(CommandDropFlag));
            marioBlock.Add("FireMarioType, Flagpole, RigidBlockState, LeftCollision", typeof(CommandDropFlag));
            marioBlock.Add("FireMarioType, Flagpole, RigidBlockState, RightCollision", typeof(CommandDropFlag));
            marioBlock.Add("BigMarioType, Flagpole, RigidBlockState, TopCollision", typeof(CommandDropFlag));
            marioBlock.Add("BigMarioType, Flagpole, RigidBlockState, BottomCollision", typeof(CommandDropFlag));
            marioBlock.Add("BigMarioType, Flagpole, RigidBlockState, LeftCollision", typeof(CommandDropFlag));
            marioBlock.Add("BigMarioType, Flagpole, RigidBlockState, RightCollision", typeof(CommandDropFlag));
            marioBlock.Add("SmallMarioType, Flagpole, RigidBlockState, TopCollision", typeof(CommandDropFlag));
            marioBlock.Add("SmallMarioType, Flagpole, RigidBlockState, BottomCollision", typeof(CommandDropFlag));
            marioBlock.Add("SmallMarioType, Flagpole, RigidBlockState, LeftCollision", typeof(CommandDropFlag));
            marioBlock.Add("SmallMarioType, Flagpole, RigidBlockState, RightCollision", typeof(CommandDropFlag));


            marioEnemy.Add("Mario, LeftMovingGoombaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioAction.Add("Mario, LeftMovingGoombaState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingGoombaState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingGoombaState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, RightMovingGoombaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioAction.Add("Mario, RightMovingGoombaState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingGoombaState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingGoombaState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, LeftMovingKoopaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioAction.Add("Mario, LeftMovingKoopaState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingKoopaState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingKoopaState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, RightMovingKoopaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioAction.Add("Mario, RightMovingKoopaState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingKoopaState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingKoopaState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, StompedKoopaState, TopCollision", typeof(CommandStompShell));
            marioEnemy.Add("Mario, StompedKoopaState, LeftCollision", typeof(CommandPushShellRight));
            marioEnemy.Add("Mario, StompedKoopaState, RightCollision", typeof(CommandPushShellLeft));
            marioAction.Add("Mario, StompedKoopaState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, LeftMovingShellState, TopCollision", typeof(CommandStompShell));
            marioAction.Add("Mario, LeftMovingShellState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingShellState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingShellState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemy.Add("Mario, RightMovingShellState, TopCollision", typeof(CommandStompShell));
            marioAction.Add("Mario, RightMovingShellState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingShellState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingShellState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioAction.Add("Mario, RightMovingBowserState, TopCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingBowserState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingBowserState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, RightMovingBowserState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioAction.Add("Mario, LeftMovingBowserState, TopCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingBowserState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingBowserState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, LeftMovingBowserState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioAction.Add("Mario, StationaryLeftFacingBowserState, TopCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, StationaryLeftFacingBowserState, LeftCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, StationaryLeftFacingBowserState, RightCollision", typeof(CommandMarioTakeDamage));
            marioAction.Add("Mario, StationaryLeftFacingBowserState, BottomCollision", typeof(CommandMarioTakeDamage));

            marioAction.Add("Mario, BowserFireball", typeof(CommandMarioTakeDamage));


            marioEnemy.Add("InvincibleMario, LeftMovingGoombaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioEnemy.Add("InvincibleMario, RightMovingGoombaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioEnemy.Add("InvincibleMario, LeftMovingKoopaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioEnemy.Add("InvincibleMario, RightMovingKoopaState, TopCollision", typeof(CommandBounceMarioAndStompEnemy));
            marioEnemy.Add("InvincibleMario, StompedKoopaState, TopCollision", typeof(CommandStompShell));
            marioEnemy.Add("InvincibleMario, LeftMovingShellState, TopCollision", typeof(CommandStompShell));
            marioEnemy.Add("InvincibleMario, RightMovingShellState, TopCollision", typeof(CommandStompShell));


            marioMovement.Add("RigidBlockState, TopCollision", typeof(CommandMoveMarioUp));
            marioMovement.Add("RigidBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioMovement.Add("RigidBlockState, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("RigidBlockState, LeftCollision", typeof(CommandMoveMarioLeft));

            marioMovement.Add("BumpedUsedBlock, TopCollision", typeof(CommandMoveMarioUp));
            marioMovement.Add("BumpedUsedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioMovement.Add("BumpedUsedBlock, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BumpedUsedBlock, LeftCollision", typeof(CommandMoveMarioLeft));

            marioMovement.Add("BrokenBlock, TopCollision", typeof(CommandMoveMarioUp));
            marioMovement.Add("BrokenBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioMovement.Add("BrokenBlock, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BrokenBlock, LeftCollision", typeof(CommandMoveMarioLeft));

            marioMovement.Add("BumpedBrickBlock, TopCollision", typeof(CommandMoveMarioUp));
            marioMovement.Add("BumpedBrickBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioMovement.Add("BumpedBrickBlock, RightCollision", typeof(CommandMoveMarioRight));
            marioMovement.Add("BumpedBrickBlock, LeftCollision", typeof(CommandMoveMarioLeft));

            itemBlock.Add("TopCollision", typeof(CommandBounceItem));
            itemBlock.Add("BottomCollision", typeof(CommandMoveEntityDown));
            itemBlock.Add("LeftCollision", typeof(CommandMoveItemLeftAndGoLeft));
            itemBlock.Add("RightCollision", typeof(CommandMoveItemRightAndGoRight));

            projectileEnemy.Add("Fireball", typeof(CommandExplodeFireballAndKillEnemy));

            projectileBlock.Add("TopCollision", typeof(CommandBounceFireball));
            projectileBlock.Add("BottomCollision", typeof(CommandMoveEntityDown));
            projectileAction.Add("LeftCollision", typeof(CommandExplodeFireball));
            projectileAction.Add("RightCollision", typeof(CommandExplodeFireball));

            marioFireBar.Add("FireBar", typeof(CommandMarioTakeDamage));
        }

    }
}
