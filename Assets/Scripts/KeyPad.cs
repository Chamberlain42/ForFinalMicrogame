using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public AudioSource FeedbackLoop;

    public void EnterPressed()
    {
        GameObject.Find("VendingMachine").GetComponent<MainScript>().DrinkResultVisual();

        GameObject.Find("Keypad").GetComponent<InputLogScript>().ToRecord = "";
        GameObject.Find("Keypad").GetComponent<InputLogScript>().InputRecord.text = "";

        gameObject.GetComponent<MainScript>().Method();

        if (GameObject.Find("VendingMachine").GetComponent<MainScript>().ButtonString.Length >= 3)
        {
            FeedbackLoop.Play();
        }

        if (gameObject.GetComponent<MainScript>().winscore == 0)
        {
            gameObject.GetComponent<MainScript>().Win();
        }
          
        
        
    }
       
}
