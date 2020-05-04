using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace AirfcraftBasicFlight_v2
{
    class JSONLogging
    {
        public void SaveSimulated(List<DataLog> dataToSave)
        {
            // Use the current time to set the File Name
            DateTime time = DateTime.Now;
            string fileName = time.Year.ToString() + time.Month.ToString() + time.Day.ToString() + "_" + time.Hour.ToString() +
                time.Minute.ToString() + time.Second.ToString();
            string filePath = "C:\\WorkSpace\\Programming\\SOV\\AirfcraftBasicFlight_v2\\" + fileName + ".json";
            
            // Serialize JSON directly to a file
            File.WriteAllText(filePath, JsonConvert.SerializeObject(dataToSave));
        }
    }
}
