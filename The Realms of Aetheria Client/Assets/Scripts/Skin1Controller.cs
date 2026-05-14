using UnityEngine;
using UnityEngine.UI;


public class Skin1Controller : MonoBehaviour
{
    public SkinInfo skinMoni;
    public SkinInfo skinKaren;
    public SkinInfo skinAna;

    public string descripcion;

    void Start()
    {
        descripcion = skinAna.abbility1Description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
