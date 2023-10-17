using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]

public class rotateObject : MonoBehaviour
{

    [SerializeField] float rotateSpeedX;
    [SerializeField] float rotateSpeedY;
    [SerializeField] float rotateSpeedZ;

    

    Quaternion originRotation;


    // Start is called before the first frame update
    void Start()
    {
        originRotation = transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        Quaternion rotationX = Quaternion.AngleAxis(rotateSpeedX, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(rotateSpeedY, Vector3.up);
        Quaternion rotationZ = Quaternion.AngleAxis(rotateSpeedZ, Vector3.forward);
        transform.rotation *=   rotationX * rotationY * rotationZ;
    }
}