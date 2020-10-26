﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] public Button ON, MainMenu, Next, Facing, Turning, Drill, ToolPost, Tailstock, General;
    [SerializeField] public GameObject TailstockPanel, GeneralPanel, ToolPostPanel;
    [SerializeField] public string intro, facing, turning, drilling;
    private bool SequenceDone;

    void Awake()
    {
        NoInteraction();
    }


    // Update is called once per frame
    public void SetInteractionLevel(string dialogueName)
    {
        NoInteraction();

        if (dialogueName.Equals(facing))
        {
            ON.interactable = true;
            ToolPost.interactable = true;
            Tailstock.interactable = false;
            General.interactable = true;
        }       
        else if (dialogueName.Equals(turning))
        {
            ON.interactable = true;
            ToolPost.interactable = true;
            Tailstock.interactable = false;
            General.interactable = true;
        }
        else if (dialogueName.Equals(drilling))
        {
            ON.interactable = true;
            ToolPost.interactable = true;
            Tailstock.interactable = true;
            General.interactable = true;
        }

    }

    public void Transition(string dialogueName)
    {

        NoInteraction();
        if (SequenceDone)
        {
            Drill.interactable = true;
            Turning.interactable = true;
            Facing.interactable = true;
            MainMenu.interactable = true;
            Next.interactable = true;
        }
        else if (dialogueName.Equals(intro))
        {
            Facing.interactable = true;
        }

        else if (dialogueName.Equals(facing))
        {
            Turning.interactable = true;
        }
        else if (dialogueName.Equals(turning))
        {
            Drill.interactable = true;
        }
        else if (dialogueName.Equals(drilling))
        {
            Drill.interactable = true;
            Turning.interactable = true;
            Facing.interactable = true;
            MainMenu.interactable = true;
            Next.interactable = true;
            SequenceDone = true;

        }
        Debug.Log(intro);
        Debug.Log(dialogueName);

    }

    public void InteractButton(string dialogueName)
    {
        if (dialogueName.Equals(drilling))
        {
            Drill.interactable = true;
        }
        else if (dialogueName.Equals(facing))
        {
            Facing.interactable = true;
        }
        else if (dialogueName.Equals(turning))
        {
            Turning.interactable = true;
        }
    }
    void NoInteraction()
    {
        General.interactable = false;
        ToolPost.interactable = false;
        Tailstock.interactable = false;
        ON.interactable = false;
        Next.interactable = false;
        MainMenu.interactable = false;
        Turning.interactable = false;
        Facing.interactable = false;
        Drill.interactable = false;
        TailstockPanel.SetActive(false);
        ToolPostPanel.SetActive(false);
        GeneralPanel.SetActive(false);
    }
}