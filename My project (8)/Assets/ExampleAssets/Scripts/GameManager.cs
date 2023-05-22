using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;
using ExampleAssets.Scripts;
using UnityEngine;
using Text = UnityEngine.UI.Text;
using System.Diagnostics;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;


namespace ExcelTest
{
    [System.Serializable]

    public class GameManager : MonoBehaviour
    {
        static void Main(string[] args)
        {
            DeviceInfo stanok = new DeviceInfo(1,2,3,4);
            var devs = new List<DeviceInfo> {
                stanok
        };

            using var writer = new StreamWriter("output.csv");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);


            csv.WriteHeader<DeviceInfo>();
            csv.NextRecord();
            foreach (var dev in devs)
            {
                csv.WriteRecord(dev);
                csv.NextRecord();
            }
            text.text = DeviceInfo.GetDeviceInfo(stanok);
            Debug.Log(text);

        }
    }
}
