using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 3f;
    public float tempRot;

    // Start is called before the first frame update
    void Start()
    {
        tempRot = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        tempRot += rotateSpeed;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, tempRot);
    }
}
