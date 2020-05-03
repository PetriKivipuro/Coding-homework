namespace Exercise
{
    public class StandardSensor : Sensor
    {
        public int value;
        public StandardSensor(int value)
        {
            this.value = value;
        }
        public bool IsOn()
        {
            return true;
        }
        public void SetOn()
        {
        }
        public void SetOff()
        {
        }
        public int Read()
        {
            return this.value;
        }
    }
}