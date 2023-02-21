using System;
using UnityEngine;


public class PlayerScore : MonoBehaviour
{

    private int score = 0;
    public event Action<int> OnScoreChanged;
    public void AddScore(int _score){
        score += _score;
        OnScoreChanged?.Invoke(score);
    }

}
