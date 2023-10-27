using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform transform;
    public Transform playertransform;
    Vector3 CameraOffset;
    public float tolerance;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        transform.position = new Vector3(-1f, 4.5f, -10f);
        CameraOffset = transform.position - playertransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewCameraOffset = transform.position - playertransform.position;
        if (abs((NewCameraOffset - CameraOffset).x) > tolerance) {
            transform.position -= (NewCameraOffset - CameraOffset);
            CameraOffset = NewCameraOffset;
        }
    }

    private float abs(float x) {
        if (x < 0) return -x;
        else return x;
    }
}
