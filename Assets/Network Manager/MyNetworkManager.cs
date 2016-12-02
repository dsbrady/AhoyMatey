using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost() {
		Debug.Log(Time.timeSinceLevelLoad + ": Starting host");
		StartHost();
	}

	public override void OnClientConnect(NetworkConnection conn) {
		Debug.Log(Time.timeSinceLevelLoad + ": Client Connected to " + conn.address);
	}

	public override void OnStartClient(NetworkClient client) {
		Debug.Log(Time.timeSinceLevelLoad + ": Client Start requested " );
		InvokeRepeating("PrintDots", 0f, 1f);
	}

	public override void OnStartHost() {
		Debug.Log(Time.timeSinceLevelLoad + ": Host started");
		CancelInvoke();
	}

	void PrintDots() {
		Debug.Log(".");
	}
}
