using Assets.scripts;
using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class IgracScript : MonoBehaviour
{
    //objekti iz editora
    public GameObject uiResursi;
    public GameObject spil;
    public GameObject tabla;
    public GameObject ruka;

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
        AzurirajPrikaz();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void Proizvodi()
    {
        //promena resursa
        MC += PrirastajMC;
        Toplota += PrirastajToplota;
        Biljke += PrirastajBiljke;

        VuciKarte(PrirastajKarte, 0);

        //prikaz resursa
        AzurirajPrikaz();

        Debug.Log("Proizvodio sam");
    }

    private void AzurirajPrikaz()
    {
        Text[] result = uiResursi.GetComponentsInChildren<Text>();

        result[0].text = Reputacija.ToString();
        result[1].text = MC + $" (+{PrirastajMC})";
        result[2].text = Toplota + $" (+{PrirastajToplota})";
        result[3].text = Biljke + $" (+{PrirastajBiljke})";
        result[4].text = PrirastajKarte.ToString();
        result[5].text = Celik.ToString();
        result[6].text = Titanijum.ToString();
    }

    public void VuciKarte(int brVucenih, int brOdbacenih)
    {
        Transform[] pozicije = tabla.GetComponentsInChildren<Transform>();
        for (int i = 0; i < brVucenih; i++)
        {
            GameObject karta = Instantiate(spil, pozicije[i+1].position, spil.transform.rotation);            
        }
        Debug.Log($"Vukao sam {brVucenih} i odbacio sam {brOdbacenih} karata. Jebes padeze.");
    }
    public void OdigrajKartu(Faza razvoj)
    {
        Debug.Log("Odigrao sam kartu");
    }
}
