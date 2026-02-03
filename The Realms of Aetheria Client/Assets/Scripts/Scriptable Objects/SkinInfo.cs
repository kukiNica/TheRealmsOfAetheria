using UnityEngine;

[CreateAssetMenu(fileName = "new Skin", menuName = "Scriptable Objects/Skin Type")]
public class SkinInfo : ScriptableObject
{
    public string skinName = "Skin 1";
    public Sprite worldIcon;
    public Sprite nameBG;
    [Space]

    public Sprite background;

    [TextArea(minLines: 2, maxLines: 4)]
    public string storyText;
    public Sprite storyTextButtonBG;
    public Sprite storyTextBG;
    [Space]

    [Header("PASSIVE")]
    public string passiveName;
    public Sprite passiveIcon; //Skin Category
    [TextArea(minLines: 1, maxLines: 4)]
    public string passiveDescription;
    [Space]

    [Header("ABILITY 1")]
    public string abbility1Name;
    public Sprite abbility1Icon;
    [TextArea(minLines: 1, maxLines: 4)]
    public string abbility1Description;
    [Space]

    [Header("ABILITY 2")]
    public string abbility2Name;
    public Sprite abbility2Icon;
    [TextArea(minLines: 1, maxLines: 4)]
    public string abbility2Description;
    [Space]

    [Header("ABILITY 3")]
    public string abbility3Name;
    public Sprite abbility3Icon;
    [TextArea(minLines: 1, maxLines: 4)]
    public string abbility3Description;
    [Space]

    [Header("ABILITY 4")]
    public string abbility4Name;
    public Sprite abbility4Icon;
    [TextArea(minLines: 1, maxLines: 4)]
    public string abbility4Description;
}
