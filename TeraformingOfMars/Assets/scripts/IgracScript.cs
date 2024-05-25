using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IgracScript : MonoBehaviour
{
    //txt polja
    public GameObject uiResursi;
    //atributi
    public int Reputacija { get; set; }
    public int MC { get; set; }
    public int Toplota { get; set; }
    public int Biljke { get; set; }
    public int Celik { get; set; }
    public int Titanijum { get; set; }
    //povecavanje atributa
    public int PrirastajMC { get; set; }
    public int PrirastajToplota { get; set; }
    public int PrirastajBiljke { get; set; }
    public int PrirastajKarte { get; set; }
    

    // Start is called before the first frame update
    void Start()
    {
        Text[] result = uiResursi.GetComponentsInChildren<Text>();
        foreach (Text t in result)
        {
            t.text = "0 (+0)";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
