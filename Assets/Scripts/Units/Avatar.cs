using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject[] squad = new GameObject[3];

    public GameObject getUnit(int num) {
        return squad[num];
    }
}
