using UnityEngine;

public class LayoutGroupController : MonoBehaviour
{
    [SerializeField] private GameObject _noLayoutGroup;

    [SerializeField] private GameObject _useLayoutGroup;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _noLayoutGroup.gameObject.SetActive(!_noLayoutGroup.activeSelf);
        }    
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _useLayoutGroup.gameObject.SetActive(!_useLayoutGroup.activeSelf);
        }
    }
}
