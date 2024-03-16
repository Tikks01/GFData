namespace GFDataApi.Config
{
    public record ConfigData
    {
        public string PathToDatabase { get; init; } = string.Empty;
        public string PathToTranslate { get; init; } = string.Empty;
        public List<string> OutPutServerFiles { get; init; } = new List<string>();
        public List<string> OutPutClientFiles { get; init; } = new List<string>();        
        public string DefaultLoadPrefix {  get; init; } = "S_";
    }
}
