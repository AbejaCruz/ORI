using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
public class Boton_bongoe : MonoBehaviour {


 public void SiguienteEscena(int CambiarEscenaa){
 	SceneManager.LoadScene(CambiarEscenaa);
 	print("hola");
 }
	
	}
