using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickPlayer : MonoBehaviour {

	public Image gameCanvas;
	public Transform Pistola;
	public static bool carry;
	private bool isOnArea;
	private bool isOnDropArea;
	private Transform objetoTransform;
	private Rigidbody objetoRB;

	// Use this for initialization
	void Start () {
		carry = false;
		isOnArea = false;
		isOnDropArea = false;
		objetoTransform = null;
		objetoRB = null;
	}


	/// Update is called once per frame
	void Update () {

		if (carry == true && Input.GetKeyDown (KeyCode.E)){
			TirarObjeto ();
		}

		if (isOnArea == true && Input.GetKeyDown (KeyCode.E) && carry==false) {
			CojerObjero ();
		}

		if (isOnDropArea == true && carry == true && Input.GetKeyDown (KeyCode.E)) {
			monedaDrop ();
		}
	}

	void OnTriggerEnter (Collider colision) {
		if (colision.tag == "moneda" && carry==false) {
			Debug.Log ("jugador detectado");
			objetoRB = colision.gameObject.GetComponent <Rigidbody>();
			objetoTransform = objetoRB.transform;
			Debug.Log ("rigibody capturado");
			isOnArea = true;
		}

		if (colision.tag == "pila" && carry == true) {
			isOnDropArea = true;
			Debug.Log ("Zona drop");
		}



	}

	void OnTriggerExit (Collider colision){
		if (colision.tag == "moneda2") {
			
			Debug.Log ("Jugador fuera del aera");
			isOnArea = false;
		}
		if (colision.tag == "palmera") {
			isOnDropArea = false;
			Debug.Log ("Zona drop");
		}
	}

	void CojerObjero(){
		Debug.Log ("Has cumplido requisitos");
		objetoRB.useGravity = false;
		Vector3 V3 = new Vector3 ( objetoTransform.position.x, Camera.main.transform.position.y, objetoTransform.position.z);
		objetoTransform.position = V3;
		objetoTransform.parent = GameObject.Find ("FPSController").transform;
		//this.transform.parent = GameObject.Find ("firstPersonCharacter").transform;
		carry = true;
		iconoCargaOn ();
	}

	void TirarObjeto(){
		objetoTransform.parent = null;
		objetoRB.useGravity = true;
		objetoRB.AddForce (Camera.main.transform.forward*5,ForceMode.Impulse);
		iconoCaraOf ();
		Invoke ("permiso",1.0f);
	}

	void permiso (){
		carry= false;
		objetoRB = null;
		objetoTransform = null;
	}

	void monedaDrop(){
		Destroy (objetoRB.gameObject);
		//MonedaBehavior.cuentaMonedas--;
		MonedaBehavior.huecopalmera--;
		permiso ();
		Debug.Log ("Has colocado una moneda en la palmera, quedan "+ MonedaBehavior.cuentaMonedas+" monedas y "+ MonedaBehavior.huecopalmera+" huecos libres en la palmera");

	}

	void iconoCargaOn(){
		gameCanvas.enabled = true;
	}
	void iconoCaraOf(){
		gameCanvas.enabled= false;

	}
	/* void OnMouseDown(){
		if (carry == true) {
			carry = false;
			Debug.Log ("FALSE");
		} else {
			Debug.Log ("TRUE");
			carry = true;
		}

		if (carry = true) {
			Debug.Log ("GRAB ON");
			this.GetComponent <Rigidbody> ().useGravity = false;
			Vector3 V3 = Pistola.position;
			this.transform.position = V3;
			this.transform.parent = GameObject.Find ("FPSController").transform;
			//this.transform.parent = GameObject.Find ("firstPersonCharacter").transform;
		} else {
			Debug.Log ("GRAB OFF");
			this.transform.parent = null;
			this.GetComponent <Rigidbody>().useGravity = true;
			this.GetComponent <Rigidbody>().AddForce (Camera.main.transform.forward*5,ForceMode.Impulse);
			//Invoke ("permiso",1.0f);
		}


	}


	void OnMouseUp(){
		this.transform.parent = null;
		GetComponent <Rigidbody>().useGravity=true;

	}
	*/

}