using UnityEngine;
using UnityEngine.UI;

public class ForceBar : MonoBehaviour
{
    [SerializeField] private Slider forceBar;

    public void UpdateForce(float force, float maxForce)
    {
        forceBar.value = (force / maxForce);
    }
}
