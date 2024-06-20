using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCylinder : MonoBehaviour
{
    public Rigidbody c;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cPosition = c.position;
        Vector3 offset = new Vector3(0f, 0.175f, 0f);
        rb.position = cPosition + offset;
    }
}
