using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
   public Traduccion traduccion;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    
    // Start is called before the first frame update
    void Start()
    {
        text1.text = traduccion.text1;
        text2.text = traduccion.text2;
        text3.text = traduccion.text3;
        text4.text = traduccion.text4;
    }
}
