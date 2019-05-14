using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortLayer : MonoBehaviour
{
    // public init
    public PlayerKeyboardController thePlayer;
    public Vector2 delta;

    // private init
    private SpriteRenderer sprite;
    private SpriteRenderer playerSprite;
    private int playerOrder;

    private float playerMinBound;
    private float spriteMinBound;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        thePlayer = FindObjectOfType<PlayerKeyboardController>();
        playerSprite = thePlayer.GetComponent<SpriteRenderer>();

        if (playerSprite)
        {
            playerOrder = playerSprite.sortingOrder;
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerMinBound = playerSprite.bounds.min.y;
        spriteMinBound = sprite.bounds.min.y;

        if (spriteMinBound < playerMinBound)
        {
            sprite.sortingOrder = playerOrder + (int)delta.x;
        } else
            sprite.sortingOrder = playerOrder - (int)delta.y;
    }
}
