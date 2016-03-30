using UnityEngine;
using System.Collections;
using UnityEngine.UI; //agrega el ui
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
	Button start;
	// Use this for initialization
	void Start () {
		start = GetComponent<Button> ();
		start.onClick.AddListener (() => goGame ());
	
	}
	void goGame(){
		SceneManager.LoadScene ("2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
