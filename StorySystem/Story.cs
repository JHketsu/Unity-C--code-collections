using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 探索故事
/// </summary>
[System.Serializable]
[CreateAssetMenu(fileName = "story",menuName = "DP/Story")]
public class Story : ScriptableObject
{
    [SerializeField]
    private string ID;
    public string _ID{
        get{
            return ID;
        }
    }

    [SerializeField, TextArea]
    private string content;
    public string Content{
        get{
            return content;
        }
    }

    [SerializeField]
    private ItemBase award;
    public ItemBase Award{
        get{
            return award;
        }
        set{
            award = value;
        }
    }
}
