using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FIX: Useless class. Remove.

namespace CSE3902
{
    class CollisionHandler
    {
        Dictionary<String, Type> marioItemCollisionMap;
        Dictionary<String, Type> marioEnemyCollisionMap;
        Dictionary<String, Type> marioBlockCollisionMap;
        Dictionary<String, Type> enemyEnemyCollisionMap;
        Dictionary<String, Type> enemyBlockCollisionMap;
        Dictionary<String, Type> itemEnemyCollisionMap;
        Dictionary<String, Type> itemBlockCollisionMap;

        private static readonly CollisionHandler instance = new CollisionHandler();
        public static CollisionHandler Instance
        {
            get
            {
                return instance;
            }
        }
        private CollisionHandler()
        {
            marioItemCollisionMap = new Dictionary<String, Type>();
            marioEnemyCollisionMap = new Dictionary<String, Type>();
            marioBlockCollisionMap = new Dictionary<String, Type>();
            enemyEnemyCollisionMap = new Dictionary<String, Type>();
            enemyBlockCollisionMap = new Dictionary<String, Type>();
            itemEnemyCollisionMap = new Dictionary<String, Type>();
            itemBlockCollisionMap = new Dictionary<String, Type>();
            /**
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandSmallMarioBumpPowerUpBlock));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockPowerUp, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpCoinBlock));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, QuestionBlockCoin, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpHiddenGreenMushroomBlock));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, HiddenBlockGreenMushroom, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, HardBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, ShortPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, ShortPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, MediumPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, MediumPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, TallPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, TallPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, TallPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBumpBrickBlock));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockBreakable, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickBlock));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockMultipleCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickStarBlock));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("SmallMarioType, BrickBlockStar, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockPowerUp, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpHiddenGreenMushroomBlock));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, HiddenBlockGreenMushroom, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, HardBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, ShortPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, ShortPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, MediumPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, MediumPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, TallPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, TallPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, TallPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpCoinBlock));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, QuestionBlockCoin, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockBreakable, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickBlock));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockMultipleCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickStarBlock));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("BigMarioType, BrickBlockStar, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandBigOrFireMarioBumpPowerUpBlock));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockPowerUp, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpCoinBlock));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, QuestionBlockCoin, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpHiddenGreenMushroomBlock));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, HiddenBlockGreenMushroom, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, HardBlock, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, ShortPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, ShortPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, MediumPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, MediumPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, TallPipe, RigidBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, TallPipe, RigidBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, TallPipe, RigidBlockState, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMarioBreakBlock));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BumpedBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockBreakable, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));

            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickBlock));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockMultipleCoin, BumpedBlock, TopCollision", typeof(CommandMoveUp));

            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpableBlockState, BottomCollision", typeof(CommandMarioBumpBrickStarBlock));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, UsedBlockState, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpedBlock, BottomCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpableBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, UsedBlockState, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpedBlock, LeftCollision", typeof(CommandMoveLeft));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpableBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, UsedBlockState, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpBlock, RightCollision", typeof(CommandMoveRight));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpableBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, UsedBlockState, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpedBlock, TopCollision", typeof(CommandMoveUp));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BreakableBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, UsedBlockState, NullCollision", typeof(CommandMoveMarioDown));
            marioBlockCollisionMap.Add("FireMarioType, BrickBlockStar, BumpedBlock, NullCollision", typeof(CommandMoveMarioDown));


            //Mario Enemy
            marioEnemyCollisionMap.Add("BigMarioType, Goomba, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Goomba, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Goomba, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Goomba, BottomCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Koopa, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Koopa, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Koopa, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("BigMarioType, Koopa, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemyCollisionMap.Add("FireMarioType, Goomba, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Goomba, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Goomba, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Goomba, BottomCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Koopa, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Koopa, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Koopa, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("FireMarioType, Koopa, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemyCollisionMap.Add("SmallMarioType, Goomba, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Goomba, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Goomba, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Goomba, BottomCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Koopa, TopCollision", typeof(CommandEnemyTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Koopa, LeftCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Koopa, RightCollision", typeof(CommandMarioTakeDamage));
            marioEnemyCollisionMap.Add("SmallMarioType, Koopa, BottomCollision", typeof(CommandMarioTakeDamage));

            marioEnemyCollisionMap.Add("DeadMarioType, Goomba, TopCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Goomba, LeftCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Goomba, RightCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Goomba, BottomCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Koopa, TopCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Koopa, LeftCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Koopa, RightCollision", typeof(CommandReset));
            marioEnemyCollisionMap.Add("DeadMarioType, Koopa, BottomCollision", typeof(CommandReset));

            //Mario Item
            marioItemCollisionMap.Add("SmallMarioType, RedMushroom", typeof(CommandConsumeRedMushroom));
            marioItemCollisionMap.Add("BigMarioType, Flower", typeof(CommandConsumeFlower));
            marioItemCollisionMap.Add("FireMarioType, Flower", typeof(CommandConsumeFlower));

            marioItemCollisionMap.Add("SmallMarioType, Coin", typeof(CommandConsumeCoin));
            marioItemCollisionMap.Add("BigMarioType, Coin", typeof(CommandConsumeCoin));
            marioItemCollisionMap.Add("FireMarioType, Coin", typeof(CommandConsumeCoin));

            marioItemCollisionMap.Add("SmallMarioType, GreenMushroom", typeof(CommandConsumeGreenMushroom));
            marioItemCollisionMap.Add("BigMarioType, GreenMushroom", typeof(CommandConsumeGreenMushroom));
            marioItemCollisionMap.Add("FireMarioType, GreenMushroom", typeof(CommandConsumeGreenMushroom));

            marioItemCollisionMap.Add("SmallMarioType, Star", typeof(CommandConsumeStar));
            marioItemCollisionMap.Add("BigMarioType, Star", typeof(CommandConsumeStar));
            marioItemCollisionMap.Add("FireMarioType, Star", typeof(CommandConsumeStar));
            
            //Enemy Enemy
            //Handle Shell koopa
            enemyEnemyCollisionMap.Add("Goomba, Goomba, TopCollision", typeof(CommandDoNothing));
            //CHanged this.
            enemyEnemyCollisionMap.Add("Goomba, Goomba, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyEnemyCollisionMap.Add("Goomba, Goomba, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyEnemyCollisionMap.Add("Goomba, Goomba, BottomCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Koopa, Goomba, TopCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Koopa, Goomba, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyEnemyCollisionMap.Add("Koopa, Goomba, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyEnemyCollisionMap.Add("Koopa, Goomba, BottomCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Goomba, Koopa, TopCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Goomba, Koopa, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyEnemyCollisionMap.Add("Goomba, Koopa, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyEnemyCollisionMap.Add("Goomba, Koopa, BottomCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Koopa, Koopa, TopCollision", typeof(CommandDoNothing));
            enemyEnemyCollisionMap.Add("Koopa, Koopa, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyEnemyCollisionMap.Add("Koopa, Koopa, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyEnemyCollisionMap.Add("Koopa, Koopa, BottomCollision", typeof(CommandDoNothing));
            **/

            //Enemy Block
            //WIP
            /*enemyBlockCollisionMap.Add("Goomba, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Goomba, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Goomba, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));

            enemyBlockCollisionMap.Add("Goomba, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Goomba, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Goomba, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));

            enemyBlockCollisionMap.Add("Goomba, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeft));
            enemyBlockCollisionMap.Add("Goomba, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRight));
            enemyBlockCollisionMap.Add("Goomba, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Goomba, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, HardBlock, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Goomba, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, ShortPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, ShortPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Goomba, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, MediumPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, MediumPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Goomba, TallPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, TallPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Goomba, TallPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            
            enemyBlockCollisionMap.Add("Goomba, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandEnemyMoveUp));
            enemyBlockCollisionMap.Add("Goomba, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandEnemyMoveUp));
            enemyBlockCollisionMap.Add("Goomba, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));

            enemyBlockCollisionMap.Add("Koopa, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Koopa, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Koopa, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));

            enemyBlockCollisionMap.Add("Koopa, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Koopa, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            enemyBlockCollisionMap.Add("Koopa, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));

            enemyBlockCollisionMap.Add("Koopa, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeft));
            enemyBlockCollisionMap.Add("Koopa, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRight));
            enemyBlockCollisionMap.Add("Koopa, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Koopa, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, HardBlock, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Koopa, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, ShortPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, ShortPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Koopa, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, MediumPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, MediumPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));

            enemyBlockCollisionMap.Add("Koopa, TallPipe, RigidBlockState, LeftCollision", typeof(CommandMoveEnemyLeftAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, TallPipe, RigidBlockState, RightCollision", typeof(CommandMoveEnemyRightAndChangeDirection));
            enemyBlockCollisionMap.Add("Koopa, TallPipe, RigidBlockState, TopCollision", typeof(CommandMoveEnemyUp));
            
            enemyBlockCollisionMap.Add("Koopa, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandEnemyMoveUp));
            enemyBlockCollisionMap.Add("Koopa, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandEnemyMoveUp));
            enemyBlockCollisionMap.Add("Koopa, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandFlipEnemy));
            */

            //Item Enemy
            //WIP

            itemEnemyCollisionMap.Add("Coin, Goomba", typeof(CommandDoNothing));
            itemEnemyCollisionMap.Add("Coin, Koopa", typeof(CommandDoNothing));

            itemEnemyCollisionMap.Add("Star, Goomba", typeof(CommandDoNothing));
            itemEnemyCollisionMap.Add("Star, Koopa", typeof(CommandDoNothing));

            itemEnemyCollisionMap.Add("RedMushroom, Goomba", typeof(CommandDoNothing));
            itemEnemyCollisionMap.Add("RedMushroom, Koopa", typeof(CommandDoNothing));

            itemEnemyCollisionMap.Add("GreenMushroom, Goomba", typeof(CommandDoNothing));
            itemEnemyCollisionMap.Add("GreenMushroom, Koopa", typeof(CommandDoNothing));

            itemEnemyCollisionMap.Add("Flower, Goomba", typeof(CommandDoNothing));
            itemEnemyCollisionMap.Add("Flower, Koopa", typeof(CommandDoNothing));

            //Change to flip and fireball explode?
            //itemEnemyCollisionMap.Add("Fireball, Goomba", typeof(CommandEnemyTakeDamage));
            //itemEnemyCollisionMap.Add("Fireball, Koopa", typeof(CommandEnemyTakeDamage));

            //Item Block
            /*WIP
            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandDoNothing));

            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, BumpableBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, UsedBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, QuestionBlockPowerUp, BumpedBlock, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));

            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandDoNothing));

            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, BumpableBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, UsedBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, QuestionBlockCoin, BumpedBlock, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            
            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandDoNothing));
            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandDoNothing));

            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, BreakableBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, UsedBlockState, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));
            itemBlockCollisionMap.Add("Coin, BrickBlockBreakable, BumpedBlock, BottomCollision", typeof(CommandMoveItemDownAndChangeDirection));

            itemBlockCollisionMap.Add("Star, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Star, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveItemLeftAndChangeDirection));
            itemBlockCollisionMap.Add("Star, HardBlock, RigidBlockState, RightCollision", typeof(CommandMoveItemRightAndChangeDirection));
            itemBlockCollisionMap.Add("Star, HardBlock, RigidBlockState, TopCollision", typeof(CommandItemBounce));
            
            itemBlockCollisionMap.Add("Star, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Star, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Star, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandItemBounce));
            
            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandItemChangeDirection));

            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandItemChangeDirection));

            itemBlockCollisionMap.Add("RedMushroom, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveItemUp));

            itemBlockCollisionMap.Add("RedMushroom, HardBlock, RigidBlockState, LeftCollision", typeof(CommandMoveItemLeftAndChangeDirection));

            itemBlockCollisionMap.Add("RedMushroom, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandMoveItemLeftAndChangeDirection));
            
            itemBlockCollisionMap.Add("RedMushroom, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("RedMushroom, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandItemChangeDirection));
            
            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandMoveItemUp));

            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("GreenMushroom, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandMoveItemUp));

            itemBlockCollisionMap.Add("GreenMushroom, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandMoveItemUp));
            
            itemBlockCollisionMap.Add("Flower, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("Flower, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandMoveItemUp));
            itemBlockCollisionMap.Add("Flower, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandMoveItemUp));
            
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpableBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, UsedBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpedBlock, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpableBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, UsedBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpedBlock, LeftCollision", typeof(CommandFireballExplode));

            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpableBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, UsedBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockPowerUp, BumpedBlock, RightCollision", typeof(CommandFireballExplode));

            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpableBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, UsedBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpedBlock, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpableBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, UsedBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpedBlock, LeftCollision", typeof(CommandFireballExplode));

            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpableBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, UsedBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, QuestionBlockCoin, BumpedBlock, RightCollision", typeof(CommandFireballExplode));

            itemBlockCollisionMap.Add("Fireball, CrackedBlock, RigidBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, CrackedBlock, RigidBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, CrackedBlock, RigidBlockState, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, HardBlock, RigidBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, HardBlock, RigidBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, HardBlock, RigidBlockState, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, ShortPipe, RigidBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, ShortPipe, RigidBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, ShortPipe, RigidBlockState, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, MediumPipe, RigidBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, MediumPipe, RigidBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, MediumPipe, RigidBlockState, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, TallPipe, RigidBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, TallPipe, RigidBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, TallPipe, RigidBlockState, TopCollision", typeof(CommandItemBounce));
            
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BreakableBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, UsedBlockState, TopCollision", typeof(CommandItemBounce));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BumpedBlock, TopCollision", typeof(CommandItemBounce));

            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BreakableBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, UsedBlockState, LeftCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BumpedBlock, LeftCollision", typeof(CommandFireballExplode));

            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BreakableBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, UsedBlockState, RightCollision", typeof(CommandFireballExplode));
            itemBlockCollisionMap.Add("Fireball, BrickBlockBreakable, BumpedBlock, RightCollision", typeof(CommandFireballExplode));
            
             */
        }
        public void MarioEnemyCollisionHandler(IMario mario, IEnemy enemy, ICollision side)
        {
            String collisionString = mario.PowerType.GetType().Name + ", " + enemy.GetType().Name + ", " + side.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioEnemyCollisionMap[collisionString], mario, enemy, side);
            collisionCommand.Execute();
        }

        public void MarioBlockCollisionHandler(IMario mario, IBlock block, ICollision side)
        {
            String collisionString = mario.PowerType.GetType().Name + ", " + block.GetType().Name + ", " + block.BlockState.GetType().Name + ", " + side.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioBlockCollisionMap[collisionString], mario, block, side);
            collisionCommand.Execute();
        }

        public void MarioItemCollisionHandler(IMario mario, IItem item)
        {
            String collisionString = mario.PowerType.GetType().Name + ", " + item.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(marioItemCollisionMap[collisionString], mario, item);
            collisionCommand.Execute();

        }
        public void EnemyEnemyCollisionHandler(IEnemy secondEnemy, IEnemy enemy, ICollision side)
        {
            String collisionString = secondEnemy.GetType().Name + ", " + enemy.GetType().Name + ", " + side.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyEnemyCollisionMap[collisionString], secondEnemy, enemy, side);
            collisionCommand.Execute();
        }
        public void EnemyBlockCollisionHandler(IEnemy enemy, IBlock block, ICollision side)
        {
            String collisionString = enemy.GetType().Name + ", " + block.GetType().Name + ", " + block.BlockState.GetType().Name + ", " +  side.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(enemyBlockCollisionMap[collisionString], enemy, block, side);
            collisionCommand.Execute();
        }
        public void ItemEnemyCollisionHandler( IItem item, IEnemy enemy)
        {
            String collisionString = item.GetType().Name + ", " + enemy.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(itemEnemyCollisionMap[collisionString], item, enemy);
            collisionCommand.Execute();
        }
        public void ItemBlockCollisionHandler(IItem item, IBlock block, ICollision side)
        {
            String collisionString = item.GetType().Name + ", " + block.GetType().Name + ", " + side.GetType().Name;
            ICommand collisionCommand = (ICommand)Activator.CreateInstance(itemBlockCollisionMap[collisionString], item, block, side);
            collisionCommand.Execute();
        }
    }
}

