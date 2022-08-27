using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _coins;

    public int Coins => _coins;

    public void AddCoins(int coins)
    {
        _coins += coins;
    }

    public void Buy(int cost)
    {
        _coins -= cost;
    }
}
