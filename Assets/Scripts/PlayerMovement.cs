using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigid;
    public float speed;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigid.velocity = Vector2.down * speed;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigid.velocity = Vector2.up * speed;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigid.velocity = Vector2.right * speed;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid.velocity = Vector2.left * speed;
        }

        else _rigid.velocity = Vector2.zero;

    }
}
