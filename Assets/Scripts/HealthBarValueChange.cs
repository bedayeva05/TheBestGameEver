using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarValueChange : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public Slider healthbar;
    void Start()
    {
        playerHealth = gameObject.GetComponent<PlayerHealth>();
    }

    
    void Update()
    {
        healthbar.value = playerHealth.value;
    }
}
