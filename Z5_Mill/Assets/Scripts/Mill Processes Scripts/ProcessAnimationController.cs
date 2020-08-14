﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessAnimationController : MonoBehaviour
{
    [SerializeField] private List<AnimatorController> operations;
    [SerializeField] private float animSpeed;
    private int m_index;
    private AnimatorController controller;

    void Awake()
    {
        foreach(AnimatorController con in operations)
        {
            con.ActivateAnimator(false);
        }
    }

    public void StartCollsion()
    {
        if (controller != null)
        {
            controller.setAnimSpeed(0);
        }
    }

    public void EndCollision()
    {
        if (controller != null)
        {
            controller.setAnimSpeed(animSpeed);
        }
    }

    public void ChangeAnimator(int index)
    {
        Boolean prevState = false;
        AnimatorController prevController = controller;
        if (controller == null || controller.AnimationDone())
        {
            if(controller != null)
            {
                prevState = controller.AnimationDone();
                controller.ActivateAnimator(false);

            }
            if (index >= 0 && index < operations.Count)
            {
                controller = operations[index];
                controller.ResetAnim(prevState, prevController);
            }
        }
    }

    public int Index
    {
        get => m_index;
    }

}
