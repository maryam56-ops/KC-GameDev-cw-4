using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kwtClicker : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public int inc = 1;
    int price = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PressMe()
    {
        score += inc;
        scoreText.text = "knowledge = " + score.ToString();
    }

    public void brain()
    {
        if (score >= price)
        {
            inc++;
            score -= price;
            scoreText.text = "knowledge = " + score.ToString();
        }
    }
}