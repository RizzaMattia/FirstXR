using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeInteract : MonoBehaviour
{
    bool rotate = false;
    public void ColorChangeOnEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
    public void ColorChangeOnExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    public void destroy()
    {
        Destroy(this);
    }

    public void rotateOnSelect()
    {
        rotate = true;
    }

    private void Update()
    {
        if (rotate)
        {
            transform.Rotate(0.5f, 0, 0);
        }
    }
}
