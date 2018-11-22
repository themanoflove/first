using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//Using Unityengine.UI
public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalScore=4;

    private void Update()
    {
        scoreText.text = string.Format("Score {0}", totalScore);
    }
}
