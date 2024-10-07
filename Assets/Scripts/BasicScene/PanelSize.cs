using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePanelSize()
    {
        float size = 0.01222169f;
        float slider = GameObject.Find("Slider").GetComponent<Slider>().value;
        float value = size * slider;
        GameObject.Find("DrawerPanel").GetComponent<RectTransform>().localScale = new Vector3(value,value,value);
    }
}
