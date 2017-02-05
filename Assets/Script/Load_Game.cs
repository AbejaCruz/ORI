using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Game : MonoBehaviour {

	GameObject MStart;
	Camera CameraStart;
	public Vector3 CameraGamePosition; 
	public Quaternion CameraGameRotation;
	private StartGame sgame;
	//private Button BtnPlay;
	private bool playing=false;
	// Use this for initialization

	void Awake(){



		CameraStart = ((GameObject)Instantiate(Resources.Load("Prefabs/CameraStart"), Vector3.zero, Quaternion.identity)).GetComponent<Camera>();
		CameraStart.name = "CameraStart";
		sgame = new StartGame();

		MStart = (GameObject)Instantiate(Resources.Load("Prefabs/MStart"), transform.position, transform.rotation);
		MStart.name = "MStart";
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
