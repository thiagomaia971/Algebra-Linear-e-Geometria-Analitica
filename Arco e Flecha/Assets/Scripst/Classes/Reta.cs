using UnityEngine;
using System.Collections;

public class Reta {

    public float x, y, z;
    
    public Reta(GameObject ObjsPontoRetaA, GameObject ObjsPontoRetaB) {
        this.x = ObjsPontoRetaA.transform.position.x - ObjsPontoRetaB.transform.position.x;
        this.y = ObjsPontoRetaA.transform.position.y - ObjsPontoRetaB.transform.position.y;
        this.z = ObjsPontoRetaA.transform.position.z - ObjsPontoRetaB.transform.position.z;

    }
    public Reta() {

    }

    public double ProdutoEscalar(Reta N, Ponto A) {
        double prod = (N.x * A.x) + (N.y * A.y) + (N.z * A.z);
        return prod;
    }
    

    public string[] EquacaoParametrica(GameObject PontoB) {
        string[] equacaoParametrica = new string[3];
        /*equacaoParametrica[0] = "x = " + Mathf.Round(this.x) + "t + " + Mathf.Round(PontoB.transform.position.x);
        equacaoParametrica[1] = "\ny = " + Mathf.Round(this.y) + "t + " + Mathf.Round(PontoB.transform.position.y);
        equacaoParametrica[2] = "\nz = " + Mathf.Round(this.z) + "t + " + Mathf.Round(PontoB.transform.position.z);*/
        equacaoParametrica[0] = "x = " + this.x + "t + " + PontoB.transform.position.x;
        equacaoParametrica[1] = "\ny = " + this.y + "t + " + PontoB.transform.position.y;
        equacaoParametrica[2] = "\nz = " + this.z + "t + " + PontoB.transform.position.z;

        return equacaoParametrica;
    }

    public string EquacaoSimetrica(GameObject PontoB) {
        /*string equacaoSimetrica = "(x - ("+ Mathf.Round(PontoB.transform.position.x) +"))/"+ Mathf.Round(this.x) +" = "+
                              "(y - ("+ Mathf.Round(PontoB.transform.position.y) +"))/"+ Mathf.Round(this.y) + " = "+
                              "(z - ("+ Mathf.Round(PontoB.transform.position.z) +"))/"+ Mathf.Round(this.z);*/
        string equacaoSimetrica = "(x - (" +PontoB.transform.position.x + "))/" + this.x + " = " +
        "(y - (" + PontoB.transform.position.y + "))/" + this.y + " = " +
        "(z - (" + PontoB.transform.position.z + "))/" + this.z;
        return equacaoSimetrica;
    }

    public string[] EquacaoReduzida(GameObject PontoB) {
        string[] equacaoReduzida = new string[2];
        /*equacaoReduzida[0] = Mathf.Round(this.x) + "y = " + Mathf.Round(this.y) + "x " + (((Mathf.Round(this.y) * Mathf.Round(PontoB.transform.position.x)) + (Mathf.Round(PontoB.transform.position.y) * -1)) * -1)+"\n";
        equacaoReduzida[1] = Mathf.Round(this.x) + "z = " + Mathf.Round(this.z) + "x + " + (((Mathf.Round(this.z) * Mathf.Round(PontoB.transform.position.x)) + (Mathf.Round(PontoB.transform.position.z) * -1)) * -1) ;*/
        equacaoReduzida[0] = Mathf.Round(this.y) + "y = " + Mathf.Round(this.y) + "x " + (((Mathf.Round(this.y) * Mathf.Round(PontoB.transform.position.x)) + (Mathf.Round(PontoB.transform.position.y) * -1)) * -1) + "\n";
        equacaoReduzida[1] = Mathf.Round(this.x) + "z = " + Mathf.Round(this.z) + "x + " + (((Mathf.Round(this.z) * Mathf.Round(PontoB.transform.position.x)) + (Mathf.Round(PontoB.transform.position.z) * -1)) * -1);
        //equacaoReduzida[0] = this.x + "y = " + this.y + "x " + (((this.y * PontoB.transform.position.x) + (PontoB.transform.position.y * -1)) * -1) + "\n";
        return equacaoReduzida;
    }

}
