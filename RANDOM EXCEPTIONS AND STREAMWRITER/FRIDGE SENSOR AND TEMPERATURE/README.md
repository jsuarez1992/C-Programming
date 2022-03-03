Create a class called **StandardSensor** that implements the interface **ISensor**.

A standard sensor is always on. Calling the methods SetOn and SetOff has no effect. The StandardSensor must have a constructor that takes one integer parameter. The method call Read returns the number that was given to the constructor.

Create a class **TemperatureSensor** that implements the **ISensor interface**.

The constructor takes no parameters.
At first a temperature sensor is off.
When the method Read is called and the sensor is on, the sensor randomly chooses an integer in the range -30...30 and returns it.
If the sensor is off, the method Read throws an InvalidOperationException.
