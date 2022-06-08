using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    [SerializeField] private Text txtScore;
    private float _score;
    public float Score => _score;
    public static ScoreManager Instance => instance;

    private void Awake()
    {
        if (Instance != null) return;
        instance = this;
    }

    private void Start()
    {
        RenderScore();
    }

    public void IncreaseScore(float score)
    {
        _score += score;
        RenderScore();
    }

    private void RenderScore()
    {
        txtScore.text = "Score: " + _score;
    }
}