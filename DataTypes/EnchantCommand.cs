namespace GFDataApi.DataTypes
{
    public class EnchantCommand
    {
        public uint Id { get; set; }
        [DisplayZeros]
        public double Param1 { get; set; }
        [DisplayZeros]
        public double Param2 { get; set; }
        [DisplayZeros]
        public double Param3 { get; set; }
        [DisplayZeros]
        public double Param4 { get; set; }
        [DisplayZeros]
        public double Param5 { get; set; }
        [DisplayZeros]
        public double Param6 { get; set; }
    }
}
