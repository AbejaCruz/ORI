using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class avanzar_N3 : MonoBehaviour {
public Text respuesta;


 
 public void resultado()
    {
     
    if (respuesta.text.Equals("1010")){
	   SceneManager.LoadScene("Nivel_4");
	    print("Hello ");
    }
    if (respuesta.text.Equals("0000") || respuesta.text.Equals("0001") || respuesta.text.Equals("0010") || respuesta.text.Equals("0011") || respuesta.text.Equals("0100") || respuesta.text.Equals("0110") || respuesta.text.Equals("0111") || respuesta.text.Equals("1000") || respuesta.text.Equals("0101") || respuesta.text.Equals("1001") || respuesta.text.Equals("1011") || respuesta.text.Equals("1100") || respuesta.text.Equals("1101") || respuesta.text.Equals("1110") || respuesta.text.Equals("1111"))
    {
        SceneManager.LoadScene("R_Nivel3");

    }

  }
}