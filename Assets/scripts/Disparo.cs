using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public Transform Pistola;
	public bool armaActiva = true;
	public GameObject bala;
	public float fuerzadisparo = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (armaActiva==true && Input.GetKeyDown (KeyCode.Mouse0)){
			Invoke ("disparo",0);
		}
			
	}

	void disparo(){
		Instantiate (bala, Pistola.position, Quaternion.identity);

	}
		
}