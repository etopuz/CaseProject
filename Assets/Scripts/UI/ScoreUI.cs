using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private PlayerScore playerScore;
    private TMPro.TextMeshProUGUI scoreText;

    private void Start() {
        scoreText = GetComponent<TMPro.TextMeshProUGUI>();
    }


    private void UpdateScore(int score){
        scoreText.text = score.ToString();
    }

    private void OnEnable() {
        playerScore.OnScoreChanged += UpdateScore;
    }

    private void OnDisable() {
        playerScore.OnScoreChanged -= UpdateScore;
    }






}
