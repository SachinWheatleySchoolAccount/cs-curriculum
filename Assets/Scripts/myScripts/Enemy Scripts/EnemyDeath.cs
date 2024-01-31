using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyDeath : MonoBehaviour
{
    public bool dead;
    public GameObject coins;
    public GameObject health;
    public GameObject axe;
    private int odds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            odds = Random.Range(0, 10);
            if (gameObject.CompareTag("Elite"))
            {
                Instantiate(axe, transform.position, Quaternion.identity);
            }
            if (odds <= 5 && gameObject.CompareTag("Enemy"))
            {
                Instantiate(coins, transform.position, Quaternion.identity);
            }

            if (odds > 5 && odds <= 8 && gameObject.CompareTag("Enemy"))
            {
                Instantiate(health, transform.position, Quaternion.identity);
            }

            if (odds > 8 && odds <= 9 && gameObject.CompareTag("Enemy"))
            {
                Instantiate(coins, transform.position, Quaternion.identity);
                Instantiate(coins, transform.position, Quaternion.identity);
            }

            if (odds > 9 && gameObject.CompareTag("Enemy"))
            {
                Instantiate(coins, transform.position, Quaternion.identity);
                Instantiate(health, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
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
