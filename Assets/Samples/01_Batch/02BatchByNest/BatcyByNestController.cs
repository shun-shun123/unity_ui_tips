using UnityEngine;

public class BatcyByNestController : MonoBehaviour
{
    [SerializeField] private GameObject[] _labelObjects;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _labelObjects.Length; i++)
            {
                _labelObjects[i].gameObject.SetActive(!_labelObjects[i].activeSelf);
            }
        }        
    }
}
