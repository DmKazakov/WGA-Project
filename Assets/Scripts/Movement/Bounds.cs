using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    BoxCollider2D bounds;
    CameraControl camera;

    // Start is called before the first frame update
    void Start()
    {
        bounds = GetComponent<BoxCollider2D>();
        camera = FindObjectOfType<CameraControl>();

        camera.SetBounds(bounds);
    }
}
