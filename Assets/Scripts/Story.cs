using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Story
{
    public static double chapter = 1.0;

    public static GameObject roomManager;
    public static GameObject dvorManager;
    public static GameObject tManager;
    public static GameObject schoolDvorManager;
    public static GameObject garageManager;


    public static void NextChapter()
    {
        chapter += 0.1;
    }

    public static void Restart()
    {
        roomManager.GetComponent<RoomManager>().Restart();
        chapter = 1.0;
    }
}