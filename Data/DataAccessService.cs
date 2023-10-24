using SQLite;

namespace BoulderBadge.Data;

public class DataAccessService
{
    SQLiteAsyncConnection Connection;

    public DataAccessService()
    {
        
    }

    private async Task Init()
    {
        if (Connection is not null)
        {
            return;
        }

        Connection = new SQLiteAsyncConnection(DbConfig.DatabasePath, DbConfig.Flags);
        _ = await Connection.CreateTableAsync<Habit>();
    }



    public async Task<int> SaveItemAsync(Habit item)
    {
        await Init();
        if (item.Id != 0)
            return await Connection.UpdateAsync(item);
        else
            return await Connection.InsertAsync(item);
    }
}
