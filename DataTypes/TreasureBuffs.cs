namespace GFDataApi.DataTypes
{
    public class TreasureBuffs
    {
        private int[] Buffs = new int[4];

        public int Get(int index)
        {
            return Buffs[index];
        }

        public void Set(int index, int value)
        {
            Buffs[index] = value;
        }

        public int Count()
        {
            return Buffs.Length;
        }
    }
}
