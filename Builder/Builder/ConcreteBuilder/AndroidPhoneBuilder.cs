using Builder.Builder.AbstractBuilder;
using Builder.Builder.Object;
using Builder.Builder.Parts;

namespace Builder.Builder.ConcreteBuilder
{
    class AndroidPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;

        public AndroidPhoneBuilder()
        {
            phone = new MobilePhone("Android Phone");
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.GorillaGlass;
        }

        public void BuildBattery()
        {
            phone.PhoneBatteryCapacity = BatteryCapacity.ThousandMa;
        }

        public void BuildOS()
        {
            phone.PhoneOS = Builder.Parts.Os.Android;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.Yes;
        }

        //finally construct the final phone
        public MobilePhone Construct()
        {
            return phone;
        }
    }
}
