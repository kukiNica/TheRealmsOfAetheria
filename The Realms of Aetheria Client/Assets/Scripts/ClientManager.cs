using UnityEngine;
using UnityEngine.UI;

public class ClientManager : MonoBehaviour
{
    [Header("Interface")]
    public GameObject UI1;
    public GameObject SeleccionSkinsUI;
    public GameObject VisualizacionSkinsUI;

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
        VisualizacionSkinsUI.SetActive(false);
    }

    //INTERFACE 2
    public void ActiveSkinSelectionUI()
    {
        UI1.SetActive(false);
        SeleccionSkinsUI.SetActive(true);
        VisualizacionSkinsUI.SetActive(false);
    }

    //INTERFACE 3
    public void ActiveVisualizationUI()
    {
        UI1.SetActive(false);
        SeleccionSkinsUI.SetActive(false);
        VisualizacionSkinsUI.SetActive(true);
    }
}
