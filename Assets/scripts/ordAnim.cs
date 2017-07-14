using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ordAnim : MonoBehaviour {
	bool onarea;
	public Animation animacion;
	bool animado;
	// Use this for initialization
	void Start () {
		onarea = false;
		animado = false;
	}

	// Update is called once per frame
	void Update () {
		if (onarea == true && Input.GetKeyDown (KeyCode.E)){
			animar ();
		}
	}

	void OnTriggerEnter (Collider colision) {
		if (colision.tag == "Jugador" && PickPlayer.carry==false) {
			onarea = true;
			Debug.Log ("jugador detectado" + onarea);
		}

	}

	void OnTriggerExit (Collider colision){
		if (colision.tag == "Jugador") {
			onarea = false;
			Debug.Log ("Jugador fuera del aera" + onarea);
		}

	}

	void animar() {
		if (animado == false) {
			animacion.Play ();
			animado = true;
		}
	}

}
