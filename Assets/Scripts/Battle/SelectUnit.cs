using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    internal bool select = false;
    private void OnMouseDown()
    {
        if (select)
        {
            print("click");
        }
    }
}
