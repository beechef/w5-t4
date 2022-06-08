using System;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] private Transform muzzlePoint;
    [SerializeField] private GameObject cannonBallPrefab;
    [SerializeField] private ForceBar forceBar;
    public float maxForce;
    public float forceSpeed;
    public float force;
    private int _forceDir;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            UpdateForce();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            if (!CannonBallManager.Instance.UseCannonBall())
            {
                force = 0f;
                return;
            }

            Fire();
            force = 0f;
        }

        forceBar.UpdateForce(force, maxForce);
    }

    private void Fire()
    {
        GameObject cannonBall = Instantiate(cannonBallPrefab);
        cannonBall.transform.position = muzzlePoint.transform.position;
        cannonBall.transform.rotation = muzzlePoint.transform.rotation;
        cannonBall.GetComponent<CannonBall>().Fire(force);
    }

    private void UpdateForce()
    {
        if (force >= maxForce)
        {
            _forceDir = -1;
        }

        if (force <= 0)
        {
            _forceDir = 1;
        }

        force += forceSpeed * Time.deltaTime * _forceDir;
        if (force >= maxForce) force = maxForce;
        if (force <= 0f) force = 0f;
    }
}