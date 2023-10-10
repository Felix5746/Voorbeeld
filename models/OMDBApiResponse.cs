namespace Voorbeeld.models
{
    public class OMDBApiResponse
    {
        public List<Film> Search { get; set; }
        public string TotalResults { get; set; }
        public string Response { get; set; }
    }
}