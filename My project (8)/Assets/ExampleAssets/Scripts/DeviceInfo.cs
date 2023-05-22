using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CsvHelper.Configuration.Attributes;

public class DeviceInfo
{
    public DeviceInfo(int id,int man,int life,int serie)
    {
        this.id_device = id;
        this.manufactureYear = man;
        this.serviceLife = life;
        this.serie = serie;
    }
    [Name("id_device")]
    public int? id_device { get; set; }

    [Name("manufactureYear")]
    public int? manufactureYear { get; set; }

    [Name("serviceLife")]
    public int? serviceLife { get; set; }

    [Name("serie")]
    public int? serie { get; set; }
    public static String GetDeviceInfo(DeviceInfo deviceInfo)
    {
        int id = (int)deviceInfo.id_device;
        int manufacture = (int)deviceInfo.manufactureYear;
        int serviceLife = (int)deviceInfo.serviceLife;
        int serie = (int)deviceInfo.serie;
        string infoText = ("Идентификатор: " + id + "\n" +
                           "Производство: " + manufacture + "\n" +
                           "Время работы: " + serviceLife + "\n" +
                           "Серия: " + serie);
        return infoText;
    }
}
