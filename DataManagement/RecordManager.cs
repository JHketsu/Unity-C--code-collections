using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 故事进度管理器
/// </summary>
public class RecordManager : MonoBehaviour
{
    private readonly static RecordManager Instance = new RecordManager();
    private int record;
    private RecordManager(){
        record = 0;
    }
    public static RecordManager GetInstance(){
        return Instance;
    }
    public void StoryGoOn(){
        record++;
    }
    public int GetRecord(){
        return record;
    }
    public void ReStart(){
        record = 0;
    }
}
