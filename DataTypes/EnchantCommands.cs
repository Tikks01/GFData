namespace GFDataApi.DataTypes
{
    public class EnchantCommands
    {
        List<EnchantCommand> _Commands;
        private static readonly int MaxCommands = 4;

        public EnchantCommand GetEnchant(int index)
        {
            return _Commands[index];
        }

        public EnchantCommand? Add()
        {
            if (_Commands.Count > MaxCommands) {
                return null;
            }

            EnchantCommand cmd = new();
            _Commands.Add(cmd);
            return cmd;
        }

        public int Max()
        {
            return MaxCommands;
        }

        public EnchantCommands()
        {
            _Commands = new List<EnchantCommand>();
        }
    }
}
