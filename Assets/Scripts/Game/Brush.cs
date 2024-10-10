using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    #region Variabili ----
    //Variabili per il pannello
    Color colore;
    #endregion

    #region Metodi Private ----
    private void OnCollisionEnter(Collision collision)
    {
        //Controllo se metto il pennello nel colore e lo coloro
        if (collision.gameObject.name.Equals("PaintRed"))
        {
           gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
           colore = Color.red;
        }
        else if (collision.gameObject.name.Equals("PaintBlue")) {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            colore = Color.blue;
        }

        //Coloro quello che il pennello tocca con il colore del pennello
        collision.gameObject.GetComponent<MeshRenderer>().material.color = colore;
    }
    #endregion
}
