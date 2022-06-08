using UnityEngine;

public class StateManager : MonoBehaviour
{
    private static StateManager instance;
    private static string HIGHEST_SCORE = "Highest_Score";
    public static StateManager Instance => instance;
    [SerializeField] private Panel panel;
    private float Score => ScoreManager.Instance.Score;
    private float HighestScore => PlayerPrefs.GetFloat(HIGHEST_SCORE);
    private void Awake()
    {
        if (Instance != null) return;
        instance = this;
    }

    public void Win()
    {
        
        panel.Render("Win", HighestScore, Score);
        SaveScore();
    }
    
    public void Lose()
    {
        panel.Render("Lose", HighestScore, Score);
        SaveScore();
    }

    private void SaveScore()
    {
        if (Score > HighestScore)
        {
            PlayerPrefs.SetFloat(HIGHEST_SCORE, Score);
        }
    }
}
