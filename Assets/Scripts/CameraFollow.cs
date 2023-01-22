using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offsetCamera = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        offsetCamera = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = playerTransform.position + offsetCamera;

        transform.position = newPosition;
    }
}
