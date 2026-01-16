using UnityEngine;
using UnityEngine.UI;

public class IconController : MonoBehaviour
{
    public Image profilePic;

    public IconsList defaultPic;

    public IconsList pic1;
    public IconsList pic2;
    public IconsList pic3;
    public IconsList pic4;
    public IconsList pic5;
    public IconsList pic6;

    void Start()
    {
        profilePic.sprite = defaultPic.icon;
    }

    public void Icon1()
    {
        profilePic.sprite = pic1.icon;
    }
    public void Icon2()
    {
        profilePic.sprite = pic2.icon;
    }
    public void Icon3()
    {
        profilePic.sprite = pic3.icon;
    }
    public void Icon4()
    {
        profilePic.sprite = pic4.icon;
    }
    public void Icon5()
    {
        profilePic.sprite = pic5.icon;
    }
    public void Icon6()
    {
        profilePic.sprite = pic6.icon;
    }
}
