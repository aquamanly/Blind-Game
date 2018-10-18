using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThing : MonoBehaviour {
	public GameObject score;
	// Use this for initialization
	void Start () {
		score = GameObject.FindGameObjectWithTag("scorecard");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "player")
		{
			score.GetComponentInParent<countingTheHits>().YouWin();
		}
		Destroy(other.gameObject);
	}
}
