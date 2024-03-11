using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    
    public void DealDamage(float damage)
    {
        if(value > 0)
        value -= damage;
    }
}
