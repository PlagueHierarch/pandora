using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody2D _rigid;
    public float speed;
    public Vector2 direction;
    public float deadTime;
    public int damage;

    private void Awake()
    {
        speed = 20;
        deadTime = 2;
        damage = 5;
        _rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        _rigid.velocity = direction * speed;
        Invoke(nameof(Destroy), deadTime);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().GetDamage(damage);
            Destroy();
        }
    }
}
