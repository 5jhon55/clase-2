using UnityEngine;
using System.Collections;

public class BgScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float height = Camera.main.orthographicSize * 2f;
		float width = height * Screen.width / Screen.height;
		if (gameObject.name == "Fondo") {
			transform.localScale = new Vector3 (width, height, 0);

		} 
		else if (gameObject.name == "Piso") 
		{
			transform.localScale = new Vector3 (width, 2f, 0);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
