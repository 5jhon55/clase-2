using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerJump : MonoBehaviour {
	Rigidbody2D body;
	Button jumpButton;
	bool salto;
	float jumpPower=12f;
	// Use this for initialization
	void Start () {
	
		body = GetComponent<Rigidbody2D> ();
		jumpButton = GameObject.Find ("Salta").GetComponent<Button>();
		jumpButton.onClick.AddListener (() => jump());
		salto = false;
	}
	void jump()
	{
		if (salto) {
			salto = false;
			body.velocity = new Vector2 (body.velocity.x, jumpPower);
		}
	}

	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (body.velocity.y) == 0) {
			salto = true;
		}
	
	}
}
