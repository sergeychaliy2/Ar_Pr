using System;
using UnityEngine;

public class DeviceInfo
{
    public DeviceInfo(int _id_device,int _manufactureYear,int _serviceLife,int _serie)
    {
        id_device=_id_device;
        manufactureYear = _manufactureYear;
        serviceLife = _serviceLife;
        serie = _serie;
    }

    public int id_device
    {
        get;
        private set;
    }

    public int manufactureYear
    {
        get;
        private set;
    }

    public int serviceLife
    {
        get;
        private set;
    }
    public int serie
    {
        get;
        private set;
    }
    public Sprite qr;

    public static String GetDeviceInfo(DeviceInfo deviceInfo)
    {
        int id = deviceInfo.id_device;
        int manufacture = deviceInfo.manufactureYear;
        int serviceLife = deviceInfo.serviceLife;
        int serie = deviceInfo.serie;
        string infoText = ("Идентификатор: " + id +"\n" +
                           "Производство: " +manufacture +"\n" +
                           "Время работы: " + serviceLife +"\n" +
                           "Серия: "+ serie);
        return infoText;
    }
}