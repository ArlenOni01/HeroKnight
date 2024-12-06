using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoldPot : MonoBehaviour
{
    public GameObject dialogueBox;
    public bool playerInRange;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q") && playerInRange)
        {
            if(dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }else{
                dialogueBox.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("HeroKnight_0"))
        {
            playerInRange = true;
            if(GetComponent<PlayMoveBrackey>() != null)
                GetComponent<PlayMoveBrackey>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("HeroKnight_0"))
        {
            playerInRange = false;
            dialogueBox.SetActive(false);
        }
    }
}
