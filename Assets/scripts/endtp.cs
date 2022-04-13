using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endtp : MonoBehaviour
{
    public string level1; 
    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("123");
        if (other.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(level1); 
        }
    }
}   