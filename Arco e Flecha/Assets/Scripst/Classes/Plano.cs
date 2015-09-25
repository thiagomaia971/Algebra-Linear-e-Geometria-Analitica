using UnityEngine;
using System.Collections;

public class Plano {

    Ponto A, B, C;
    Reta N;
    string eqGeral;
    public float x, y, z;
    public double dist1;


    public Plano() {
        
    }

    public Reta CalcularN(Reta AB, Reta AC) {
        Reta N = new Reta();

        N.x = (AB.y * AC.z) - (AB.z * AC.y);
        N.y = -(AB.x * AC.z) - (AB.z * AC.x);
        N.z = (AB.x * AC.y) + (AB.y * AC.x);
        this.N = N;
        return N;

    }

    public string EqGeral(GameObject PontoA) {
        string eqGeral = N.x+"x "+(N.x * (Mathf.Abs(PontoA.transform.position.x)*-1)) + N.y+" +y"+(N.y * (Mathf.Abs(PontoA.transform.position.y)*-1)) + N.z+" z"+(N.z * (Mathf.Abs(PontoA.transform.position.z)*-1)) +" = 0";
        this.eqGeral = eqGeral;
        x = N.x * PontoA.transform.position.x * -1;
        y = N.y * (PontoA.transform.position.y * -1);
        z = N.z * (PontoA.transform.position.z * -1);
        return eqGeral;
    }

    public double Distancia(GameObject PontoAB) {
        
        double distancia = 0;
        double dist1 = (N.x * PontoAB.transform.position.x) + (N.y * PontoAB.transform.position.y) + (N.z * PontoAB.transform.position.z) + (this.x + this.y + this.z);
        //double dist1 = (N.x * (PontoAB.transform.position.x * -1)) + (N.y * PontoAB.transform.position.y) + (N.z * PontoAB.transform.position.z) + (this.x + this.y + this.z) ;
        this.dist1 = dist1;
        double dist2 = Mathf.Sqrt(Mathf.Pow(N.x,2) + Mathf.Pow(N.y, 2) + Mathf.Pow(N.z, 2));
        return distancia = (dist1/dist2)*-1;
    }

}
