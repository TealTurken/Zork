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
        OutputText.text = value.ToString();
    }

    public void WriteLine(object value)
    {
        OutputText.text = value.ToString();
    }

    [SerializeField]
    private TextMeshProUGUI OutputText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
