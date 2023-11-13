namespace GFDataApi.DataTypes
{
    public class AddAttrTable
    {
        public readonly int MaxAttributes = 8;
        private readonly List<int> _Attributes = new();
        public int Count {  get { return _Attributes.Count; } }

        public void Add(int attr)
        {
            if (_Attributes.Count < MaxAttributes)
            {
                _Attributes.Add(attr);
            }
        }

        public int Get(int index)
        {
            return _Attributes[index];
        }        
    }
}
