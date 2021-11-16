using System;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        string yes = "Yes".Trim().ToUpper();
    }

    public void WriteLine(object value)
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
