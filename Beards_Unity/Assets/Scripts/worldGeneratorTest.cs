using UnityEngine;
using System.Collections;

public class worldGeneratorTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Object prefab = AssetBundle.CreateFromFile("Assets/Shaft.prefab");
		//GameObject clone = Instantiate (prefab, Vector3.zero, Quaternion.identity) as GameObject;
		//clone.transform.position = Vector3.one;

		GameObject prefab = (GameObject)Instantiate (Resources.Load("Tiles/Shaft"));
		prefab.transform.position = new Vector3 (0, 0, 3);

		GameObject surface1 = (GameObject)Instantiate (Resources.Load ("Tiles/Surface01"));
		surface1.transform.position = prefab.transform.position + new Vector3 (3, 3, 0);


		GameObject s2 = (GameObject)Instantiate (Resources.Load ("Tiles/Shaft"));
		s2.transform.position = new Vector3 (0, -3, 3);


		GameObject sbottom = (GameObject)Instantiate (Resources.Load ("Tiles/T_Shaft_Bottom"));
		sbottom.transform.position = new Vector3 (0, -6, 3);

		// chambers right (right of the camera)
		GameObject c1 = (GameObject)Instantiate (Resources.Load ("Tiles/Room_1x1_Center"));
		c1.transform.position = new Vector3 (-3, -6, 3);
		GameObject c2 = (GameObject)Instantiate (Resources.Load ("Tiles/Room_1x1_Center"));
		c2.transform.position = c1.transform.position + new Vector3 (-3, 0, 0);

		GameObject c3 = (GameObject)Instantiate (Resources.Load ("Tiles/Room_Left_1x1_LtDoor"));
		c3.transform.position = c2.transform.position + new Vector3 (-3, 0, 0);

		// chambers left
		GameObject l1 = (GameObject)Instantiate (Resources.Load ("Tiles/Room_2x2_Center"));
		l1.transform.position = sbottom.transform.position + new Vector3 (3, 0, 0);

		GameObject l2 = (GameObject)Instantiate (Resources.Load ("Tiles/Room_2x2_Center"));
		l2.transform.position = l1.transform.position + new Vector3 (6, 0, 0);


	}
	
	// Update is called once per frame
	void Update () {

	}
}
