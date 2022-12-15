using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string ButtonChar;

    public void OnPress()
    {
        GameObject.Find("Keypad").GetComponent<InputLogScript>().ToRecord += ButtonChar;

        GameObject.Find("VendingMachine").GetComponent<MainScript>().ButtonString += ButtonChar;
        Debug.Log(ButtonChar);
        
    }
}
