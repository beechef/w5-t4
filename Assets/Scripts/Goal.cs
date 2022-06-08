using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
   [SerializeField] private TextMeshPro txtScore;
   [SerializeField] private float score;

   private void Start()
   {
      txtScore.text = "Score: " + score;
   }

   public void IncreasePoint()
   {
      ScoreManager.Instance.IncreaseScore(score);
      GoalManager.Instance.Die();
      Destroy(gameObject);
   }
}
