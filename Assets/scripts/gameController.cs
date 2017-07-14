using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

	public Transform pistola;
	public GameObject moneda;
	private Rigidbody monedacuerpo;
	//public float fuerza;
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			//Invoke ("disparar",0);
			Instantiate (moneda.gameObject, pistola.position , Camera.main.transform.rotation);
			//monedacuerpo = moneda.GetComponent <Rigidbody> ();
			//monedacuerpo.AddTorque (lanzamiento,ForceMode.Impulse);
		}
	}

	void disparar () {
		
		//Rigidbody monedacuerpo = moneda.GetComponent <Rigidbody> ();

	}
}
