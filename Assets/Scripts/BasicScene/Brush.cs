using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    Color pennelloColor;
    // Start is called before the first frame update
    void Start()
    {
        pennelloColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("PaintRed"))
        {
           pennelloColor = Color.red;
        }
        else if (collision.gameObject.name.Equals("PaintBlue")) {
            pennelloColor = Color.blue;
        }

        collision.gameObject.GetComponent<MeshRenderer>().material.color = pennelloColor;
    }
}
