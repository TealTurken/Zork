using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zork.Common;
using TMPro;
using System.Linq;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    #region Serialized Fields
    [SerializeField]
    private int MaxEntries = 60;

    [SerializeField]
    private Transform OutputContainer;

    [SerializeField]
    private TextMeshProUGUI OutputTextPrefab;

    [SerializeField]
    private Image OutputNewLinePrefab;

    #endregion serialized fields
    public void Start()
    {
        Write("Welcome to Zork!");
    }
    private readonly List<GameObject> Entries;
    public UnityOutputService()
    {
        Entries = new List<GameObject>();
    }
    
    public void Clear()
    {
        foreach (GameObject Entry in Entries)
        {
            Destroy(Entry);
        }
    }

    public void Write(string value)
    {
        var textObject = GameObject.Instantiate(OutputTextPrefab);
        textObject.transform.SetParent(OutputContainer, false);
        OutputTextPrefab.text = value;
        Entries.Add(OutputTextPrefab.gameObject);
    }
    public void WriteLine(string value)
    {
        ParseAndWrite(value);
    }

    private void ParseAndWrite(string value)
    {
        string[] delimiters = { "\n" };

        var lines = value.Split(delimiters, StringSplitOptions.None);
        foreach (var line in lines)
        {
            if (Entries.Count >= MaxEntries)
            {
                var mEntry = Entries.First();
                Destroy(mEntry);
                Entries.Remove(mEntry);
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                NewLiner();
            }

            else Prefaber(line);
        }

    }

    public void NewLiner()
    {
        var newLineObject = GameObject.Instantiate(OutputNewLinePrefab);
        newLineObject.transform.SetParent(OutputContainer, false);
        Entries.Add(newLineObject.gameObject);
    }
    public void Prefaber(string value)
    {
        /* To add to the content box of the scroll view in Unity,
         * create a variable assigned to a newly created Unity GameObject and instantiate it.
         * Then assing it a parent and have it share it's parent's transform (bool for if it stays in place).
         * Then assign your output text value to the text content of the new GameObject.
         * Last, add the object as an Entry in the list of text entry GameObjects
         */
        var textObject = GameObject.Instantiate(OutputTextPrefab);
        textObject.transform.SetParent(OutputContainer, false);
        OutputTextPrefab.text = value;
        Entries.Add(OutputTextPrefab.gameObject);
    }
}
