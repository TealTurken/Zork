using System;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    [SerializeField]
    private TMP_InputField InputField;

    public void ProcessInput()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
