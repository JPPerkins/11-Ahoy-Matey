using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour {
	private NetworkManager networkManager;

	void Start() {
		networkManager = GetComponent<NetworkManager>();
	}

	void Update() {
	}
	public void MyStartHost() {
		networkManager.StartHost();
		Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
	}

	void OnStartHost() {
		Debug.Log("Host started at "+ Time.timeSinceLevelLoad);
	}
}
