using System.Text;

namespace GFDataApi.DataTypes
{
    public class SumAddAttrs
    {
        public List<uint> Attributes { get; private set; } = new List<uint>();

        public void LoadFromString(string value)
        {
            Attributes.Clear();

            var ids = value.Split(';');

            foreach (var id in ids)
            {
                Attributes.Add(uint.Parse(id));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Attributes.Count; i++)
            {
                if (i != 0)
                {
                    sb.Append(";");
                }
                sb.Append(Attributes[i].ToString());
            }

            return sb.ToString();
        }
    }
}
