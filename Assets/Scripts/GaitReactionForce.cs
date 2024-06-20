using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaitReactionForce : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject arrowPrefab; // 힘을 시각화할 프리팹
    public float arrowScale = 0.1f; // 화살표 크기 조정

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                Vector3 reactionForce = contact.normal * rb.mass * Physics.gravity.magnitude;
                DrawForce(contact.point, reactionForce);
            }
        }
    }

    void DrawForce(Vector3 position, Vector3 force)
    {
        arrowPrefab.SetActive(true);
        arrowPrefab.transform.localScale = new Vector3(arrowScale, arrowScale, force.magnitude * arrowScale);
    }
}
