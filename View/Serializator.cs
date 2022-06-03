using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

using Model;


namespace View
{
    internal class Serializator
    {
        /// <summary>
        /// Реализация сериализатора.
        /// </summary>
        /// <param name="filePath">Путь к xml-файлу.</param>
        /// <param name="obj_list">Список с объектами</param>
        public static void Serializer(string filePath, List<Calc> obj_list)
        {
            var serializar = new XmlSerializer(typeof(List<Calc>));

            using (TextWriter textWriter = new StreamWriter(filePath))
            {
                serializar.Serialize(textWriter, obj_list);
                textWriter.Close();
            }
        }


        /// <summary>
        /// Реализация десериализатора.
        /// </summary>
        /// <param name="filePath">Путь к xml-файлу.</param>
        /// <returns>Список объектов.</returns>
        public static List<Calc> Deserializer(string filePath)
        {
            try
            {
                var serializar = new XmlSerializer(typeof(List<Calc>));

                using (TextReader textReader = new StreamReader(filePath))
                {
                    var settings = (List<Calc>)serializar.Deserialize(textReader);
                    textReader.Close();

                    return settings;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Невозможно десериализовать данные.\n" +
                    "Проверьте данные в файле.\n\n" +
                    e.ToString(), "Невозможная операция", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return null;
            }
        }
    }
}
