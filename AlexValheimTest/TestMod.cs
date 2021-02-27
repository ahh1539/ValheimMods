using HarmonyLib;
using System.Reflection;
using System;
using UnityEngine;
using System.Threading;


namespace TestMod
{
    public class TestMod
    {
        public static void Main(string[] args)
        {
            new Thread(() =>
            {
                Harmony harmony = new Harmony("com.valheim.alex_test");

                while (AccessTools.Method(typeof(Player), "GetMaxCarryWeight") == null)
                {
                    Thread.Sleep(100);

                }
                harmony.PatchAll();
            }).Start();
        }
    }

    [HarmonyPatch]
    public static class Patches
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Player), "Update")]
        public static void TestModWorks(Player __instance)
        {
            try
            {
                MethodInfo isPlayerCrouching = AccessTools.Method(typeof(Player), "IsCrouching");
                MethodInfo getCarryWeight = AccessTools.Method(typeof(Player), "GetMaxCarryWeight");
                Console.instance.Print("previous carry weight " + getCarryWeight.Invoke(__instance, null) + " iscrouching: " + isPlayerCrouching.Invoke(__instance, null));
            }
            catch (Exception e)
            {
                Console.instance.Print("ERROR: " + e);
            }
        }

        //[HarmonyPrefix]
        //[HarmonyPatch(typeof(Player), "Update")]
        //public static void TestSetStam(Player __instance)
        //{
        //    try
        //    {
        //        MethodInfo GetMaxStamina = AccessTools.Method(typeof(Player), "GetMaxStamina");
        //        MethodInfo SetMaxStamina = AccessTools.Method(typeof(Player), "SetMaxStamina");
        //        if ((float)GetMaxStamina.Invoke(__instance, null) < 100.0)
        //        {
        //            Console.instance.Print("previous max stam " + GetMaxStamina.Invoke(__instance, null));
        //            SetMaxStamina.Invoke(__instance, new object[] { 101.00 , false });
        //            Console.instance.Print("new max stam " + GetMaxStamina.Invoke(__instance, null));
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.instance.Print("ERROR: " + e);
        //    }
        //}
    }
}