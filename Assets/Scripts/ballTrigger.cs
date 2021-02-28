using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTrigger : MonoBehaviour { //allows ball object to interact with placed box colliders that trigger camera position change
    SpriteRenderer ballRenderer;
    public int currentTrigger;

    void Start() {
        currentTrigger = -1;
    }

    void OnTriggerEnter2D(Collider2D other) { //checking collision with cam trigger box colliders
        if (other.gameObject.name == "triggerPos0") {
            currentTrigger = 0;
        } else if (other.gameObject.name == "triggerPos1") {
            currentTrigger = 1;
        } else if (other.gameObject.name == "triggerPos2") {
            currentTrigger = 2;
        } else if (other.gameObject.name == "triggerPos3") {
            currentTrigger = 3;
        }
    }
}
