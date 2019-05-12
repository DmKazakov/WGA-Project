using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Story 
{
    public static double chapter = 1.0;

    public static void NextChapter() {
        chapter += 0.1;
    }

    public static void Restart() {
        chapter = 1.0;
    }
}
