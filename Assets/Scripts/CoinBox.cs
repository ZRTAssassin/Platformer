﻿using UnityEngine;
public class CoinBox : HittableFromBelow
{
    [SerializeField] int _totalCoins = 3;



    int _remainingCoins;

    protected override bool CanUse => _remainingCoins > 0;

    void Start()
    {
        _remainingCoins = _totalCoins;
    }

    protected override void Use()
    {
                _remainingCoins--;
        Coin.CoinsCollected++;
        ScoreSystem.Add(100);

    }
}