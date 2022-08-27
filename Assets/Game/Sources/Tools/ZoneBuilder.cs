using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ZoneBuilder : MonoBehaviour
{
    private Factory _factory;

    [Inject]
    public void Constructor(Factory factory)
    {
        _factory = factory;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Wallet wallet))
        {
            Build(wallet);
        }
    }

    private void Build(Wallet wallet)
    {
        if (wallet.Coins >= _factory.GetPaddockCost())
        {
            wallet.Buy(_factory.GetPaddockCost());
            Destroy(gameObject);
            _factory.CreatePaddock(transform.position, transform.rotation);
        }
    }
}