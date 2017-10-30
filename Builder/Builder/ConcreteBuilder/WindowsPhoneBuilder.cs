using Builder.Builder.AbstractBuilder;
using Builder.Builder.Object;
using Builder.Builder.Parts;

namespace Builder.Builder.ConcreteBuilder
{
    class WindowsPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;

        public WindowsPhoneBuilder()
        {
            phone = new MobilePhone("Windows Phone");
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.Touch;
        }

        public void BuildBattery()
        {
            phone.PhoneBatteryCapacity = BatteryCapacity.TwoThousandMa;
        }

        public void BuildOS()
        {
            phone.PhoneOS = Builder.Parts.Os.WindowsPhone;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.No;
        }

        public MobilePhone Construct()
        {
            return phone;
        }
    }
}
