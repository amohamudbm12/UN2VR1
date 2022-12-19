using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 6;

    private float jumpForce = 20;

    private Rigidbody2D _rigidbody;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    private void Update()
    {

       
        
        
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;

        animator.SetFloat("speed", Mathf.Abs(movement));

          
            if (Input.GetKeyDown(KeyCode.Space))
            {
                 
                _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                StartCoroutine(ApplyDownwardForce());
        }

            if(movement != 0f)
        {

        }
    }

    // Coroutine that applies a downward force to the player's Rigidbody2D
    IEnumerator ApplyDownwardForce()
    {
        // Wait for 0.1 seconds before applying the downward force
        yield return new WaitForSeconds(0.3f);

        // Apply the downward force
        _rigidbody.AddForce(Vector2.down * jumpForce, ForceMode2D.Impulse);
    }



}
