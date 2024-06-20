using UnityEngine;

public class VectorVisualizer : MonoBehaviour
{
    public Transform origin;  // 벡터의 시작점
    public Vector3 direction;  // 벡터의 방향
    public Color color = Color.red;  // 벡터의 색상
    public float length = 1.0f;  // 벡터의 길이

    void OnDrawGizmos()
    {
        if (origin != null)
        {
            // 벡터의 끝점을 계산합니다.
            Vector3 endPoint = origin.position + direction.normalized * length;
            // 벡터를 그립니다.
            Gizmos.color = color;
            Gizmos.DrawLine(origin.position, endPoint);
            // 벡터의 끝점에 구를 그립니다.
            Gizmos.DrawSphere(endPoint, 0.1f);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (origin != null)
        {
            // 선택되었을 때 벡터를 그립니다.
            Vector3 endPoint = origin.position + direction.normalized * length;
            Gizmos.color = Color.yellow;  // 선택된 벡터의 색상
            Gizmos.DrawLine(origin.position, endPoint);
            Gizmos.DrawSphere(endPoint, 0.1f);
        }
    }
}
