using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownCube : MonoBehaviour {

    public float frequency = 1f;
    public float amplitude = 1f;
    Vector3 startPos;
    float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime * Time.timeScale * frequency;
        transform.position = startPos + Vector3.up * Mathf.Sin(elapsedTime) * amplitude;
	}
}
