using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandosBarrColl : MonoBehaviour
{
   public GameObject message;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        message.SetActive(true);
    }
}
