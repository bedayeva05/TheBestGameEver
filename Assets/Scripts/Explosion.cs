﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Explosion : MonoBehaviour
{
    public float maxSize = 5;
    public float speed = 1;
    public float damage = 50;
    public AudioSource audioSource;
    public void Start()
    {
        transform.localScale  = Vector3.zero;
        audioSource.Play();
    }

    
    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime* speed;

        if(transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.DealDamage(damage);
        }

        var enemyHealth = other.GetComponent<EnemyHealth>();
        if(enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }
}
