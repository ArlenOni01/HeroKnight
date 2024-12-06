using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Answers3 : MonoBehaviour
{
    public string userInput;
    public TMP_InputField inputField;
    public GameObject textDisplay;
    [SerializeField] private AudioSource answerSoundEffect;
    [SerializeField] private AudioSource incorrectSoundEffect;

    public void StoreAnswer()
    {
        string userInput = inputField.text;

        if (userInput == "skull")
        {
            textDisplay.GetComponent<Text>().text = "Congrats, " + userInput + " is the correct answer!!";
            answerSoundEffect.Play();
        }
        else
        {
            textDisplay.GetComponent<Text>().text = userInput + " is incorrect. Please try again.";
            incorrectSoundEffect.Play();
        }
    }
}