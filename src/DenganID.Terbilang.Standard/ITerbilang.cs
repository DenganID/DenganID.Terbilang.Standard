using System.Threading.Tasks;

namespace DenganID.Terbilang.Standard
{
    public interface ITerbilang
    {
        string From(int number);

        string From(long number);

        // string From(double number);
        string From(float number);
        Task<string> FromAsync(int number);
        Task<string> FromAsync(long number);

        // Task<string> FromAsync(decimal number);
        Task<string> FromAsync(float number);
    }
}