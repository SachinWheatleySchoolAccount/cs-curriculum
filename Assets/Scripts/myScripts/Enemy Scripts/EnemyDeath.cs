using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyDeath : MonoBehaviour
{
    public bool dead;

    private int odds;
    // Start is called before the first frame update
    void Start()
    {
        odds = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            if (odds <= 5)
            {
                //Instantiate(coin)
            }

            if (odds > 5 && odds <= 8)
            {
                //Instantiate(Burger)
            }

            if (odds > 8 && odds <= 9)
            {
                //Instantiate(coin x2)
            }

            if (odds > 9)
            {
                //Instantiate(coin)
                //Instantiate(burger)
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            dead = true;
        }
    }
}
