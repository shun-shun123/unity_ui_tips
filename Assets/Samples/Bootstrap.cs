using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [Header("00_Settings")]
    [SerializeField] private Button _meshTypeScene;
    [SerializeField] private Button _generateMipMaps;
    [SerializeField] private Button _02ReadWriteScene;
    [SerializeField] private Button _03CompressionScene;

    [Header("01_Batch")]
    [SerializeField] private Button _simpleBatchScene;
    [SerializeField] private Button _batcyByCanvasScene;
    [SerializeField] private Button _batchByNestScene;

    [Header("03_Layout")] 
    [SerializeField] private Button _layoutGroupScene;

    private void Start()
    {
        // 00_Settings
        _meshTypeScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/00_Settings/00MeshType/Scenes/MeshType");
        });
        
        _generateMipMaps.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/00_Settings/01GenerateMipMaps/Scenes/GenerateMipMaps");
        });
        
        _02ReadWriteScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/00_Settings/02ReadWrite/Scenes/ReadWrite");
        });
        
        _03CompressionScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/00_Settings/03Compression/Scenes/Compression");
        });
        
        // 01_Batch
        _simpleBatchScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/01_Batch/00SimpleBatch/Scenes/SimpleBatch");
        });
        
        _batcyByCanvasScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/01_Batch/01BatchByCanvas/Scenes/BatchByCanvas");
        });
        
        _batchByNestScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/01_Batch/02BatchByNest/Scenes/BatchByNest");
        });
        
        // 03_Layout
        _layoutGroupScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Samples/03_Layout/00LayoutGroup/Scenes/LayoutGroup");
        });
    }
}
