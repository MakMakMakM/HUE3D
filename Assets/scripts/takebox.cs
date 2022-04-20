using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takebox : MonoBehaviour
{


    private void OnCollisionEnter(Collision Collision)
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Collision.gameObject.tag == "Player")
            {
                Debug.Log("123");
                transform.parent = Collision.transform;
            }
        }
    }
}
