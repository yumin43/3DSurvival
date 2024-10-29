using System;
using UnityEngine;

public enum ItemType
{
    Equipable,      // 장착 가능 아이템
    Consumable,     // 소비 가능 아이템
    Resource
}

public enum ConsumableType
{
    Health,
    Hunger
}

[Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "newItem", order = 0)]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;       // 여러 개 가지고 있을 수 있는 아이템인지
    public int maxStackAmount;      // 최대 몇개까지 가지고 있을 수 있는지

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;        // 체력과 배고픔 둘 다 회복해줄 수 있기 때문에 배열로
}
