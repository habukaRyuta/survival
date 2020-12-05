using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //移動方向
    [SerializeField] private Vector3 velocity;

    //移動速度
    [SerializeField] private float moveSpeed = 1.0f;

    void Update()
    {
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.z += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x -= 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.z -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x -= 1;
        }

        //いずれの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}
