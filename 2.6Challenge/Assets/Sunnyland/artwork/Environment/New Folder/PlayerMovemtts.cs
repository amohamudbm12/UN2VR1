using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemtts : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    Vector2 move;
    void Start()
    {
        player = gameObject.transform;
        move = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        if(Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(20, 20, 1);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-20, 20, 1);
        }
    }

    void MovePlayer()
    {
        float newX = Input.GetAxis("Horizontal");
        float newY = Input.GetAxis("Vertical");
        move.x = newX;
        move.y = newY;
        player.Translate(move * Time.deltaTime);
    }

   
}
