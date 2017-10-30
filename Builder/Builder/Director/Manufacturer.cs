using Builder.Builder.AbstractBuilder;
using Builder.Builder.Object;

namespace Builder.Builder.Director
{
    class Manufacturer
    {
        public MobilePhone Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
            return phoneBuilder.Construct();
        }
    }
}
