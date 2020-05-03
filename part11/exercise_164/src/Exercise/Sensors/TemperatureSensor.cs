namespace Exercise
{
    using System;
    public class TemperatureSensor : Sensor
    {
        private bool switcher;
        public bool IsOn()
        {
            return switcher;
        }


        public void SetOn()
        {
            switcher = true;
        }


        public void SetOff()
        {
            switcher = false;
        }


        public int Read()
        {

            Random temperature = new Random();
            int temp = temperature.Next(-30, 30);
            if (IsOn())
            {
                return temp;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}