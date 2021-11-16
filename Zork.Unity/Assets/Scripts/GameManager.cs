using UnityEngine;
using Zork;
using Zork.Common;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    Game game;
    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        game = Game.Load(gameJsonAsset.text);
        game.Start(OutputService, InputService);
        game.Player.LocationChanged += PlayerLocationChanged;
    }

    private void PlayerLocationChanged(object sender, Room newRoom)
    {
        CurrentLocationText.text = newRoom.ToString();
    }

    void Start()
    {
        CurrentLocationText.text = game.Player.Location.ToString();
        MovesText.text = game.Player.Moves.ToString();
        ScoreText.text = game.Player.Score.ToString();
    }

    void Update()
    {
        
    }

    #region Serialized Fields
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;
    
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    
    [SerializeField]
    private TextMeshProUGUI MovesText;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;
    #endregion serialized fields
}
