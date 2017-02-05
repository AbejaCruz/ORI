using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load_Game : MonoBehaviour {

	// Se crea una Camara de inicio
	Camera MainCamera;

	// Se crea un GameObject referenciado al menu de inicio
	GameObject MStart;

	private Button Buttonplay;

	private StartGame sgame;

	//private Button BtnPlay;
	private bool playing=false;
	// Use this for initialization

	void Awake(){


		// Se crea el Gameobject Maincamera que almacenara el Prefab de CameraStart
		MainCamera = ((GameObject)Instantiate(Resources.Load("Prefabs/CameraStart"), Vector3.zero, Quaternion.identity)).GetComponent<Camera>();
		MainCamera.name = "CameraStart";

		MStart = (GameObject)Instantiate(Resources.Load("Prefabs/StartGame"), transform.position, transform.rotation);
		MStart.name = "StartGame";

		Buttonplay = (Button)GameObject.Find ("StartGame/Canvas/ButtonPlay").GetComponent<Button> ();

		Buttonplay.onClick.AddListener (()=> Play());

		sgame = new StartGame();
	}

	public void Play(){
		sgame.startGame ();

	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
