using System;
using System.IO;
using ExampleAssets.Scripts;
using UnityEngine;
using Text = UnityEngine.UI.Text;

namespace ExcelTest
{
    [System.Serializable]
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Text text;
        /* private void button_Click(String info)
         {
             string fileName = @"C:\Users\Print_User\My project (8)\ex.xls";

             try
             {

                 var workBooks = excel.Workbooks;
                 var workBook = workBooks.Add();
                 var workSheet = excel.ActiveSheet;

                 workSheet.Cells[1, "A"] = textBox1.Text;

                 workBook.SaveAs(fileName);
                 workBook.Close();
             }
             catch (Exception ex) {
                 Console.WriteLine(
                 ("Ошибка: "+ ex.ToString()));
             }

             Console.WriteLine(
             ("Файл "+ Path.GetFileName (fileName) + " записан успешно!"));

         }*/
        public void SetActive()
        {
            /* switch (gameObject.GetComponent<ImageTargetBehaviour>())
             {
                 case icon_one:
                     DeviceInfo stanok1 = new DeviceInfo(1, 2, 521, 1);
                     text.text = DeviceInfo.GetDeviceInfo(stanok1);
                     Debug.Log(text);
                     break;   
                 case icon_two:
                     DeviceInfo stanok2 = new DeviceInfo(1, 2, 521, 1);
                     text.text = DeviceInfo.GetDeviceInfo(stanok2);
                     Debug.Log(text);
                     break;
                 case icon_free: 
                     DeviceInfo stanok3 = new DeviceInfo(1, 2, 521, 1);
                     text.text = DeviceInfo.GetDeviceInfo(stanok3);
                     Debug.Log(text);
                     break;
             }*/
            //if(ImageTargetBehaviour.) 
            //StreamWriter streamWriter =
            //new StreamWriter(@"C:\Users\Print_User\My projec      t (8)\Assets\ExampleAssets\Scripts\example.txt");
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    DeviceInfo stanok1 = new DeviceInfo(1, 2, 521, 00000001);
                    text.text = DeviceInfo.GetDeviceInfo(stanok1);
                    Debug.Log(text);
                    if (helper.Open(filepatch: Path.Combine(Environment.CurrentDirectory, "exes.xlsx")))
                    {
                        helper.Set(column: "A", row: 1, data: stanok1.id_device.ToString());
                        helper.Set(column: "B", row: 1, data: stanok1.serviceLife);
                        helper.Set(column: "С", row: 1, data: DateTime.Now);
                        helper.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // streamWriter.Write(getDeviceInfo(sta  nok1));
            //streamWriter.Close();
        }
    }
}
