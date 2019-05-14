using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollider : MonoBehaviour
{
    // public init
    //public BoxCollider2D topCol;
    //public BoxCollider2D bottomCol;
    public PlayerKeyboardController thePlayer;
    public Vector2 minMax;

    // private init
    private SpriteRenderer sprite;
    private SpriteRenderer playerSprite;

    private float spriteMinBound;
    private float spriteMaxBound;

    private float playerMinBound;
    private float playerMaxBound;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        thePlayer = FindObjectOfType<PlayerKeyboardController>();
        playerSprite = thePlayer.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMinBound = playerSprite.bounds.min.y;
        spriteMinBound = sprite.bounds.min.y;

        playerMaxBound = playerSprite.bounds.max.y;
        spriteMaxBound = sprite.bounds.max.y;

        if (spriteMinBound > playerMinBound + 0.2) //(spriteMinBound > playerMinBound)
        {
            //topCol.enabled = true;
            //bottomCol.enabled = false;
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0, minMax.y); // 5.86
        }
        else //(spriteMinBound < playerMinBound)  //(spriteMaxBound < playerMaxBound)
        {
            //topCol.enabled = false;
            //bottomCol.enabled = true;
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0, minMax.x);   // -1.22
        }
       
    }
}
