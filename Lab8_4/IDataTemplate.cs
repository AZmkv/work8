namespace Lab8_4
{
    public interface IDataTemplate
    {
        IDataTemplate Clone();
        void FillData();
        void DisplayData();
    }
}
