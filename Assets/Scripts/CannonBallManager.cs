using System;
using UnityEngine;
using UnityEngine.UI;

public class CannonBallManager : MonoBehaviour
{
    private static CannonBallManager instance;
    [SerializeField] private Text txtQuantity;
    [SerializeField] private float quantity = 10f;
    public float Quantity => quantity;
    public static CannonBallManager Instance => instance;

    private void Awake()
    {
        if (Instance != null) return;
        instance = this;
    }

    private void Start()
    {
        RenderQuantity();
    }

    public bool UseCannonBall()
    {
        if (quantity - 1 >= 0)
        {
            quantity--;
            RenderQuantity();
            return true;
        }
        else
        {
            return false;
        }
    }

    private void RenderQuantity()
    {
        txtQuantity.text = "Cannon Ball: " + quantity;
    }
}