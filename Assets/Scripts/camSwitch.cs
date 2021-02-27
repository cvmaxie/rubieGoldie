using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour {
    public Transform followTransform;
    public GameObject thisBall;

    private ballTrigger thisBallTrigger;

    public Vector3 pos1, pos2, pos3, targetPos; //3 camera positions to switch to, current intended position

    Camera mainCam;
    Vector3 smoothPos;
    public float smoothRate;

    void Start() {
        mainCam = gameObject.GetComponent<Camera>();
        targetPos = pos1;
        thisBallTrigger = thisBall.GetComponent<ballTrigger>();
    }

    void FixedUpdate() {
        smoothCam();
        targetSwitcher();
    }

    void smoothCam() { //for smoothing & moving camera
        smoothPos = Vector3.Lerp( gameObject.transform.position, targetPos, smoothRate); //lerp between intended location and current location
        gameObject.transform.position = smoothPos;
    }

    void targetSwitcher() {
        if (thisBallTrigger.currentTrigger == 1) {
            targetPos = pos2;
        }
    }
}

