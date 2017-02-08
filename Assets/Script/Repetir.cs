using UnityEngine;
using UnityEngine.SceneManagement;

public class Repetir : MonoBehaviour {
	GameObject Nivel1;
	GameObject Nivel2;
	GameObject Fail;

 public void OnButtonClick()
 {
		Fail= GameObject.Find ("Fail");
		Nivel1 = GameObject.Find ("Nivel1");


		if (Nivel1.activeInHierarchy == true) {
			Fail = GameObject.Find ("Fail");
			Destroy (Fail);
			Nivel1 = GameObject.Find ("Nivel1");
			Destroy (Nivel1);
			Nivel1= (GameObject)Instantiate(Resources.Load("Prefabs/Nivel1"), transform.position, transform.rotation);
			Nivel1.name = "Nivel1";
			Debug.Log ("Papu");
		}

		Nivel2=GameObject.Find("Nivel2");
		if (Nivel2.activeInHierarchy == true) {
			Fail = GameObject.Find ("Fail");
			Destroy (Fail);
			Nivel2 = GameObject.Find ("Nivel2");
			Destroy (Nivel2);
			Nivel2= (GameObject)Instantiate(Resources.Load("Prefabs/Nivel2"), transform.position, transform.rotation);
			Nivel2.name = "Nivel2";
			Debug.Log ("Papu");
		}
			

 }


	}
