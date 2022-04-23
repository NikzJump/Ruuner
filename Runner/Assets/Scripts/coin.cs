using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Text scoreText;

    private float Coin;

    private void Update()
    {
        Coin = ((int)(Player.position.x / 2));
        scoreText.text = Coin.ToString();
    }
}
