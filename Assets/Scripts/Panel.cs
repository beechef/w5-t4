using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Text txtState;
    [SerializeField] private Text txtHighestScore;
    [SerializeField] private Text txtCurrentScore;

    private void Start()
    {
        SetVisible(false);
    }

    public void Render(string state, float highestScore, float currentScore)
    {
        txtState.text = state;
        txtHighestScore.text = highestScore.ToString();
        txtCurrentScore.text = currentScore.ToString();
        SetVisible(true);
    }

    private void SetVisible(bool isVisible)
    {
        canvasGroup.alpha = isVisible ? 1f : 0f;
        Cursor.visible = isVisible;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Scene_01");
    }
}
