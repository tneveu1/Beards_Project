using UnityEngine;
using System.Collections;

public class testCreate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject instance = (GameObject)Instantiate(Resources.Load("Room_1x1_Center"));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
