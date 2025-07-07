using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoin : ColectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
    }
}
