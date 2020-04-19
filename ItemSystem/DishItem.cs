using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dish",menuName = "DP/Item/Dish")]
[System.Serializable]
public class DishItem : ItemBase
{
    public DishItem(){
        ItemType = ItemType.dish;
    }
}
