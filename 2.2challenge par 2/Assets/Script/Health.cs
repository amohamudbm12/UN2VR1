using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        heart = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(heart);
        heart = heart - 1;
    }
}
