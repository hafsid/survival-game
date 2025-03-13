using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool PlayerInRange;
    public string ItemName;

    public string GetItemName()
    {
       
        return ItemName;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && PlayerInRange && SelectionManager.Instance.onTarget)
        {
            Debug.Log("Item added to the inventory");
            Destroy(gameObject);
        }
    }
}
