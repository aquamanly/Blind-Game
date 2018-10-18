using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countingTheHits : MonoBehaviour
{
    public List<int> score = new List<int>();
    public int points;

	public Text scoreboard;

    // Use this for initialization
    void Start()
    {
		scoreboard = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		//points++;
		//score.Add(1);
    }


	public void updateScore(){
		points++;
		score.Add(1);
		scoreboard.text = points.ToString();
	}

	public void YouWin()
	{
		scoreboard.text = "You win!";
		Debug.Log("You Win!");
	}
}
