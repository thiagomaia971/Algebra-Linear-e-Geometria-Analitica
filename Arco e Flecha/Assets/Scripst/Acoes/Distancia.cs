using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Distancia : MonoBehaviour
{

    public GameObject ObjPlano;
    public GameObject ObjReta;
    public GameObject[] ObjsPontoPlano;
    public GameObject[] ObjsPontoReta;
    public GameObject pontaFlecha;

    private string[] EquacaoParam = new string[3];
    private Reta vetorDirecaoReta;
    private Reta[] retasPlano;
    private Reta normal;
    private Plano plano;


    public Text stringTema;
    public Text stringEquacaoParametrica;
    public Text distancia;

    // Use this for initialization
    void Start()
    {
        plano = new Plano();
        retasPlano = new Reta[2];
        retasPlano[0] = new Reta(ObjsPontoPlano[0], ObjsPontoPlano[1]);
        retasPlano[1] = new Reta(ObjsPontoPlano[0], ObjsPontoPlano[2]);

        normal = new Reta();
        normal = plano.CalcularN(retasPlano[0], retasPlano[1]);

        vetorDirecaoReta = new Reta();
        vetorDirecaoReta.x = Mathf.Round(ObjsPontoReta[1].transform.position.x) - (Mathf.Round(ObjsPontoReta[0].transform.position.x));
        vetorDirecaoReta.y = Mathf.Round(ObjsPontoReta[1].transform.position.y) - (Mathf.Round(ObjsPontoReta[0].transform.position.y));
        vetorDirecaoReta.z = Mathf.Round(ObjsPontoReta[1].transform.position.z) - (Mathf.Round(ObjsPontoReta[0].transform.position.z));

        EquacaoParam = vetorDirecaoReta.EquacaoParametrica(ObjsPontoReta[0]);
        stringTema.text = "Parametrica";
        stringEquacaoParametrica.text = "";
        foreach (var item in EquacaoParam)
        {
            stringEquacaoParametrica.text += item;
        }
        print("Reta Direção: " + Mathf.Round(vetorDirecaoReta.x) + ", " + vetorDirecaoReta.y + ", " + vetorDirecaoReta.z);
        print("Normal: " + normal.x + ", " + normal.y + ", " + normal.z);
    }

    // Update is called once per frame
    void Update()
    {

        ChangeText();

        plano = new Plano();
        retasPlano = new Reta[2];
        retasPlano[0] = new Reta(ObjsPontoPlano[0], ObjsPontoPlano[1]);
        retasPlano[1] = new Reta(ObjsPontoPlano[0], ObjsPontoPlano[2]);

        normal = new Reta();
        normal = plano.CalcularN(retasPlano[0], retasPlano[1]);

        vetorDirecaoReta = new Reta();
        vetorDirecaoReta.x = Mathf.Round(ObjsPontoReta[1].transform.position.x) - (Mathf.Round(ObjsPontoReta[0].transform.position.x));
        vetorDirecaoReta.y = Mathf.Round(ObjsPontoReta[1].transform.position.y) - (Mathf.Round(ObjsPontoReta[0].transform.position.y));
        vetorDirecaoReta.z = Mathf.Round(ObjsPontoReta[1].transform.position.z) - (Mathf.Round(ObjsPontoReta[0].transform.position.z));
        plano.EqGeral(ObjsPontoPlano[0]);
        distancia.text = plano.Distancia(pontaFlecha).ToString();
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (stringTema.text)
            {
                case "Eq. Geral Plano":
                    stringTema.text = "Parametrica";
                    stringEquacaoParametrica.text = "";
                    EquacaoParam = vetorDirecaoReta.EquacaoParametrica(ObjsPontoReta[1]);

                    foreach (var item in EquacaoParam)
                    {
                        stringEquacaoParametrica.text += item;
                    }

                    break;

                case "Simetrica":
                    stringTema.text = "Eq. Geral Plano";
                    stringEquacaoParametrica.text = "asd";

                    stringEquacaoParametrica.text = plano.EqGeral(ObjsPontoPlano[0]);
                    print("n " + normal.x + "\n" + ObjsPontoReta[1].transform.position.x + "\n" + plano.x);
                    break;

                case "Parametrica":
                    stringTema.text = "Simetrica";
                    stringEquacaoParametrica.text = vetorDirecaoReta.EquacaoSimetrica(ObjsPontoReta[1]);
                    break;
            }
        }
    }

    public void ChangeText() {
        
    }

}
