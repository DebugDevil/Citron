using GTA;
using GTA.Native;

namespace Citron.Extensions
{
    public static class EntityExtensions
    {
        public static int GetMaxHealth(this Entity GamePed)
        {
            return Function.Call<int>(Hash.GET_ENTITY_MAX_HEALTH, GamePed);
        }

        public static int GetHealth(this Entity GamePed)
        {
            return Function.Call<int>(Hash.GET_ENTITY_HEALTH, GamePed);
        }

        public static int SetMaxHealth(this Entity GamePed, int Value)
        {
            return Function.Call<int>(Hash.SET_ENTITY_MAX_HEALTH, GamePed, Value);
        }

        public static int SetHealth(this Entity GamePed, int Value)
        {
            return Function.Call<int>(Hash.SET_ENTITY_HEALTH, GamePed, Value);
        }
    }
}
