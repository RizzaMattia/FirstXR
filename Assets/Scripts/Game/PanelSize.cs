using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSize : MonoBehaviour
{
    #region Metodi Public ----
    //Metodo per cambiare la dimensione del panel
    public void changePanelSize()
    {
        //Valore da diminuire
        float size = 0.01222169f;

        //Valore dello slide
        float slider = GameObject.Find("Slider").GetComponent<Slider>().value;
        //Diminuisco o aumento lo slide
        float value = size * slider;

        //Imposto il valore allo slide
        GameObject.Find("DrawerPanel").GetComponent<RectTransform>().localScale = new Vector3(value,value,value);
    }
    #endregion
}
