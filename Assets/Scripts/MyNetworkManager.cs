using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	void Start() {
	}

	void Update() {
	}
	public void MyStartHost() {
		StartHost();
		Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
	}

	public override void OnStartHost() {
		Debug.Log("Host started at "+ Time.timeSinceLevelLoad);
	}
}
