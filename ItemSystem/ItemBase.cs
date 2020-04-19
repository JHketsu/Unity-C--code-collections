using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : ScriptableObject
{

    [SerializeField]
    private string ID;
    public string _ID{
        get{
            return ID;
        }
    }

    [SerializeField]
    private string name;
    public string Name{
        get{
            return name;
        }
    }

    [SerializeField]
    private ItemType itemType;
    public ItemType ItemType{
        get{
            return itemType;
        }
        protected set{
            itemType = value; //value哪来的
        }
    }


    [SerializeField]
    private Sprite icon;
    public Sprite Icon{
        get{
            return icon;
        }
    }

    [SerializeField, TextArea]
    private string description;
    public string Description{
        get{
            return description;
        }
    }
}
