using System.Security.Cryptography;

namespace ZX_WareHouse.Helpers;

internal class HashPassword
{
    /// <summary>
    /// Password hashing to SHA254
    /// </summary>
    /// <param name="value">Not hashed password</param>
    /// <returns>Hashed password</returns>
    public static string SHA254Hash(string value)
    {
        var byteArray = SHA256.HashData(Encoding.UTF8.GetBytes(value));
        return Convert.ToHexString(byteArray);
    }
}
