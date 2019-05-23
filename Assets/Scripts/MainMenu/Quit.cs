using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void OnMouseDown()
    {
        print("выход");
        Application.Quit();
    }
}
