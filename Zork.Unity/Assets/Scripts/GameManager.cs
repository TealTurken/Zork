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
        game.Player.MovesChanged += MovesChanged;
        game.Player.ScoreChanged += ScoreChanged;
    }

    #region Event Handlers
    private void ScoreChanged(object sender, int newScore)
    {
        ScoreText.text = newScore.ToString();
    }

    private void MovesChanged(object sender, int newMoves)
    {
        MovesText.text = newMoves.ToString();
    }

    private void PlayerLocationChanged(object sender, Room newRoom)
    {
        CurrentLocationText.text = newRoom.ToString();
    }
    #endregion event handlers

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
    private TextMeshProUGUI ScoreText; // ensure you use ScoreValueText in Unity
    
    [SerializeField]
    private TextMeshProUGUI MovesText; // ensure you use MovesValueText in Unity

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;
    #endregion serialized fields
}
