using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginValidation : MonoBehaviour {

    public InputField tempOU;
    public InputField tempOP;
    GameObject MainMenu;
    
    //InputField tempOP;

    string ou = "abc";
    string op = "123";
    string TU;
    string TP;
	void Start ()
    {
        
        TU = tempOU.GetComponent<InputField>().text;
        TP = tempOP.GetComponent<InputField>().text;

        Debug.Log(TU);
        Debug.Log(TP);
        
    }
	
	
    public void LogInValidation()
    {
        if(tempOU.Equals(ou) && tempOP.Equals(op))
        {
            MainMenu = GameObject.Find("MainScene");
            MainMenu.SetActive(true);
        }
    }

	void Update ()
    {
		
	}
}
