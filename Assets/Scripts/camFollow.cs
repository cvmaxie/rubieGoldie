using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform followTransform;
    public BoxCollider2D worldBounds;
    float xMin, xMax, yMin, yMax, camX, camY, camRatio, camSize;

    Camera mainCam;
    Vector3 smoothPos;
    public float smoothRate;

    void Start() {
        xMin = worldBounds.bounds.min.x;
        xMax = worldBounds.bounds.max.x;
        yMin = worldBounds.bounds.min.y;
        yMax = worldBounds.bounds.max.y;

        mainCam = gameObject.GetComponent<Camera>();

        camSize = mainCam.orthographicSize;
        camRatio = camSize * mainCam.aspect;
    }

    void FixedUpdate() {
        camY = Mathf.Clamp(followTransform.position.y, yMin + camSize, yMax - camSize);
        camX = Mathf.Clamp(followTransform.position.x, xMin + camRatio, xMax - camRatio); Debug.Log(camX);

        smoothPos = Vector3.Lerp(gameObject.transform.position, new Vector3(camX, camY, gameObject.transform.position.z), smoothRate);

        gameObject.transform.position = smoothPos;
    }
}
