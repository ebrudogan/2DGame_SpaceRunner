using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distance : MonoBehaviour {


	public Text miles;
	public Text milesfinal; 
	public int offset;

	
	// Update is called once per frame
	void Update () {

		miles.text = ((int)transform.position.x).ToString();
	
	}
}
