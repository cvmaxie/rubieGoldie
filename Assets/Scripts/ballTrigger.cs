using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTrigger : MonoBehaviour {
    SpriteRenderer ballRenderer;
    public int currentTrigger;

    void Start() {
        currentTrigger = 0;
    }

    void FixedUpdate(){}

    void OnTriggerEnter2D(Collider2D other) { //checking collision with cam triggers
        if (other.gameObject.name == "triggerPos1") {
            currentTrigger = 1;
        } else if (other.gameObject.name == "triggerPos2") {
            currentTrigger = 2;
        } else if (other.gameObject.name == "triggerPos3") {
            currentTrigger = 3;
        }
    }
}
