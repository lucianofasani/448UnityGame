using UnityEngine;
using System.Collections;

public class TougherEnemies : MonoBehaviour {
    //public GameObject player;
    private bool dirLeft = true;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x + 5 < GameObject.FindGameObjectWithTag("enemy").transform.position.x && dirLeft) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
    }
}
