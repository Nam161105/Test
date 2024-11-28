using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [Header("Danh sách Prefab của Level")]
    public GameObject[] levelPrefabs; // Mảng chứa các Prefab của Level

    private int currentLevelIndex = 0; // Level hiện tại
    private GameObject currentLevel; // Đối tượng level đang hiển thị

    // Hàm khởi chạy level đầu tiên
    private void Start()
    {
        LoadLevel(currentLevelIndex);
    }

    // Hàm tải một level dựa trên chỉ số
    public void LoadLevel(int levelIndex)
    {
        // Xóa Level cũ nếu có
        if (currentLevel != null)
        {
            Destroy(currentLevel);
        }

        // Kiểm tra xem chỉ số level có hợp lệ
        if (levelIndex >= 0 && levelIndex < levelPrefabs.Length)
        {
            // Tạo Level mới từ Prefab
            currentLevel = Instantiate(levelPrefabs[levelIndex], Vector3.zero, Quaternion.identity);
            currentLevelIndex = levelIndex;
        }
        else
        {
            Debug.LogWarning("Không còn level để tải!");
        }
    }

    // Hàm tải Level tiếp theo
    public void LoadNextLevel()
    {
        if (currentLevelIndex + 1 < levelPrefabs.Length)
        {
            LoadLevel(currentLevelIndex + 1);
        }
        else
        {
            Debug.Log("Chúc mừng! Bạn đã hoàn thành tất cả các Level!");
        }
    }
}