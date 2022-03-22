using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementKnife : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public bool isMove = false;
    void Update()
    {
        if (isMove)
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
    }
}
