using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorynew : MonoBehaviour
{
  
  public  List<item> _inventory = new List<item>  ();


    public void addItem(item new_item)
    {
        if (new_item != null)
            new_item.collect();
        _inventory.Add(new_item);
    }
    public void removeItem(item removed_item)
    {
        if(removed_item != null)
        {
            Debug.Log("item not null");

            removed_item.throwItem();
        _inventory.Remove(removed_item);

        }
    }
}
