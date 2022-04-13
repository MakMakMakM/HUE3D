using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController GetUI() { return GameObject.Find("Canvas").GetComponent<UIController>(); }
    
    public GameObject UI;
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Message(string msg)
    {   
        Debug.Log($"Message: {msg}");
    }

    public void UIOn() {
        UI.SetActive(true);
    }

    public void UIOff() {
        UI.SetActive(false);
    }
}