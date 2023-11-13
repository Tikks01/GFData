namespace GFDataApi.Utils
{
    [System.AttributeUsage(System.AttributeTargets.Property |
                       System.AttributeTargets.Field)
]
    public class IniFile : System.Attribute
    {
        public IniFileTarget Target;
        public IniFile(IniFileTarget target) {
            Target = target;
        }
    }

    public enum IniFileTarget
    {
        Both = 0,
        Client = 1,
        Server = 2
    }
}
