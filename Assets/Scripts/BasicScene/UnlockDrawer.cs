using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class UnlockDrawer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDrawerOne() {
        GameObject.Find("Cassetto 1").GetComponent<XRGrabInteractable>().enabled = true;
        GameObject.Find("Maniglia1").GetComponent<MeshRenderer>().material.color = Color.green;
    }

}
