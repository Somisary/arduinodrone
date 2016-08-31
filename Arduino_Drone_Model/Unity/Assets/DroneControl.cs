using UnityEngine;
using System.Collections;

public class DroneControl : MonoBehaviour {

	private float throttle = 0;

	// Use this for initialization
	void Start () {
	
	}

	void OnMessageArrived(string msg)
	{
		int throttle = int.Parse (msg);
		this.Set_Throttle (throttle);
	}

	void OnConnectionEvent(bool success)
	{
		if (success)
			Debug.Log("Connection established");
		else
			Debug.Log("Connection attempt failed or disconnection detected");
	}

	public void Set_Throttle (int amount) {
		throttle = (float)amount / 40.0f;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForceAtPosition (Vector3.up*throttle, transform.position, ForceMode.Force);
	}
}
