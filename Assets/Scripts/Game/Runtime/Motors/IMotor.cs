namespace Game.Runtime
{
    public interface IMotor
    {
        Axis Axis { get; }
        void Move(float delta);
    }
}