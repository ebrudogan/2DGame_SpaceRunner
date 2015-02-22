﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This scrits makes the character move when the screen is pressed and handles the jump
public class CharacterFinal : MonoBehaviour
{
		public bool jump = false;				// Condition for whether the player should jump.	
		public float jumpForce = 10.0f;			// Amount of force added when the player jumps.
		private bool grounded = false;			// Whether or not the player is grounded.
		public int movementSpeed = 8;			// The vertical speed of the movement
		private Animator anim;					// The animator that controls the characters animations
		public bool slide = false;				// Condition for whether the player is sliding or not.
		private BoxCollider2D characterCollider;

		void Awake ()
		{
				anim = GetComponent<Animator> ();
				characterCollider = gameObject.GetComponent<BoxCollider2D> ();

		}
	

		//This method is called when the character collides with a collider (could be a platform).
		void OnCollisionEnter2D (Collision2D hit)
		{
				grounded = true;
				Debug.Log ("on ground");
		}

		//The update method is called many times per seconds
		void Update ()
		{
				if (Input.GetButtonDown ("Fire1") && grounded) {
						jump = true;
						grounded = false;
						anim.SetTrigger ("Jump");
				} else if (Input.GetButtonDown ("Fire2")) {
						Slide ();
						slide = false;	
				}
		}

		public void Jump ()
		{
				// If the jump button is pressed and the player is grounded and the character is running forward then the player should jump.
				if (grounded == true && slide == false) {
						jump = true;
						grounded = false;
						//We trigger the Jump animation state
						anim.SetTrigger ("Jump");
				}
		}

		public void Slide ()
		{
				if (grounded == true) {
						slide = true;
						//Change the collider size 
						characterCollider.size = new Vector3 (3.7f, 2.5f, 0.0f);
						//We trigger the Jump animation state
						Debug.Log ("Before slıdıng anımatıon");
						anim.SetTrigger ("slide");
				}
				Debug.Log ("After slıdıng anımatıon");
				characterCollider.size = new Vector3 (2.5f, 3.7f, 0.0f);
		} 
	  
		//Since we are using physics for movement, we use the FixedUpdate method
		void FixedUpdate ()
		{
				//if died that 
				rigidbody2D.velocity = new Vector2 (movementSpeed, rigidbody2D.velocity.y);
				//else
				//moving
	
				// If jump is set to true we add a quick force impulse for the jump
				if (jump == true) {
						// Add a vertical force to the player.
						rigidbody2D.AddForce (new Vector2 (0f, jumpForce), ForceMode2D.Impulse);
			
						// We set the variable to false again to avoid adding force constantly
						jump = false;
				}
		}
}
