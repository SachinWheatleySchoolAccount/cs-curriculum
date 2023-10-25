using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private HUD gm;
    public bool iFrames;
    private float timer;
    public float oTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<HUD>();
        oTimer = 1.5f;
        timer = oTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (iFrames)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                iFrames = false;
                timer = oTimer;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(ammount: -2);
        }

        if (other.gameObject.CompareTag("Burger"))
        {
            ChangeHealth(ammount: 3);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Fireball"))
        {
            ChangeHealth(ammount: -3);
        }
}

    void ChangeHealth(int ammount)
    {
        if (!iFrames)
        {
            gm.health += ammount;
            iFrames = true;
        }
    }
}
