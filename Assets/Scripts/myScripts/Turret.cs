using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Projectile bullet;
    private bool canShoot;
    private float timer;

    public float maxTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            canShoot = true;
            timer = maxTimer;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (canShoot == true)
            {
                Projectile b = Instantiate(bullet, transform.position, Quaternion.identity);
                b.GetComponent<Projectile>();
            }
            
        }
    }
}
