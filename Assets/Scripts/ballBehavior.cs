using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{ //this is just an example for reference
    SpriteRenderer ballRenderer;
    Rigidbody2D ballBody;
    public float power;

    void Start() {
        ballRenderer = gameObject.GetComponent<SpriteRenderer>();
        ballBody = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { //makin him bounce
            ballBody.AddForce((Vector3.right + Vector3.up) * power);
        }
    }
}
