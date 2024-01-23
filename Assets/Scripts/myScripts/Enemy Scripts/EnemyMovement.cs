using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject target;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.Translate((target.transform.position - transform.position).normalized * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject;
        }
    }
}
