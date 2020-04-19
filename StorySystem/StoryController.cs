using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 识别一个Story
//注意：只有名字才能是【名字】的形式，否则会识别错误
//需要保证文本是一行名字一行对白的形式
public class StoryController : MonoBehaviour
{

    [Header("UI组件")]
    public Text textLabel;
    public Text nameLabel;
    
    [Header("文本文件")]
    public Story textFile;
    private int index;
    public float textSpeed;

    bool textFinished;
    List<string> textList = new List<string>();
    CanvasGroup buttonGroup;
    // Start is called before the first frame update
    void Start()
    {
        buttonGroup = GameObject.Find("ButtonGroup").GetComponent<CanvasGroup>();
        buttonGroup.interactable = false;
        if(textFile!=null){
            GetText(textFile);
        }
        index = 0;
        textFinished = true;
    }

    // Update is called once per frame
    void Update()
    {
        //TextInputing:
        //Input.touchCount>0 to replace
        if(Input.GetKey(KeyCode.Space) && index==textList.Count)
        {
            index = 0;
            textList.Clear();
            buttonGroup.interactable = true;
            RecordManager.GetInstance().StoryGoOn();
            BagManager.GetInstance().AddManualItem((ManualItem)textFile.Award);//可能报错
            Destroy(gameObject);
            return;
        }
        if(Input.GetKey(KeyCode.Space) && textFinished)
        {
            nameLabel.text = textList[index];
            index++;
            //设置text
            StartCoroutine(SetTextUI());
        }

    }

    void GetText(Story file)
    {
        textList.Clear();
        index = 0;

        var lineData = file.Content.Split('\n');
        foreach (var line in lineData)
        {
            textList.Add(line);
        }
    }
    
    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";
        for(int i=0;i<textList[index].Length;i++)
        {
            textLabel.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true;
        

        index++;
    }

}
