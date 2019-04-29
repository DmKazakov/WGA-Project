using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private PlayerKeyboardController followTarget;

    //public GameObject followTarget;
    public float moveSpeed;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        followTarget = FindObjectOfType<PlayerKeyboardController>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, followTarget.transform.position.z - 10);

        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    }
}
