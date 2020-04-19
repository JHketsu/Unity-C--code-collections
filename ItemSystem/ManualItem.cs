using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Manual",menuName = "DP/Item/manual")]
[System.Serializable]
public class ManualItem : ItemBase
{
    public ManualItem(){
        ItemType = ItemType.manual;
    }
}
