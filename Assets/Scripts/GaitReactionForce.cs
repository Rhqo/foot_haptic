using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaitReactionForce : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject arrowPrefab; // ���� �ð�ȭ�� ������
    public float arrowScale = 0.1f; // ȭ��ǥ ũ�� ����

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
