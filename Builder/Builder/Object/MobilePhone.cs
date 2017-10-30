using Builder.Builder.Parts;

namespace Builder.Builder.Object
{
    class MobilePhone
    {
        public MobilePhone(string name)
        {
            PhoneName = name;
        }

        public string PhoneName { get; }

        public ScreenType PhoneScreen { get; set; }

        public BatteryCapacity PhoneBatteryCapacity { get; set; }

        public Os PhoneOS { get; set; }

        public Stylus PhoneStylus { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}", PhoneName, PhoneScreen, PhoneBatteryCapacity, PhoneOS, PhoneStylus);
        }
    }
}
