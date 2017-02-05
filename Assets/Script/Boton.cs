using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour {
 public void OnButtonClick()
 {
    SceneManager.LoadScene(1,LoadSceneMode.Additive);
 	//Debug.Log("Clcik");
 }

 public void SiguienteEscena(){
 	SceneManager.LoadScene("Menu");
 }
	
	}
