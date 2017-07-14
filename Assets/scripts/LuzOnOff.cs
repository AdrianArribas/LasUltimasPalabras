using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzOnOff : MonoBehaviour {
	bool onarea;
	private Light luz;
	// Use this for initialization
	void Start () {
		onarea = false;
		luz=gameObject.GetComponent <Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if (onarea == true && Input.GetKeyDown (KeyCode.E)){
			luces ();
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

	void luces() {
		Debug.Log ("luces!"+luz.enabled);
		if (luz.enabled) {
			luz.enabled = false;
		} else {
			luz.enabled = true; 
		}
	}

}
