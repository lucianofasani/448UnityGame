using UnityEngine;
using System.Collections;

public class MegaJumpPowUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.name == "character")
        {
            player.GetComponent<CharacterControllerScript>().jumpForce = 2090;
            Destroy(gameObject);
        }
    }
}
