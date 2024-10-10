using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class KeyOpen : MonoBehaviour, IKey
{
    #region Metodi Public ----
    //Metodo per sbloccare la porta e il traguardo
    public void Open()
    {
        //Permetto la rotazione della porta, la sblocco
        GameObject.Find("Porta").GetComponent<XRGrabInteractable>().enabled = true;
        GameObject.Find("Finish").GetComponent<XRSimpleInteractable>().enabled = true;
    }
    #endregion
    #region Metodi Privati ----
    private void OnCollisionEnter(Collision collision)
    {
        //Se tocco il lettore con la carta diventa verde e sblocca
        if (collision.gameObject.CompareTag("Lettore"))
        {
            //Imposto il lettore verde
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            
            //Eseguo Open
            Open();
        }
    }
    #endregion
}
