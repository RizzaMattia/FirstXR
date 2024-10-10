using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    #region Metodi Public ----
    //Metodo per avviare o stoppare la radio
    public void RadioStartStop() {

        //Contollo se la radio sta suonando in caso la stoppo o viceversa
        if (GameObject.Find("Canzone").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("Canzone").GetComponent<AudioSource>().Stop();
        }
        else {
            GameObject.Find("Canzone").GetComponent<AudioSource>().Play();
        }
        
    }
    #endregion
}
