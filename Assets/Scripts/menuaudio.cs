﻿using UnityEngine;
using System.Collections;

public class MenuAudio : MonoBehaviour {

	public AudioClip menupopup;

	
	public void Menupopup () {
		audio.PlayOneShot(menupopup, 1.5F);
	}
	
}
