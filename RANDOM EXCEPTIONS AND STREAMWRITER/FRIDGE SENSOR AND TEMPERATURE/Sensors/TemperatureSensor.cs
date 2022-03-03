namespace Exercise004
{
  using System;
  using System.Collections.Generic;
  public class TemperatureSensor : ISensor
  {
    private bool SensorOn;
    public TemperatureSensor()
    {
      this.SensorOn = false;
    }
    public bool IsOn()
    {
      return this.SensorOn;
    }
    public void SetOn()
    {
      this.SensorOn = true;
    }
    public void SetOff()
    {
      this.SensorOn = false;
    }
    public int Read()
    {
      if (IsOn())
      {
        Random temperature = new Random();
        int temp = temperature.Next(-30,31);
        return temp;
      }
      else
      {
        throw new InvalidOperationException(" Sensor is off!");
      }
    }
  }
}
