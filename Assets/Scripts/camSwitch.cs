using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitch : MonoBehaviour { //controls camera's behavior, including switching positions, scaling, and smoothing motion
    public GameObject thisBall;
    public Vector3 pos1, pos2, pos3, pos4, targetPos; //4 camera positions to switch to, current intended position
    public float smoothRate, scaleRate; //lerp amounts for smoothly moving and scaling camera

    private Camera mainCam;
    private float camSize, newSize, smoothSize; //camera's current, intended, and smoothed sizes
    private Vector3 smoothPos; //for smoothly translating camera
    private ballTrigger thisBallTrigger; //to access ball's trigger code (interacting with trigger box colliders, controls camera position)
    

    void Start() {
        mainCam = gameObject.GetComponent<Camera>(); //this camera
        camSize = mainCam.orthographicSize; //initialize camera size & position as is in scene window
        targetPos = gameObject.transform.position;
        
        thisBallTrigger = thisBall.GetComponent<ballTrigger>(); //
        newSize = camSize;
    }

    void FixedUpdate() { //every frame
        smoothCam();
        targetSwitcher();
        scaleCam(newSize);
        camSize = mainCam.orthographicSize;
    }

    void smoothCam() { //for smoothing & moving camera
        smoothPos = Vector3.Lerp( gameObject.transform.position, targetPos, scaleRate); //lerp between intended location and current location
        gameObject.transform.position = smoothPos;
    }

    void scaleCam(float newSize) { //for smoothly scaling camera at certain triggers
       smoothSize = Mathf.Lerp(camSize, newSize, scaleRate);
       mainCam.orthographicSize = smoothSize;
    }

    void targetSwitcher() { //for switching camera's positional target & intended size
        if (thisBallTrigger.currentTrigger == 0) {
            targetPos = pos1;
            newSize = 17.4f;
        } else if (thisBallTrigger.currentTrigger == 1) {
            targetPos = pos2;
        } else if (thisBallTrigger.currentTrigger == 2) {
            targetPos = pos3;
        } else if (thisBallTrigger.currentTrigger == 3) {
            targetPos = pos4;
            newSize = 23.3f;
        }
    }
}

