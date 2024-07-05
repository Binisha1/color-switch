using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float rotateSpeed = 60;
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
