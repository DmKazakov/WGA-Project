using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public static class Story
{
    public static double chapter = 1.0;

    public static void NextChapter()
    {
        chapter += 0.1;
        chapter = (double)Math.Round(chapter, 1);
    }

    public static void Restart()
    {
        Clearing();
        PlayerKeyboardController.Reset();
        RestartManagers();
        chapter = 1.0d;
    }

    public static void Exit()
    {
        Application.Quit();
    }

    private static void Clearing()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] enemyes = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < players.Length; i++)
        {
            GameObject.Destroy(players[i]);
        }
        for (int i = 0; i < enemyes.Length; i++)
        {
            GameObject.Destroy(enemyes[i]);
        }
    }
    private static void RestartManagers()
    {
        RoomManager.Restart();
        SchoolManager.Restart();
        GarageManager.Restart();
        TManager.Restart();
    }
  
}