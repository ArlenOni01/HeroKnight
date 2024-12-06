using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private int damage;
    private Health playerHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "HeroKnight_0")
        {
            collision.GetComponent<Health>().TakeHealth(healthValue);
            gameObject.SetActive(true);
        }
    }
    
    
}