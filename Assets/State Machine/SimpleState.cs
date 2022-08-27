namespace Lib
{
    public class SimpleState : State
    {
        public override void Initialize() => Enter();

        public void Enter() => enabled = true;
    }
}
