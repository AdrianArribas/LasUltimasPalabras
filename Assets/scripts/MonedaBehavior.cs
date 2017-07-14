using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonedaBehavior : MonoBehaviour {

	public static int cuentaMonedas = 0;//variable publica global para todas las monedas
	public static int huecopalmera= 2;
	public AudioClip Point;
	private AudioSource SoundPlayer;

	void Start () {
		SoundPlayer = GetComponent <AudioSource>();
		SoundPlayer.enabled = true;
		cuentaMonedas++;
		Debug.Log ("la cantidad de monedas en juego es de "+ cuentaMonedas);

	}

	void Update () {
		
	}
	/*
	void OnTriggerEnter(Collider Collider){
		if (Collider.CompareTag ("Jugador")){
			SoundPlayer.clip = Point;
			SoundPlayer.Play();
			Destroy (gameObject);
			Debug.Log ("He cogido la moneda");
		}

	}
*/
	void OnDestroy(){
		
		cuentaMonedas--;
		Debug.Log ("Monedas actuales: "+ cuentaMonedas);
		if (cuentaMonedas <= 0) {
			Debug.Log ("Has cogido todas las monedas y el juego ha terminado, eres unn jodido maquina");
			GameObject timer = GameObject.Find ("Timer"); //así buscamos objetos por el nombre que les hemos dado
			Destroy (timer);

			GameObject[] fuegosArtificiales = GameObject.FindGameObjectsWithTag ("FuegoArtificial"); //añadimos a un array todos los objetos con el Tag marcado
			foreach (GameObject FuegoArtificial in fuegosArtificiales) {
				FuegoArtificial.GetComponent<ParticleSystem> ().Play ();
			}
		}
	}
}
