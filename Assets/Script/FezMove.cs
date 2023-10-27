using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FezMove : MonoBehaviour
{
    public int leap;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(" key D was pressed");
            transform.position += new Vector3(leap, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(" key A was released");
            float reverse = leap * -1;
            transform.position += new Vector3(reverse, 0, 0);

        }
    }
}
