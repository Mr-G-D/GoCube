using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform position;
    public Vector3 offset = new Vector3(0, -4.14f, 1.48f);
    // Update is called once per frame
    void Update()
    {
        transform.position = position.position + offset;
    }


}
