using System;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    private static GoalManager instance;
    public static GoalManager Instance => instance;
    public bool IsWin => quantity <= 0;

    [SerializeField] private Transform goalParent;
    private float quantity;

    private void Awake()
    {
        if (Instance != null) return;
        instance = this;
    }

    private void Start()
    {
        quantity = goalParent.childCount;
    }

    public void Die()
    {
        quantity--;
        if (IsWin)
        {
            StateManager.Instance.Win();
        }
    }

}