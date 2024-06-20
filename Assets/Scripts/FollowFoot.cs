using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFoot : MonoBehaviour
{
    public Transform foot;
    Transform rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 footPosition = foot.position;
        Vector3 offset = new Vector3(0f, 0.15f, 0f);
        rb.position = footPosition + offset;

        Vector3 angleOffset = new Vector3(0, 0, 0);
        Vector3 footRotation = foot.rotation.eulerAngles;
        rb.rotation = Quaternion.Euler(footRotation + angleOffset);

        //RaycastHit hit;
        //if (Physics.Raycast(foot.position, Vector3.down, out hit))
        //{
        //    Vector3 normal = hit.normal;

        //    // Convert the normal to a rotation
        //    Quaternion normalRotation = Quaternion.FromToRotation(Vector3.up, normal);

        //    // Apply the rotation
        //    rb.rotation = normalRotation;
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector3 newSize = new Vector3(0.03f, 0.3f, 0.03f);
            rb.localScale = newSize;
        }
    }

}
