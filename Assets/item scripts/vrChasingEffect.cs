using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class vrChasingEffect : MonoBehaviour
{
  public void func()
    {
        if(getG())
        {
            changeG(false); 
        }
        else
        { changeG(true); }

    }

   public  void changeG(bool value)
    {
        FindAnyObjectByType<PostProcessVolume>().profile.settings.OfType<Grain>().FirstOrDefault().enabled.value = value;


    }
    bool getG()
    {
        return FindAnyObjectByType<PostProcessVolume>().profile.settings.OfType<Grain>().FirstOrDefault().enabled.value;


    }
}
