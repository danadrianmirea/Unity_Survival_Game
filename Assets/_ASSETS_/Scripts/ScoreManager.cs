﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	// belongs to class not just instance
	public static int score;

	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		score = 0;
	}


	void Update ()
	{
		text.text = "Score: " + score;
	}
}
