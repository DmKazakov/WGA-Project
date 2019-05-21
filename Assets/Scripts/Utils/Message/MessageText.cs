using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MessageText : MonoBehaviour
{
   public string[] txt;

    internal string GetText(int num)
    {

        return txt[num];
    }
    public abstract void Init();
}
