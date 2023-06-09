using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigid;
    public float speed;
    public Vector2 facing;

    private void Awake()
    {
        facing = Vector2.up;
        _rigid = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Vector2 moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.DownArrow)) moveDirection += Vector2.down;
        if (Input.GetKey(KeyCode.UpArrow)) moveDirection += Vector2.up;
        if (Input.GetKey(KeyCode.LeftArrow)) moveDirection += Vector2.left;
        if (Input.GetKey(KeyCode.RightArrow)) moveDirection += Vector2.right;

        moveDirection.Normalize();

        _rigid.velocity = moveDirection * speed;

        if (moveDirection != Vector2.zero) facing = moveDirection;

    }
}
