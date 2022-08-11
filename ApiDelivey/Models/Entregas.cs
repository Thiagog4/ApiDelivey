namespace ApiDelivey.Models
{
    public class Entregas
    {
        public int id { get; set; }

        public string nrEntrega {get;set;}

        public DateTime dataDaEntrega { get; set; } = DateTime.Now;


    }
}
