using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

public class Turret : MonoBehaviour
{
    public Projectile bullet;
    private Collider2D target = null;
    private float timer;
    private bool IsOn = false;
    public float shootTimer;
    // Start is called before the first frame update
    void Start()
    {
        shootTimer = 0.5f;
        timer = shootTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (target != null)
            {
                Projectile bullet = Instantiate(this.bullet, transform.position, UnityEngine.Quaternion.identity);
                bullet.bulletSpeed = (Vector2)((target.gameObject.transform.position - transform.position).normalized*10);
            }

            timer = shootTimer;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other;
            IsOn = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            IsOn = false;
        }
    }
}
