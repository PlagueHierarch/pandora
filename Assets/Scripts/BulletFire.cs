using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletFire : MonoBehaviour
{

    public GameObject bullet;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            var obj = Instantiate(bullet, transform.position, Quaternion.identity);
            var bulletScript = obj.AddComponent<Bullet>();

            bulletScript.direction = playerMovement.facing;
        }
    }
}
