using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISQLDataAccess _db;

    public UserData(ISQLDataAccess db)
    {
        this._db = db;
    }

    public Task<IEnumerable<UserModel>> GetUsers() =>
       _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

    public async Task<UserModel?> GetUser(int id)
    {
        var result = await _db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
        return result.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Insert", new { user.FirstName, user.LastName });

    public Task UpdateUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Update", user);

    public Task DeleteUser(int id) =>
        _db.SaveData("dbo.spUser_Delete", id);

}
