using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CC.Common.AppMessage
{
  public static class Helpers
  {
    public static byte[] SerializeObject<T>(T objectToSerialize)
        where T : class
    {
      BinaryFormatter bf = new BinaryFormatter();
      MemoryStream memStr = new MemoryStream();

      try
      {
        bf.Serialize(memStr, objectToSerialize);
        memStr.Position = 0;

        return memStr.ToArray();
      }
      finally
      {
        memStr.Close();
      }
    }

    public static T DeserializeObject<T>(byte[] data)
        where T : class
    {
      BinaryFormatter bf = new BinaryFormatter();
      MemoryStream memStr = new MemoryStream(data);
      try
      {
        var result = bf.Deserialize(memStr);
        return result as T;
      }
      finally
      {
        memStr.Close();
      }

      //return null;
    }

  }
}
