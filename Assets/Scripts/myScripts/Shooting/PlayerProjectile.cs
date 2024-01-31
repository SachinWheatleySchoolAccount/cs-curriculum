using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public cursor cursor;
    public PlayerBulletMovement bullet;

    public float shotCooldown;
    // Start is called before the first frame update
    void Start()
    {
        shotCooldown = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (true)
            {
                var position = transform.position;
                bullet = Instantiate(this.bullet, position, UnityEngine.Quaternion.identity);
                bullet.bulletSpeed = (Vector2)((cursor.mousePosition - position).normalized*10);
            }
        }
    }
}
