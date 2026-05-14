using UnityEngine;
using UnityEngine.UI;

public class ClientManager : MonoBehaviour
{
    [Header("Interface")]
    public GameObject UI1;
    public GameObject SeleccionSkinsUI;
    public GameObject VisualizationSkinsUI;
    [Space]

    public GameObject Skin1Canvas;
    public GameObject Skin2Canvas;
    public GameObject Skin3Canvas;

    [Space]
    [Header("General Buttons")]
    public Button buttonPLAY;
    public Button buttonCOLLECTION;

    [Space]
    [Header("Skin Selection UI")]
    public Image Skin1;
    public Image Skin2;
    public Image Skin3;

    private void Awake()
    {
        ActiveUI1();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void buttonUIPLAY()
    {
        UI1.SetActive(true);
    }

    public void buttonUICOLLECTION()
    {

    }

    //INTERFACE 1
    public void ActiveUI1()
    {
        UI1.SetActive(true);
        SeleccionSkinsUI.SetActive(false);
        VisualizationSkinsUI.SetActive(false);
    }

    //INTERFACE 2
    public void ActiveSkinSelectionUI()
    {
        UI1.SetActive(false);
        SeleccionSkinsUI.SetActive(true);
        VisualizationSkinsUI.SetActive(false);
    }

    public void ActiveSkinVisualization()
    {
        UI1.SetActive(false);
        SeleccionSkinsUI.SetActive(false);
        VisualizationSkinsUI.SetActive(true);
    }

    //SKIN 1 CANVA
    public void ActiveSkin1Canvas()
    {
        ActiveSkinVisualization();
        Skin1Canvas.SetActive(true);
        Skin2Canvas.SetActive(false);
        Skin3Canvas.SetActive(false);
    }

    //SKIN 2 CANVA
    public void ActiveSkin2Canvas()
    {
        ActiveSkinVisualization();
        Skin1Canvas.SetActive(false);
        Skin2Canvas.SetActive(true);
        Skin3Canvas.SetActive(false);
    }

    //SKIN 3 CANVA
    public void ActiveSkin3Canvas()
    {
        ActiveSkinVisualization();
        Skin1Canvas.SetActive(false);
        Skin2Canvas.SetActive(false);
        Skin3Canvas.SetActive(true);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
