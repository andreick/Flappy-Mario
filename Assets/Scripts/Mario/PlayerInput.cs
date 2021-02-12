﻿using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private ActionGameEvent PlayerTap;
    [SerializeField] private ActionGameEvent OnPlayerLose;

    private void OnEnable()
    {
        OnPlayerLose += Die;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerTap.Trigger();
        }
    }

    private void OnDisable()
    {
        OnPlayerLose -= Die;
    }

    private void Die()
    {
        Debug.Log("input die");
        enabled = false;
    }
}
