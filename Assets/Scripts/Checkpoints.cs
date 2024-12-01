using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoints : MonoBehaviour
{
    public List<Checkpoint> checkPoints;

    [SerializeField] private Slider m_Slider;

    private void Awake()
    {
        checkPoints = new List<Checkpoint>(GetComponentsInChildren<Checkpoint>());
    }

    private void Update()
    {
        Time.timeScale = m_Slider.value * 3f;
    }
}
