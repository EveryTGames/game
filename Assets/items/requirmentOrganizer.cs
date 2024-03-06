using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class itemnewList
{
    public List<itemnew> itemnewLis = new List<itemnew>();
}

[System.Serializable]
public class ListofItemnewList
{
    public List<itemnewList> ListOfItemNewLis = new List<itemnewList>();
}