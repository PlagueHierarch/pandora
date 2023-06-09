using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _rigid;
    public int hp;
    public float speed;
    public float deadTime;


    private void Awake()
    {
        deadTime = 7;
        _rigid = GetComponent<Rigidbody2D>();  
    }

    private void Start()
    {
        Invoke(nameof(Destroy), deadTime);
    }

    public void GetDamage(int dmg)
    {
        hp -= dmg;
        Debug.Log("Current HP:" + hp);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) Destroy();

        _rigid.velocity = Vector2.left * speed;
    }
}
