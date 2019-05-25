using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    private void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem part = gameObject.GetComponent<ParticleSystem>();
        if (!part.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
