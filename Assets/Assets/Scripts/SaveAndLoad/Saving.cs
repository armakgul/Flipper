
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Saving
{
    public static void SaveHighScore (CollectAndDie score) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        SaveAndLoad data = new SaveAndLoad(score);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static SaveAndLoad LoadHighScore()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveAndLoad data = formatter.Deserialize(stream) as SaveAndLoad;
            stream.Close();

            return data;

        } else 
        {
            return null;
        }
    }

}
