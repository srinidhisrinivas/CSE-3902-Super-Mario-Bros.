namespace CSE3902
{
    class CommandProgressLevel : KeyboardCommand
    {
        public CommandProgressLevel(Game1 game) : base(game)
        {

        }
        public override void Execute()
        {
            game.Level.ProgressLevel();
        }
    }
}