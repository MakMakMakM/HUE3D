using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBlock : MonoBehaviour
{
    [SerializeField]
    KeyData RequireKey;

    public string KeyName { get { return RequireKey.Name; } }

    public void DestroyDoor() {
        Destroy(this.gameObject, 0.1f);
    }
}
