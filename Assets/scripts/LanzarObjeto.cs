using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarObjeto : MonoBehaviour {


	public float fuerzadisparo=10;
	public float tiempoDeVida=5f;
	// Use this for initialization
	void Start () {
		this.GetComponent <Rigidbody>().AddForce (Camera.main.transform.forward*fuerzadisparo,ForceMode.Impulse);
		Destroy (gameObject, tiempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
