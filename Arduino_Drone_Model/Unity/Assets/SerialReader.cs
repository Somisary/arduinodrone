using UnityEngine;
using System.IO.Ports;
using System.Collections;

public class SerialReader : MonoBehaviour {

	SerialPort arduino_port = new SerialPort("COM3", 9600);

	// Use this for initialization
	void Start () {
		arduino_port.Open ();
	}
	
	// Update is called once per frame
	void Update () {
		try {
			print(arduino_port.ReadLine());
		}
		catch (System.Exception) {
		}
	}
}
