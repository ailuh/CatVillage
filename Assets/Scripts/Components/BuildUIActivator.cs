using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUIActivator : MonoBehaviour
{
    [SerializeField] UIService _uiService;

    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("It Works");
            _uiService.BuildingUIView(true, transform.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("It Works");
            _uiService.BuildingUIView(false, transform.position);
        }
    }
}
