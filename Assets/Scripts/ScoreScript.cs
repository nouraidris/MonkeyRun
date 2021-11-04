using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        
    }

    // Update is called once per frame
   public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }
}
