﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour {

    public float timer;

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 0.5)
        {
            GetComponent<Text>().enabled = true;
        }

        if (timer >= 1)
        {
            GetComponent<Text>().enabled = false;
            timer = 0;
        }
	}
}
