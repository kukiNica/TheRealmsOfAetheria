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
}
