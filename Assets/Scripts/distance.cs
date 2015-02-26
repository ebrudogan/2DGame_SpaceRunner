using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{


		public Text miles;
		public Text milesfinal; 
		private bool isEnteredLevel = false;		//Whether or not player entered the level 
	
		// Update is called once per frame
		void Update ()
		{
				//If player entered the level start counting its distance according to X axis movement
				if (isEnteredLevel) {
						miles.text = ((int)transform.position.x - 18).ToString ();
				}
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				//If player triggered, it's entered the level
				Debug.Log ("Entered Level!");
				isEnteredLevel = true;
		}
}
