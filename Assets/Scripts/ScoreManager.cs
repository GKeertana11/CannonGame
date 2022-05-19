using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text ScoreText;
    public Text Congratulations;
    public bool isWon;
    void Start()
    {
        isWon = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Score(int value)
    {
        if (isWon == false)
        {
            score = score + value;
            ScoreText.text = score.ToString();
            if (score == 100)
            {
                Congratulations.GetComponent<Text>().enabled = true;
                isWon = true;
            }
        }
        
  
    }
}
