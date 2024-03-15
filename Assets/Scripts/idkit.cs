using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idkit : MonoBehaviour
{
    public float healMount;
    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if(playerHealth != null)
        {
            playerHealth.value += healMount;
            Destroy(gameObject);
        }
    }


}
