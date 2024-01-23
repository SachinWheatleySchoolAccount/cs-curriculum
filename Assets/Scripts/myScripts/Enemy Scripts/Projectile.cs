using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 bulletSpeed;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        transform.Translate(bulletSpeed * Time.deltaTime);
        if (timer >= 3)
        {
            Destroy(gameObject);
        }
    }
}
