using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "BackWall")
        {
            Destroy(gameObject);
        }
    }
}
