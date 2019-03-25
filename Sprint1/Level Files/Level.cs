using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSE3902
{
    public class Level
    {

        public ITimer LevelTimer { get; set; }
        public ISong LevelSong { get; set; }
        public string WorldNum { get; private set; }

        public PortalManager PortalManager { get; }
        public ChunkManager ChunkManager { get; }
        public bool isUnderworld = false;
        public bool isMagic = true;

        public FloorManager FloorManager { get; }
        private CollisionManager collisionManager;

        private LevelInfoPacket levelInfo;
        private Color levelBGColor;


        private const int NUM_CHUNKS = 6;

        private ICamera camera;
        private ICameraController cameraController;

        private string filePath;

        public Level(String levelFile, Vector2 screenDimensions)
        {
            filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), levelFile);

            this.levelInfo = new LevelInfoPacket();
            this.ReadLevelInfo();
            this.WorldNum = levelInfo.WorldNum;

            collisionManager = new CollisionManager();
            PortalManager = new PortalManager();
            FloorManager = new FloorManager();
            ChunkManager = new ChunkManager(this.levelInfo.LevelWidth, NUM_CHUNKS);

            this.camera = new MarioCamera(this.levelInfo.OverworldXBounds, this.levelInfo.OverworldYBounds, screenDimensions);
            this.cameraController = new MarioCentricCameraController(this.camera);

            LevelTimer = new HalfSecondCountdownTimer(this.levelInfo.LevelTime, this.levelInfo.WarningTime);

            this.LevelTimer.ElapsedActions += () => Game1.Instance.Mario.Die();
            this.LevelTimer.WarningActions += () => LevelSong.SpeedUp();

        }
        public void LoadLevel(ContentManager content)
        {
            EnemySpriteFactory.Instance.LoadAllTextures(content);
            ItemSpriteFactory.Instance.LoadAllTextures(content);
            BlockSpriteFactory.Instance.LoadAllTextures(content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(content);
            MarioSpriteFactory.Instance.LoadAllTextures(content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(content);
            FontFactory.Instance.LoadAllFonts(content);

            LevelLoader.LoadLevelElements(filePath, ChunkManager);

            LevelLoader.LoadPortals(filePath, PortalManager);
            PortalManager.LinkUpPortals();

            LevelLoader.LoadFloors(filePath, FloorManager);

            LevelLoader.LoadFireBars(filePath, ChunkManager);

            SoundManager.Initialize(content);

            this.LevelSong = (ISong)Activator.CreateInstance(Type.GetType("CSE3902."+this.levelInfo.Music));

            this.SetOverWorldConditions();


        }
        public void ReadLevelInfo()
        {
            this.levelInfo = LevelLoader.ReadLevelInfo(filePath);
        }
        public void ProgressLevel()
        {
            if (this.levelInfo.NextLevel.Equals("END"))
            {
                Game1.Instance.ChangeGameState(Game1.GameStates.Win);

            }
            else
            {
                Game1.Instance.levelFile = this.levelInfo.NextLevel;
                Game1.Instance.ReloadLevel();
                Game1.Instance.ChangeGameState(Game1.GameStates.Reset);
            }
        }

        public void Update(GameTime gameTime)
        {
            this.LevelTimer.Update(gameTime);
            this.cameraController.Update(gameTime, Game1.Instance.Mario.Location);

            FloorManager.Update(gameTime);

            foreach (Chunk chunk in ChunkManager.GetActiveChunks(this.camera))
            {
                chunk.Update(gameTime);
            }

            Game1.Instance.Mario.Update(gameTime);

            foreach (Chunk chunk in ChunkManager.GetActiveChunks(this.camera))
            {
                collisionManager.Update(Game1.Instance.Mario, chunk, PortalManager.ListOfGamePortals, FloorManager.ListOfFloorPieces);
            }

            ChunkManager.ReparentStrayEntities();
            ChunkManager.CleanLevel();

        }
        public void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice, Color color1, Color color2, Color color3, Color color4)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, Matrix.CreateTranslation(new Vector3(-this.camera.CameraPosition.X, -this.camera.CameraPosition.Y, 0)));

            graphicsDevice.Clear(this.levelBGColor);

            FloorManager.Draw(spriteBatch, color1);

            ChunkManager.DrawBackground(spriteBatch, color2);
            Game1.Instance.Mario.Draw(spriteBatch, color3);
            ChunkManager.DrawAllEntities(spriteBatch, color4);

            spriteBatch.End();
        }

        public void SetUnderWorldConditions()
        {
            LevelSong.ChangeToUnderworld();
            LevelSong.Refresh();
            this.levelBGColor = levelInfo.UnderworldBGColor;
            this.camera.SetCameraXLimits(levelInfo.UnderworldXBounds);
            this.camera.SetCameraYLimits(levelInfo.UnderworldYBounds);
            isUnderworld = true;
            isMagic = false;
        }
        public void SetMagicConditions()
        {
            Random r = new Random();
            Color randColor = new Color(
                (byte)r.Next(0, 255),
                (byte)r.Next(0, 255),
                (byte)r.Next(0, 255)
                );
            this.levelBGColor = randColor;
            this.camera.SetCameraXLimits(levelInfo.OverworldXBounds);
            this.camera.SetCameraYLimits(levelInfo.OverworldYBounds);
            isMagic = true;
            isUnderworld = false;
        }
        public void SetOverWorldConditions()
        {
            LevelSong.ChangeToOverworld();
            LevelSong.Refresh();
            this.levelBGColor = levelInfo.OverworldBGColor;
            this.camera.SetCameraXLimits(levelInfo.OverworldXBounds);
            this.camera.SetCameraYLimits(levelInfo.OverworldYBounds);
            isMagic = false;
            isUnderworld = false;
        }


    }


}
