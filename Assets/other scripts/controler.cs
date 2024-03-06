using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class controler : MonoBehaviour
{
    List<item> available = new List<item>();
    public List<itemnew> items = new List<itemnew>();


    GameObject interactable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<item>() != null)
        {
            available.Add(other.gameObject.GetComponent<item>());





        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<item>() != null)
        {
            available.Remove(other.gameObject.GetComponent<item>());



        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && GetComponent<inventorynew>()._inventory.Count != 0)
        {
            Debug.Log("got input");


            GetComponent<inventorynew>().removeItem(GetComponent<inventorynew>()._inventory[0]);


        }
        if (Input.GetKeyDown(KeyCode.Q) && available.Count != 0)
        {

            GetComponent<inventorynew>().addItem(available[0]);
            available.RemoveAt(0);


        }


        if (Input.GetKeyDown(KeyCode.G) && searchItemByName("flashLight") != null)
        {

            removeAfterUse( searchItemByName("flashLight").call(GetComponent<inventorynew>()._inventory, 1));

        }

        if (Input.GetKeyDown(KeyCode.F) && searchItemByName("flashLight") != null)
        {
            searchItemByName("flashLight").call(GetComponent<inventorynew>()._inventory, 0);

        }
        if (Input.GetKeyDown(KeyCode.V) && searchItemByName("vr") != null)
        {
            searchItemByName("vr").call(GetComponent<inventorynew>()._inventory, 0);

        }

    }


    item searchItemByName(string searchWord)
    {
     return   GetComponent<inventorynew>()._inventory.Find(item => item._item.name == searchWord);

    }




    void removeAfterUse(List<item> itemsToRemoveaFterUse)
    {
        if (itemsToRemoveaFterUse != null)

            foreach (item _item in itemsToRemoveaFterUse)
            {

                GetComponent<inventorynew>()._inventory.Remove(_item);
                _item.destroy();

            }
    }


}
