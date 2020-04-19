using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient",menuName = "DP/Item/Ingredient")]
[System.Serializable]
public class IngredientItem : ItemBase
{
    public IngredientItem(){
        ItemType = ItemType.ingredient;
    }
}

