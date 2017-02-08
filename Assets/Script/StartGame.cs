using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject city;
	public GameObject player;
	GameObject StartG;


	public Camera MainCamera;


	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void startGame(){

		// Se Destruye el Menu de inicio del Juego
		StartG= GameObject.Find ("StartGame");
		Destroy (StartG);


		// Se instancia el Menu de Seleccion y se carga en el GameObject
		MainMenu = (GameObject) Instantiate(Resources.Load("Prefabs/MenuGame"), Vector3.zero, Quaternion.identity);
		MainMenu.name = "MenuGame";

		//MainCamera=  GameObject.Find ("CameraStart").GetComponent<Camera>();


		//MainCamera.enabled = false;











	//	Destroy (CameraGame);
	}


}