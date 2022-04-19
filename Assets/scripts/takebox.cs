using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takebox : MonoBehaviour
{


    private void OnCollisionEnter(Collision Collision)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Collision.gameObject.tag == "Player")
            {
                transform.parent = Collision.transform;
            }
        }
    }
    private void OnCollisionExit(Collision Collision)
    {
        if !(Input.GetKeyDown(KeyCode.LeftShift))  
        {

            if (Collision.gameObject.tag == "Player")
            {
                transform.parent = null;
            }
        }
    }



}
