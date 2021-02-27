using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDrop : MonoBehaviour
{
    Rigidbody2D dropper;
    public float power;
    private bool started;
    // Start is called before the first frame update
    void Start() {
        dropper = gameObject.GetComponent<Rigidbody2D>();
        started = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && !started) {
            dropper.AddForce(Vector3.left * power);
            started = true;
        }
    }
}
