using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public cursor cursor;
    public PlayerBulletMovement bullet;
    public float timer;

    public float shotCooldown;
    // Start is called before the first frame update
    void Start()
    {
        shotCooldown = 1.5f;
        timer = shotCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetMouseButton(1))
        {
            if (timer <= 0)
            {
                timer = shotCooldown;
                bullet = Instantiate(this.bullet, transform.position, UnityEngine.Quaternion.identity);
                bullet.bulletSpeed = (Vector2)((cursor.mousePosition - transform.position).normalized*10);
            }
        }
    }
}
