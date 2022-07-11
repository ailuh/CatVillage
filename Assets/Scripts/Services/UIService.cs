using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UIService : MonoBehaviour
{
    public List<Button> BuildButtons = new List<Button>();
    public GameObject BuildingView;

    private void Start()
    {
        BuildUIInitialize();
    }

    void BuildUIInitialize()
    {
        BuildingView.SetActive(false);
    }

    public void BuildingUIView(bool isOn, Vector3 position)
    {
        BuildingView.SetActive(isOn);
        BuildingView.transform.position = position;
    }
}
