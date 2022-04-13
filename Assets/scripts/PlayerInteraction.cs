using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    KeyContainer KeysContainer;

    void Start()
    {
        KeysContainer = GetComponent<KeyContainer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            int layerMask = 1 << 8;

            layerMask = ~layerMask;

            if (Physics.Raycast(transform.position + (Vector3.forward * -0.8f), transform.TransformDirection(Vector3.forward), out hit, 2, layerMask))
            {
                var obj = hit.collider.gameObject;
                Debug.Log(obj.name);
                var isDoor = obj.GetComponent<KeyBlock>();
                Debug.Log(isDoor);
                if (isDoor != null)
                {
                    if (KeysContainer.CheckKey(isDoor.KeyName))
                    {
                        KeysContainer.RemoveKey(isDoor.KeyName);
                        isDoor.DestroyDoor();
                    }
                }
            }
        }
    }

} 

