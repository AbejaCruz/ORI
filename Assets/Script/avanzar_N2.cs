using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class avanzar_N2 : MonoBehaviour {
public Text respuesta;
	GameObject NivelP;
	GameObject Nivel2;
	GameObject Nivel3;
 
 public void resultado()
    {
     
		if (respuesta.text.Length == 4 && respuesta.text.Equals("1001")){
			Nivel3 = (GameObject)Instantiate (Resources.Load ("Prefabs/Nivel3"), transform.position, transform.rotation);
			Nivel3.name = "Nivel3";
			Nivel2 = GameObject.Find ("Nivel2");
			Destroy (Nivel2);
			print ("Paso al nivel 3 ");
    }
    
		if (respuesta.text.Length == 4 && !respuesta.text.Equals ("1001"))
		{
			NivelP= (GameObject)Instantiate(Resources.Load("Prefabs/Fail"), transform.position, transform.rotation);
			NivelP.name = "Fail";
			Debug.Log("Perdiste!!!");
		}

    }

  }
