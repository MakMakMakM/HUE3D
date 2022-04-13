using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyContainer : MonoBehaviour
{
    [SerializeField]
    List<KeyData> keys = new List<KeyData>();

    public void AddKey(KeyData key) {
        keys.Add(key);
    }

    public bool CheckKey(string name) {
        foreach (var key in keys) {
            if (key.Name == name)
                return true;
        }
        return false;
    }

    public void RemoveKey(string name) {
        List<KeyData> data = new List<KeyData>();
        foreach (var key in keys)
        {
            if (key.Name != name)
                data.Add(key);
        }
        keys.Clear();
        keys = data;
    }
}
