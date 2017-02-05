using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class escribirNumero : MonoBehaviour {

    private string textoimprimir;
    public Text resultado;

    public void colocar0()
    {
        textoimprimir = "0";
        resultado.text = resultado.text + textoimprimir;
    }
    public void colocar1()
    {
        textoimprimir = "1";
        resultado.text = resultado.text + textoimprimir;
    }
}