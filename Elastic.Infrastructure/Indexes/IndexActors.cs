namespace Elastic.Infrastructure.Indexes
{
    public class IndexActors : ElasticBaseIndex
    {
        public DateTime RegistrationDate { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int TotalMovies { get; set; }
        public string Movies { get; set; } = string.Empty;
    }
}
