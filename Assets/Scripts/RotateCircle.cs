using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    [SerializeField] private float speed;

    void FixedUpdate()
    {
        Vector3 rotation = new Vector3(0f, 0f, speed * Time.deltaTime);
        transform.Rotate(rotation);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
