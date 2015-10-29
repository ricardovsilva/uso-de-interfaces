namespace ModoShow
{
    public interface IDatabase
    {
        void SaveData(string data);
        int SelectData(string data);
        void UpdateData(string oldData, string newData);
        void DeleteData(string data);
    }
}
