using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDrawerInterface : MonoBehaviour
{
    #region Metodi Public ----
    //Metodo per visualizzare il menu sopra la cassettiera
    public void showUI() {  
        GameObject.Find("DrawerUI").GetComponent<Canvas>().enabled = true;
    }
    #endregion
}
