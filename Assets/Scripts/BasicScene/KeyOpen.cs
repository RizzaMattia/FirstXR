using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class KeyOpen : MonoBehaviour, IKey
{
    public void Open()
    {
        //Permetto la rotazione della porta, la sblocco
        GameObject.Find("Porta").GetComponent<XRGrabInteractable>().enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lettore"))
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Open();
        }
    }
}
