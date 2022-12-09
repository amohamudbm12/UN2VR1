using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    Vector2 move;
    Animator animator;
    Rigidbody2D rb2d;
 
    void Start()
    {
        player = gameObject.transform;
        move = new Vector2(0.0f, 0.0f);
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float rightLeft = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        move.x = rightLeft;
        move.y = upDown;
        player.Translate(move * Time.deltaTime);
        if(rightLeft < 0)
        {
            player.localScale = new Vector2(10.87514f, 17.77223);
        }
        if (upDown > 0)
        {
            player.localScale = new Vector2(-10.87514f, 17.77223);
        }
      
        movePlayer();
    }
    void movePlayer()
    {
        float newX = Input.GetAxis("Horizontal");
        float newY = Input.GetAxis("Vertical");
        move.x = newX;
        move.y = newY;
        player.Translate(move * Time.deltaTime);
    }

    
}
