﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cadena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent <CharacterJoint>().connectedBody = transform.parent.GetComponent <Rigidbody>();
	}
	

}
