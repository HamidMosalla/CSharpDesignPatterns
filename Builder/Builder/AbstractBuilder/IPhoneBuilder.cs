using Builder.Builder.Object;

namespace Builder.Builder.AbstractBuilder
{
    interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Construct();
    }
}
