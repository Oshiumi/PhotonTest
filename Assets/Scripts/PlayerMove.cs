using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float speed = 10.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   this.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);
	}
}
