using UnityEngine;
using System.Collections;

public class simplePanCamera : MonoBehaviour {

	public float panSpeed = 10;
	public float zoomInZ = 8;
	public float zoomOutZ = 22;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
				
		
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.up * panSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.right * panSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.left * panSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down * panSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Q)) {
			transform.position = (new Vector3 (transform.position.x,transform.position.y,zoomInZ));
		}
		if (Input.GetKey (KeyCode.E)) {
			transform.position = (new Vector3 (transform.position.x,transform.position.y,zoomOutZ));
		}
	}
}
