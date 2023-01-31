using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    private int _dataToSave;
    private string _filePath;
    public int level_Index = 0;

    private void Awake()
    {
        _filePath = Application.persistentDataPath + "/savedData.dat";
        LoadData();
        if (level_Index > 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            level_Index++;
        }
        Debug.Log("Level Index = " + level_Index);
    }


    private void OnApplicationQuit()
    {
        SaveData();
    }

    private void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(_filePath);
        bf.Serialize(file, _dataToSave);
        file.Close();
    }

    private void LoadData()
    {
        if (File.Exists(_filePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(_filePath, FileMode.Open);
            _dataToSave = (int)bf.Deserialize(file);
            file.Close();
        }
    }
}
