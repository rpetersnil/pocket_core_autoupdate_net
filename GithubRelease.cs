namespace Github;

public class Release
{
    public string tag_name {get; set;}
    public string name {get; set;}
    public bool prerelease {get; set;}
    public string url {get; set;}
    public List<Github.Asset> assets {get; set;}
    public bool draft {get; set;}
}