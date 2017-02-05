using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject MStart;
	public GameObject city;
	public GameObject player;

	public Camera CameraStart;
	public Camera CameraGame;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void startGame(){

		//GameObject.Find("HUD").active = false;
		GameObject.Find ("MStart").SetActive(false);

		CameraStart=  GameObject.Find ("CameraStart").GetComponent<Camera>();
		//CameraGame =  GameObject.Find ("CameraGame").GetComponent<Camera>();

		CameraStart.transform.position = CameraGame.transform.position;
		CameraStart.transform.rotation = CameraGame.transform.rotation;

		CameraStart.orthographicSize = CameraGame.orthographicSize;
		CameraStart.nearClipPlane = CameraGame.nearClipPlane;

		CameraStart.backgroundColor = CameraGame.backgroundColor;

		CameraGame.enabled = false;
		//CameraGame.GetComponent<AudioListener> ().enabled = false;


		city = (GameObject) Instantiate(Resources.Load("Prefabs/City"), Vector3.zero, Quaternion.identity);
		city.name = "City";

		player = (GameObject) Instantiate(Resources.Load("Prefabs/Player"), Vector3.zero, Quaternion.identity);
		player.name = "Player";

		//CameraStart.gameObject.AddComponent<CameraController> ();

		Destroy (CameraGame);
	}


}