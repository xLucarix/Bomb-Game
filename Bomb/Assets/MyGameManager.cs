using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour {

    private Game game;

    [SerializeField]
    private int min = 1;

    [SerializeField]
    private int max = 4;

    [SerializeField]
    private int size = 4;

    private MyDisplay display;

    private void Awake()
    {
        display = new MyDisplay();
        game = new Game(min, max, size);
    }

    // Use this for initialization
    void Start () {
        display.ShowRandonmOrder(game.CreateRandomOrder(), size);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
