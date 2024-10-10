using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class UnlockDrawer : MonoBehaviour
{
    #region Metodi Public ----
    //Metodo per sbloccare il cassetto
    public void openDrawerOne() {
        GameObject.Find("Cassetto 1").GetComponent<XRGrabInteractable>().enabled = true;
        GameObject.Find("Maniglia1").GetComponent<MeshRenderer>().material.color = Color.green;
    }
    #endregion
}
