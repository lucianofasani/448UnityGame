using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EightBitGraphicChange : MonoBehaviour {

	private CharacterControllerScript theController;
	// Use this for initialization
	void Start () {
		theController = FindObjectOfType<CharacterControllerScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "character")
		{
			SceneManager.LoadScene ("Stage3");
			SceneManager.UnloadScene("Stage1");
			Destroy(gameObject);
		}

	}
}
