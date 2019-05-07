using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject[] squad = new GameObject[3];
    public string sceneName;
    public Transform transform;

    public GameObject getUnit(int num) {
        return squad[num];
    }
}
