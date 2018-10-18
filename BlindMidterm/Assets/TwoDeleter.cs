using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TwoDeleter : MonoBehaviour {
	public GameObject score;
	// Use this for initialization
	void Start () {
		score = GameObject.FindGameObjectWithTag("scorecard");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		//othergameObject.SetActive(false);
		//points++;
		//score.Add(1);
		Destroy(other.gameObject);
		score.GetComponentInParent<countingTheHits>().updateScore();
	}

    void OnCollisionEnter(Collision otherCollider) {
        //Destroy();
        //otherCollider.gameObject.SetActive(false);
		Destroy(otherCollider.gameObject);
		
		score.GetComponentInParent<countingTheHits>().updateScore();
	}
}
