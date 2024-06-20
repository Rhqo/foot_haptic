using UnityEngine;
using System.Reflection;

public class DrawGaitVector : MonoBehaviour
{
    public float vectorLength = 1.0f; // ������ ����

    void OnDrawGizmos()
    {
        // ���� ��ġ
        Vector3 footPosition = transform.position;

        // ���� ��ǥ�迡�� Z�� �������� vectorLength��ŭ ������ ��ġ
        //Vector3 endPosition = transform.TransformPoint(Vector3.forward * vectorLength);
        Vector3 endPosition = transform.TransformPoint(Vector3.forward * Physics.gravity.magnitude * 0.1f);

        // Gizmo ���� ����
        Gizmos.color = Color.red;

        // ���� �׸���
        //Gizmos.DrawLine(footPosition, endPosition);
        //Gizmos.DrawSphere(footPosition, 0.01f); // ���� ������ ���� ��ü �׸���
        //Gizmos.DrawSphere(endPosition, 0.01f); // �� ������ ���� ��ü �׸���
    }
}