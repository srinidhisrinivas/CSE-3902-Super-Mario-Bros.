namespace CSE3902
{
    public interface IBowserState : IEnemyState
    {
        void Jump();
        void ShootFireball();
        void Idle();
    }
    public interface IBowser : IEnemy
    {
        void Jump();
        void ShootFireball();
        void Idle();
    }
}