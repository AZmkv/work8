namespace Lab8_3
{
    public interface IAbstractFactory
    {
        IScreen CreateScreen();
        IProcessor CreateProcessor();
        ICamera CreateCamera();
    }
}
