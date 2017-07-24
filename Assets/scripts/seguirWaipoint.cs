using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class seguirWaipoint : MonoBehaviour {
	public GameObject[] Waypoints;
	public int num = 0;
	public float minDist;
	public float speed;
	public bool rand=false;
	public bool go= true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (gameObject.transform.position, Waypoints [num].transform.position);

		if (go) {
			if (dist > minDist) {
				Move ();
			} else {
				if (!rand) {
					if (num + 1 == Waypoints.Length) {
						num = 0;
					} else {
						num++;
					}
				} else {
					num = Random.Range (0, Waypoints.Length);
				}
			}
		}
	}
					
	public void Move(){
		gameObject.transform.LookAt (Waypoints[num].transform.position);
		gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;

	}

}
