using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;
    public AudioSource audioSource;
    private void Start()
    {
        audioSource.Play();
        Invoke("DestroyFireball", lifetime);
    }

    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireball();
    }
    private void DestroyFireball()
    {
        Destroy(gameObject);
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if(enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
            
        }
    }
   
}
