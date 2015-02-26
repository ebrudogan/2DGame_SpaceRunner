using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	public void RestartGame()
	{
		Invoke("PerformRestart", 0.5f);
	}
	
	void PerformRestart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
