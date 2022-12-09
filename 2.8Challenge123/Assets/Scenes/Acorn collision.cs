using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorncollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("OUCH");
        }
    }
}
