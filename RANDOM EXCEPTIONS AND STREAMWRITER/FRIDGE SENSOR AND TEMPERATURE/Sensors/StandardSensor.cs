using System;
using System.Collections.Generic;

namespace Exercise004
{

    public class StandardSensor : ISensor
    {
        public int value;

        public StandardSensor (int value)
        {
            this.value = value;
        }
        public void SetOff()
        {

        }
        public void SetOn()
        {

        }
        public bool IsOn()
        {
            return true;
        }
        public int Read()
        {
            return this.value;
        }
    }
}
