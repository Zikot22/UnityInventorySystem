using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Sword,
        Coin,
        HealthPotion,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Sword: return ItemAssets.Instance.swordSprite;
            case ItemType.Coin: return ItemAssets.Instance.coinSprite;
            case ItemType.HealthPotion: return ItemAssets.Instance.healthPotionSprite;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default :
            case ItemType.Sword: return false;
            case ItemType.Coin:
            case ItemType.HealthPotion: 
                return true;
        }
    }

    public void Use()
    {
        switch (itemType)
        {
            default:
            case ItemType.Sword: Debug.Log("ITS A SWORD"); break;
            case ItemType.Coin: Debug.Log("Toss a coin"); break;
            case ItemType.HealthPotion: Debug.Log("Healing"); break;
        }
    }
}
