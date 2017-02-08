using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class avanzar : MonoBehaviour {
public Text respuesta;
	GameObject Nivel2;
	GameObject NivelP;
	GameObject Nivel1;

 
 public void resultado()
    {
		/*Debug.Log (Cadena.Length);
		Debug.Log (Cadena.ToString ());
		Debug.Log (respuesta.text.Length);*/

		if (respuesta.text.Length == 4 && respuesta.text.Equals ("0101")) {
			Nivel2 = (GameObject)Instantiate (Resources.Load ("Prefabs/Nivel2"), transform.position, transform.rotation);
			Nivel2.name = "Nivel2";
			Nivel1 = GameObject.Find ("Nivel1");
			Destroy (Nivel1);
			print ("Paso al nivel 2 ");
		} 
		if (respuesta.text.Length == 4 && !respuesta.text.Equals ("0101"))
		{
			NivelP= (GameObject)Instantiate(Resources.Load("Prefabs/Fail"), transform.position, transform.rotation);
			NivelP.name = "Fail";
			//Nivel1 = GameObject.Find ("Nivel1");
			//Nivel1.SetActive (false);
			Debug.Log("Perdiste!!!");
		}


    /*if (respuesta.text.Equals("0000") || respuesta.text.Equals("0001") || respuesta.text.Equals("0010") || respuesta.text.Equals("0011") || respuesta.text.Equals("0100") || respuesta.text.Equals("0110") || respuesta.text.Equals("0111") || respuesta.text.Equals("1000") || respuesta.text.Equals("1001") || respuesta.text.Equals("1010") || respuesta.text.Equals("1011") || respuesta.text.Equals("1100") || respuesta.text.Equals("1101") || respuesta.text.Equals("1110") || respuesta.text.Equals("1111")){
			NivelP= (GameObject)Instantiate(Resources.Load("Prefabs/Fail"), transform.position, transform.rotation);
			NivelP.name = "Nivel1";
			Debug.Log("Perdiste!!!");

    }*/


  }
}