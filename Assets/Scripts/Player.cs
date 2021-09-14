using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject _projectile;

    private void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(_projectile, transform.position, Quaternion.identity);
        }
    }
}
