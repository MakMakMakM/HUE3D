using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    Colors color = Colors.BASE;

    bool active = true;

    MeshRenderer render;
    Collider colider;
    Rigidbody rb;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
        colider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (color == Colors.BASE)
            return;

        if (PlayerController.Player.CurrentColor == color)
        {
            render.enabled = false;
            colider.enabled = false;

            if (rb) rb.useGravity = false;
        }
        else 
        {
            render.enabled = true;
            colider.enabled = true;

            if (rb) rb.useGravity = true;
        }

    }
}
