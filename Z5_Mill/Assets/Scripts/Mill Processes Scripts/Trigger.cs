﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Trigger
{
    public string TriggerControllerName;
    public int anim;
    public string[] transitionParams;
    public string[] animationName;
    public int[] index;
    public int[] sentenceIndex;

    private int animIndex = 0;
    private int LateAnimIndex = 0;

    public Boolean PlaySequence(TriggerAnimationController controller)
    {
        Boolean val = false;
        Debug.Log("Index: " + animIndex);
        Debug.Log("Transition Params Length: " + transitionParams.Length);
        if (animIndex < transitionParams.Length)
        {
            //Debug.Log("Clip Trigger X: " + index[i] + " and " + controller.Index);

            if (index[animIndex] == controller.Index)
            {
                Debug.Log("Clip Trigger: " + animationName[animIndex] + " and " + transitionParams[animIndex]);
                val = controller.PlayAnimation(transitionParams[animIndex], animationName[animIndex]);

                if (val)
                {
                    Debug.Log("OLIVIER WHYYYYYYY");
                    animIndex++;
                }
            }
        }

        return val;
    }

    public int Anim
    {
        get => anim;
    }

    public string Name
    {
        get => TriggerControllerName;
    }

    public int Index
    {
        get => animIndex;
        set => animIndex = value;
    }

    public int CurrentSentenceIndex()
    {
        int val = sentenceIndex[Index - 1];
        return val;
    }


    public int SentenceIndex()
    {
        int val = sentenceIndex[Index];
        return val;
    }
}
