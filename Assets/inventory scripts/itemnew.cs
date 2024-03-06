using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Items/NewItem")]

public class itemnew : ScriptableObject
{
    /// <summary>
    /// name of the item
    /// </summary>
    [Tooltip("name of the item")] 
   public new string name;

    /// <summary>
    /// the dexcription of the item
    /// </summary>
    [Tooltip("the dexcription of the item")]

    [TextArea]
    public string description;

    /// <summary>
    /// the side on which the player will hold the item,
    /// "left" "right" "head" "hidden"
    /// </summary>
    [Tooltip("the side on which the player will hold the item,\r\n  \"left\" \"right\" \"head\" \"hidden\" ")]
    public string side;


    ///// <summary>
    ///// the state of the item,, always on if it doesnt have a state
    ///// </summary>
    //[Tooltip("the state of the item,, always on if it doesnt have a state")]
    
    //public bool on = true;

    /// <summary>
    /// the model used to represent this item
    /// </summary>
    [Tooltip("the model used to represent this item")]
    public GameObject model;

    /// <summary>
    /// the function that should this item do if eenabled
    /// </summary>
    [Tooltip("the function that should this item do if eenabled")]
    public MonoScript[] it;

    public Dictionary<List<MonoScript>, List<itemnew>> dic = new Dictionary<List<MonoScript>, List<itemnew>>();

    /// <summary>
    /// the list of items that is required to work(currently it just needs any one of them to work)
    /// </summary>
    [Tooltip("the list of items that is required to work(currently it just needs any one of them to work)")]

    public ListofItemnewList requiredItems2;





    //public ActionReference actionReference;

    //  public Action func; // Public delegate field to hold the function reference

    //// Function to call the stored function from other scripts
    //public void CallFunction()
    //{
    //    if (func != null)
    //    {
    //        func(); // Execute the delegate, triggering the "func" function in the assigned script
    //    }
    //    else
    //    {
    //        Debug.LogWarning("No function assigned to ActionReference.");
    //    }
    //}



}
