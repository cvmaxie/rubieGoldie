using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    SpriteRenderer ballRenderer;
    Rigidbody2D ballBody;
    public float power;
    // Start is called before the first frame update
    void Start() {
        ballRenderer = gameObject.GetComponent<SpriteRenderer>();
        ballBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ballBody.AddForce((Vector3.right + Vector3.up) * power);
        }
    }

    void OncollisionEnter2D(Collision2D other) { //checking collision (physics based)
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Floor") {
            Debug.Log("Hit Floor");
        }
    }
}
