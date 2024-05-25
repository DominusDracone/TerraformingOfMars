using Assets.scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text tajmer;
    public Text txtFaza;
    public GameObject odabirFaza;
    public static GameManager Instance;
    private Faza faza;
    private IgracScript igrac;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        faza = Faza.odabirFaze;
        IzvrsiFazu();
    }

    private void IzvrsiFazu()
    {
        txtFaza.text = faza.ToString();
        tajmer.text = "0";

        igrac = GameObject.FindGameObjectWithTag("Igrac").GetComponent<IgracScript>();

        switch (faza)
        {
            case Faza.odabirFaze:
                PrikaziOdabirFaze();
                break;
            case Faza.razvoj:
                igrac.OdigrajKartu(Faza.razvoj);
                Debug.Log("1");
                break;
            case Faza.izgradnja:
                igrac.OdigrajKartu(Faza.izgradnja);
                Debug.Log("2");
                break;
            case Faza.akcija:
                Debug.Log("3");
                break;
            case Faza.proizvodnja:
                igrac.Proizvodi();
                Debug.Log("4");
                break;
            case Faza.istrazivanje:
                igrac.VuciKarte(3, 2);
                Debug.Log("5");
                break;
        }
    }

    private void PrikaziOdabirFaze()
    {
        odabirFaza.SetActive(true);
    }

    public void OdabranaFaza(int faza) 
    {
        odabirFaza.SetActive(false);
        switch (faza)
        {
            case 1:
                this.faza = Faza.razvoj;
                break;
            case 2:
                this.faza = Faza.izgradnja;
                break;
            case 3:
                this.faza = Faza.akcija;
                break;
            case 4:
                this.faza = Faza.proizvodnja;
                break;
            case 5:
                this.faza = Faza.istrazivanje;
                break;
        }
        IzvrsiFazu();
    }

    public void PromeniFazu()
    {
        if (!faza.Equals(Faza.istrazivanje))
        {
            faza = faza + 1;
        }
        else
        {
            faza = Faza.odabirFaze;
        }
        
        Debug.Log("Promena faze");
        IzvrsiFazu();
    }

    // Update is called once per frame
    void Update()
    {

    }

}