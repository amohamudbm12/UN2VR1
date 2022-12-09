using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollingup : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 moveUp;
    Transform camera;
    void Start()
    {
        moveUp = new Vector2(0.0f, 1.0f);
        camera = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        camera.Translate(moveUp * Time.deltaTime);
    }
}
