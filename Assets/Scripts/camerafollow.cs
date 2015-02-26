using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject character; 

	// Update is called once per frame
	void Update () {

		if (character.transform.position.x > gameObject.transform.position.x)
		{
			transform.position= new Vector3(character.transform.position.x, 0f ,0f);
		}
	
	}
}
