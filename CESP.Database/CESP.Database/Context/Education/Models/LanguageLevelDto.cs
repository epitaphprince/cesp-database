namespace CESP.Database.Context.Education.Models
{
    public class LanguageLevelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int? Rang { get; set; }  
        
        public string Description { get; set; }
    }
}