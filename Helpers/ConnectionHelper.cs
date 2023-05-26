using LiteDB;
using ZX_WareHouse.Models;

namespace ZX_WareHouse.Helpers;

internal class ConnectionHelper
{
    public static string dbDefaultPath = @"./Data/warehouse.db";

    /// <summary>
    /// Get users collection as IEnumerable and find if credentials match
    /// </summary>
    /// <param name="login">Provided login</param>
    /// <param name="password">Provided hashed password</param>
    /// <returns>Bool depending on finding proper credentials</returns>
    public static bool CheckUserCredentials(string login, string password)
    {
        using LiteDatabase db = new(dbDefaultPath);
        var usersCol = db.GetCollection<User>("users");
        IEnumerable<User> users = usersCol.FindAll();

        foreach (User user in users)
        {
            if (login == user.Name && password == user.Password)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Return user permission as an number
    /// </summary>
    /// <param name="login">User login</param>
    /// <returns></returns>
    public static int CheckUserPermissions(string login)
    {
        using LiteDatabase db = new(dbDefaultPath);
        var usersCol = db.GetCollection<User>("users");

        return usersCol.FindOne(x => x.Name == login).Permission;
    }
}
