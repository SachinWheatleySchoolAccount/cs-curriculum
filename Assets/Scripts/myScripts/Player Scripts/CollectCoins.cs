using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private HUD gm;
   

    public int coinValue;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<HUD>();
        coinValue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            gm.coins += coinValue;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Axe"))
        {
            gm.axe = true;
            Destroy(other.gameObject);
        }
    }
}
