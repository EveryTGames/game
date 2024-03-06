using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class item : MonoBehaviour
{
    public itemnew _item;
    [SerializeField] Vector3 offset;
   List<dynamic> function = new List<dynamic>();
    public void destroy()
    {
        Destroy(gameObject);
    }
    private void Start()
    {
        //  _item.func = System.Delegate.CreateDelegate(typeof(Action), _item.it.GetClass(), "func") as Action;
        if (_item.it.Length > 0 )
        {

            for (int i = 0; i < _item.it.Length; i ++ )
            {
        dynamic x=    GetComponent(gameObject.AddComponent(_item.it[i].GetClass()).GetType());

           
            function.Add(x);

              //  _item.dic.Add(_item.it[i],);

            }
        }


        if (_item.side == "right")
        {
            offset = new Vector3 { x = 0.47f, y = -0.1f, z = 0.39f };

        }
        if (_item.side == "head")
        {
            offset = new Vector3 { x = 0f, y = 0.3f, z = 0f };

        }
        if (_item.side == "left")
        {
            offset = new Vector3 { x = -0.47f, y = -0.1f, z = 0.39f };

        }
        if (_item.side == "hidden")
        {
            offset = new Vector3 { x = 0f, y = 0f, z = -1f };

        }

    }

    public GameObject collect()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<BoxCollider>().enabled = false;

        transform.SetParent(FindAnyObjectByType<controler>().transform.GetChild(0));
        transform.localPosition = offset;
        transform.localRotation = Quaternion.identity;

        return gameObject;
    }
    public GameObject throwItem()
    {
        transform.SetParent(null);
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("item throwed");

        return gameObject;
    }
    public List<item> call(List<item> inventory,int actionIndex)
    {
        if (_item.it != null)
        {

            List<item> temp = new List<item>();
            Debug.Log(actionIndex);
            if (_item.requiredItems2.ListOfItemNewLis[actionIndex].itemnewLis.Count > 0)
            {

                foreach (itemnew _item in _item.requiredItems2.ListOfItemNewLis[actionIndex].itemnewLis)
                {
                    if (inventory.Find(item => item._item == _item) != null)
                    {
                        temp.Add(inventory.Find(item => item._item == _item));


                    }
                    else
                    {
                        Debug.Log("not enough items");
                        temp.Clear();
                        break;
                    }

                }
            }
            else
            {
                function[actionIndex].func();
                return null;

            }

            if (temp.Count > 0)
            {
            Debug.Log("called");

                function[actionIndex].func();
                return temp;

            }
            else
                return null;

        }
        else
        {
            Debug.LogWarning("there is no function attached to the item on  " + gameObject.name);
            return null;
        }

    }
}
