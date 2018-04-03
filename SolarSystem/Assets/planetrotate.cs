using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetrotate : MonoBehaviour {

    public Transform sun;
    public float speed = 10;
    float rty, rtz;

	// Use this for initialization
	void Start () {
        rty = Random.Range(1, 360);
        rtz = Random.Range(1, 360);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = new Vector3(0, rty, rtz);
        this.transform.RotateAround(sun.position, axis, speed * Time.deltaTime);
	}
}
