using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private static bool Exists = false;

    void Start()
    {
        if (!Exists)
        {
            Exists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            
            Destroy(gameObject);
        }
    }
    public static void Restart() {
        
        
        Exists = false;
    }
   
}
