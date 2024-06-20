using UnityEngine;
using System.Reflection;

public class DrawGaitVector : MonoBehaviour
{
    public float vectorLength = 1.0f; // 벡터의 길이

    void OnDrawGizmos()
    {
        // 발의 위치
        Vector3 footPosition = transform.position;

        // 로컬 좌표계에서 Z축 방향으로 vectorLength만큼 떨어진 위치
        //Vector3 endPosition = transform.TransformPoint(Vector3.forward * vectorLength);
        Vector3 endPosition = transform.TransformPoint(Vector3.forward * Physics.gravity.magnitude * 0.1f);

        // Gizmo 색상 설정
        Gizmos.color = Color.red;

        // 벡터 그리기
        //Gizmos.DrawLine(footPosition, endPosition);
        //Gizmos.DrawSphere(footPosition, 0.01f); // 시작 지점에 작은 구체 그리기
        //Gizmos.DrawSphere(endPosition, 0.01f); // 끝 지점에 작은 구체 그리기
    }
}