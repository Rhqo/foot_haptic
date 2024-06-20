using UnityEngine;

public class SphereMovementControlGlobal : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    public Transform sphere1;
    public Transform sphere2;

    void Start()
    {

    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = sphere1.transform.position - sphere2.transform.position;
        transform.Translate(movementDirection * moveSpeed * verticalInput * Time.deltaTime);
    }
}
