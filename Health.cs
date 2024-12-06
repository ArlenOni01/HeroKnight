using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth {get; private set;}
    private Animator anim;
    private bool dead;
    [SerializeField] private AudioSource healSoundEffect;
    [SerializeField] private AudioSource deathSoundEffect;
    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0) 
        {
            anim.SetTrigger("hurt");
        }else{
            if (!dead)
            {
            anim.SetTrigger("die");
            if(GetComponent<PlayMoveBrackey>() != null)
                GetComponent<PlayMoveBrackey>().enabled = false;
            if(GetComponentInParent<AIPatrol>() != null)
                GetComponentInParent<AIPatrol>().enabled = false;
            if(GetComponent<MeleeEnemy>() != null)
                GetComponent<MeleeEnemy>().enabled = false;
            
            dead = true;
            deathSoundEffect.Play();
            }
        }
    }

    public void AddHealth(float _value)
    {
        healSoundEffect.Play();
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    public void TakeHealth(float _value)
    {
        deathSoundEffect.Play();
        currentHealth = Mathf.Clamp(currentHealth - _value, 0, startingHealth);
    }

}
