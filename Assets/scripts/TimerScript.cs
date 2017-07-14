using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {
	public float maxTime = 50.0f;
	private float contDown = 0.0f;
	// Use this for initialization
	void Start () {
		contDown = maxTime;
	}

	
	// Update is called once per frame
	void Update () {
		contDown -= Time.deltaTime; 
		if (contDown <= 0) {
			MonedaBehavior.cuentaMonedas = 0;
			Application.LoadLevel (Application.loadedLevel); //carga el nivel, en este caso carga el nivel ya cargado
		}
	}
}
