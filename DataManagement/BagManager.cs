using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 单例模式-饿汉模式
/// 背包物品管理:增加和删除
/// 提供：背包的获取
/// 原料背包的计数功能（暂不实现）
/// </summary>

public class BagManager : MonoBehaviour{
    private readonly static BagManager instance = new BagManager();
    private List<ManualItem> manualBag;
    private List<IngredientItem> ingredientBag;
    private List<DishItem> dishBag;
    private BagManager(){
        manualBag = new List<ManualItem>();
        ingredientBag = new List<IngredientItem>();
        dishBag = new List<DishItem>();
    }
    public static BagManager GetInstance(){
        return instance;
    }
    
    public List<ManualItem> GetManualBag(){
        return manualBag;
    }
    public List<IngredientItem> GetIngredientBag(){
        return ingredientBag;
    }
    public List<DishItem> GetDishBag(){
        return dishBag;
    }
    public void AddManualItem(ManualItem item){
        manualBag.Add(item);
    }
    public void RemoveManualItem(ManualItem item){
        if(manualBag.Contains(item)){
            manualBag.Remove(item);
        }
    }
    
    public void AddIngredientItem(IngredientItem item){
        ingredientBag.Add(item);
    }
    public void RemoveIngredientItem(IngredientItem item){
        if(ingredientBag.Contains(item)){
            ingredientBag.Remove(item);
        }
    }

    public void AddDishItem(DishItem item){
        dishBag.Add(item);
    }
    public void RemoveDishItem(DishItem item){
        if(dishBag.Contains(item)){
            dishBag.Remove(item);
        }
    }


}