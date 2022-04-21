using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 180.0f;

    void Update()
    {
        this.transform.rotation *= Quaternion.AngleAxis(rotateSpeed * Time.deltaTime, Vector3.up);
    }
}
