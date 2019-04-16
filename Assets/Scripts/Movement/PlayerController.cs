using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // PUBLIC INIT
    public float mooveSpeed;
    public float parallax;
    public Vector2 lastMove;

    // PRIVATE INIT
    bool isMoving;

    Rigidbody2D theRB;
    Animator anim;

    KeyCode keyLeft = KeyCode.A;
    KeyCode keyRight = KeyCode.D;
    KeyCode keyUp = KeyCode.W;
    KeyCode keyDown = KeyCode.S;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        MakeMove(movement);
    }

    void MakeMove(Vector2 movement)
    {
        theRB.velocity = movement.normalized * mooveSpeed;
        Zindex();

        isMoving = theRB.velocity.x != 0 || theRB.velocity.y != 0;
        if (isMoving)
        {
            lastMove.x = movement.x;
            lastMove.y = movement.y;
        }

        //check direction
        if (theRB.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (theRB.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetFloat("speed", Mathf.Abs(theRB.velocity.x));
    }

    private void Zindex() {
		Vector3 position = transform.position;
		transform.position = new Vector3(position.x, position.y, position.y + parallax);
	}
}
