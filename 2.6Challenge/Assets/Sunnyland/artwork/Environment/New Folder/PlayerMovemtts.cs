using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemtts : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 xMove;
    Transform player;
    void Start()
    {
        xMove = new Vector2(1.0f, 0.0f);
        player = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        float arrowInput = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Verical");
        xMove.x = arrowInput;
        xMove.y = upDown;
        player.Translate(xMove * Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
    }
}
