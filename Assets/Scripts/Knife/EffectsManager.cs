using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EffectsManager
{
#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject unityPlayerActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
    public static AndroidJavaObject vibrator = unityPlayerActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#else
    public static AndroidJavaClass unityPlayerClass;
    public static AndroidJavaObject unityPlayerActivity;
    public static AndroidJavaObject vibrator;
#endif

    public static void Vibrate(long time = 250)
    {
        if (IsAndroid())
        {
            vibrator.Call("vibrate", time);
        }   
        else
        {
            Handheld.Vibrate();
        }
    }

    public static bool IsAndroid()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        return true;
#else
        return false;
#endif
    }
}
