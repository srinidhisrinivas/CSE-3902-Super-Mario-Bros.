namespace CSE3902
{
    public class CommandMarioDie : ICommand
    {
        private IMario mario;
        public CommandMarioDie(IMario mario)
        {
            this.mario = mario;
        }
        public void Execute()
        {
            mario.Scoreboard.SubtractLives(ScoreUtility.addOne);
            Game1.Instance.ResetMarioState();
            if(mario.Scoreboard.LifeCount <= ScoreUtility.lifeCountInit)
            {
                Game1.Instance.ChangeGameState(Game1.GameStates.GameOver);
            }
            else
            {
                Game1.Instance.ChangeGameState(Game1.GameStates.Reset);

            }
            
        }
    }
}