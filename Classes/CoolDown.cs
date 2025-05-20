using System.Threading.Tasks;

namespace LunarMenu.Classes
{
    internal class CoolDown
    {
        public static async Task<bool> Delay(int CoolDownTime)
        {
            await Task.Delay(CoolDownTime);
            return true;
        }
    }
}
