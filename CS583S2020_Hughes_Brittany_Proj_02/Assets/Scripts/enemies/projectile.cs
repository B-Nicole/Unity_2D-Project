﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target; 

    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("MainPlayer").transform;
        target = new Vector2(player.position.x, player.position.y);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MainPlayer"))
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    { 
        Destroy(gameObject);
       
    }
}
