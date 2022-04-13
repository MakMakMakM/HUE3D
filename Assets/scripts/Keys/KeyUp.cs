using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUp : MonoBehaviour
{
    public KeyData data;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<KeyContainer>().AddKey(data);
            Destroy(this.gameObject, 0.1f);
        }
    }
}
