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

        public int[] asArray()
        {
            var array = new int[4];

            Buffs.CopyTo(array, 0);
            return array;
        }

        public TreasureBuffs() { }

        public TreasureBuffs(int[] Buffs) {
            if (Buffs.Length > 4) return;
            
            this.Buffs = Buffs;
        }
    }
}
