using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Utilities.Helpers
{
  public class SerializationHelper
  {
    public const string DEFAULT_PATH = "C:\testIft585_TP3";

    /// <summary>
    /// Permet de sérializer en XML une entité en utilisant le chemin par défaut.
    /// </summary>
    /// <typeparam name="T">Le type de l'entité à sérializer</typeparam>
    /// <param name="obj">L'entité à sérializer</param>
    public static void SerializeToXml<T>(List<T> obj)
    {
      SerializeToXml<T>(obj, DEFAULT_PATH);
    }

    /// <summary>
    /// Permet de sérializer en XML une entité.
    /// </summary>
    /// <typeparam name="T">Le type de l'entité à sérializer</typeparam>
    /// <param name="obj">L'entité à sérializer</param>
    /// <param name="path">L'endroit et le nom du fichier créé</param>
    public static void SerializeToXml<T>(List<T> objs, string path)
    {
      XmlSerializer xml = new XmlSerializer(typeof(List<T>));  
      List<T> toAdd = new List<T>();
      toAdd.AddRange(objs);
      if (File.Exists(path))
      {
        TextReader textReader = new StreamReader(path);
        toAdd.AddRange(xml.Deserialize(textReader) as List<T>);
        textReader.Close();
      }

      TextWriter textWriter = new StreamWriter(path);
      xml.Serialize(textWriter, toAdd);
      textWriter.Close();
    }

    public static List<T> DeserializeXml<T>(string path)
    {
      XmlSerializer xml = new XmlSerializer(typeof(List<T>));  
      List<T> returnList = new List<T>();
      if (File.Exists(path))
      {
        TextReader textReader = new StreamReader(path);
        returnList.AddRange(xml.Deserialize(textReader) as List<T>);
        textReader.Close();
      }

      return returnList;
    }
  }
}
