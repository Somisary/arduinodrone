using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

	// Use this for initialization
	public Rigidbody N_motor;
	public Rigidbody S_motor;
	public Rigidbody E_motor;
	public Rigidbody W_motor;
	public float Thrust_Per_Throttle;
	private float N_thrust, S_thrust, W_thrust, E_thrust;

	void OnMessageArrived(string msg)
	{
		int throttle = int.Parse (msg);
		float thrust = Get_Thrust_From_Throttle (throttle);
		print (thrust);
		Set_Throttle (thrust/4, thrust/4, thrust/4, thrust/4);
	}

	void OnConnectionEvent(bool success)
	{
		if (success)
			Debug.Log("Connection established");
		else
			Debug.Log("Connection attempt failed or disconnection detected");
	}

	void Start () {
		GetComponent<Rigidbody>().AddForce (0.0f, 5.0f, 0.0f);
	}

	float Get_Thrust_From_Throttle(float throttle) {
		return (throttle/255.0f) * Thrust_Per_Throttle;
	}

	void Set_Throttle (float n, float s, float e, float w) {
		N_thrust = n;
		S_thrust = s;
		E_thrust = e;
		W_thrust = w;
	}

	void Update () {
		N_motor.AddRelativeForce (N_thrust * Vector3.up);
		S_motor.AddRelativeForce (S_thrust * Vector3.up);
		E_motor.AddRelativeForce (E_thrust * Vector3.up);
		W_motor.AddRelativeForce (W_thrust * Vector3.up);
	}
}
