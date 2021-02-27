using HarmonyLib;
using System.Reflection;
using System;
using UnityEngine;
using System.IO;
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
        private static MethodInfo isPlayerCrouching = AccessTools.Method(typeof(Player), "IsCrouching");
        private static MethodInfo setPlayerCrouching = AccessTools.Method(typeof(Player), "SetCrouch");


        [HarmonyPrefix]
        [HarmonyPatch(typeof(Player), "Update")]
        public static void TestMyMod(Player __instance)
        {
            Console.instance.Print("test 1 ");
        }
    }
}