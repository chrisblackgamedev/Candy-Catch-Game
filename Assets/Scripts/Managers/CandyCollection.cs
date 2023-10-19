using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CandyCollection : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;
    private int scoreValue = 0;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Candy")
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            SetScore();
        }
    }
    void SetScore()
    {
        score.text = "Score:" + scoreValue;
    }
}
