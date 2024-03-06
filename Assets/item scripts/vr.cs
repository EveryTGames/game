using System.Linq;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class vr : MonoBehaviour
{
    public void func()
    {
        if (getCG())
            changeCG(false);
        else
            changeCG(true);

    }
   public void changeCG(bool value)
    {
        if(value)
        {

        Camera.main.cullingMask = ~0;
        }
        else

        Camera.main.cullingMask = ~(1 << LayerMask.NameToLayer("monsters"));

        FindAnyObjectByType<PostProcessVolume>().profile.settings.OfType<ColorGrading>().FirstOrDefault().enabled.value = value;


    }
    bool getCG()
    {
        return FindAnyObjectByType<PostProcessVolume>().profile.settings.OfType<ColorGrading>().FirstOrDefault().enabled.value;


    }
  
}
