using UnityEngine;
using Zork;
using Zork.Common;

public class GameManager : MonoBehaviour
{

    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game game = Game.Load(gameJsonAsset.text);
        game.Start(Output, Input);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService Output;

    [SerializeField]
    private UnityInputService Input;
}
