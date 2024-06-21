using UnityEngine;

public class CylinderConnector : MonoBehaviour
{

    public Transform topSphere;
    public Transform bottomSphere;

    [Range(0, 1)]
    public float lerpFactor = 0f;
    public float lerpSpeed = 2f; // lerpFactor ���� �ӵ�

    private Transform cylinder;

    public Transform Cone;
    public GameObject ConeObject;

    public Transform toe;
    public Transform toe2;

    void Start()
    {
        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform;

        InitializeCylinder(cylinder);
    }

    void Update()
    {
        // ����Ű ��/�Ʒ� �Է� ����
        if (Input.GetKey(KeyCode.UpArrow))
        {
            lerpFactor -= lerpSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            lerpFactor += lerpSpeed * Time.deltaTime;
        }

        // lerpFactor ���� 0�� 1 ���̷� ����
        lerpFactor = ((toe.position.y) / 0.52f - 0.5f)*2f;
        
        if (lerpFactor == 1f)
        {
            ConeObject.SetActive(false);
        }
        else
        {
            ConeObject.SetActive(true);
        }

        Vector3 lerpedPosition = Vector3.Lerp(topSphere.position, bottomSphere.position, lerpFactor);
        UpdateCylinder(cylinder, bottomSphere.position, lerpedPosition);

    }

    void InitializeCylinder(Transform cylinder)
    {
        cylinder.localScale = new Vector3(0.05f, 0.3f, 0.05f); // �ʱ� ������ ����
    }

    void UpdateCylinder(Transform cylinder, Vector3 start, Vector3 end)
    {
        // �� ���� �߰� �������� �̵�
        cylinder.position = (start + end) / 2;
        Cone.transform.position = end;

        // �� �� ������ �Ÿ��� �������� ����
        float distance = Vector3.Distance(start, end);
        cylinder.localScale = new Vector3(0.05f, distance / 2, 0.05f);

        // �� ���� �մ� �������� ȸ��
        cylinder.up = end - start;
        Cone.transform.forward = cylinder.up;
    }
}
