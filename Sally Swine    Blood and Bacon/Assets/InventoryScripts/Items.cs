using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {  

    public enum ItemType
    {
        Shotgun,
        Scythe,
        Rope,
        Bacon1,
        Coins,
        Key,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType) {
            default:
            case ItemType.Bacon1:     return ItemAssets.Instance.baconSprite;
        }
    }


}
