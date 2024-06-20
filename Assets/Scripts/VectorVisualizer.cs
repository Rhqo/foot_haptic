using UnityEngine;

public class VectorVisualizer : MonoBehaviour
{
    public Transform origin;  // ������ ������
    public Vector3 direction;  // ������ ����
    public Color color = Color.red;  // ������ ����
    public float length = 1.0f;  // ������ ����

    void OnDrawGizmos()
    {
        if (origin != null)
        {
            // ������ ������ ����մϴ�.
            Vector3 endPoint = origin.position + direction.normalized * length;
            // ���͸� �׸��ϴ�.
            Gizmos.color = color;
            Gizmos.DrawLine(origin.position, endPoint);
            // ������ ������ ���� �׸��ϴ�.
            Gizmos.DrawSphere(endPoint, 0.1f);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (origin != null)
        {
            // ���õǾ��� �� ���͸� �׸��ϴ�.
            Vector3 endPoint = origin.position + direction.normalized * length;
            Gizmos.color = Color.yellow;  // ���õ� ������ ����
            Gizmos.DrawLine(origin.position, endPoint);
            Gizmos.DrawSphere(endPoint, 0.1f);
        }
    }
}
