namespace Evaluation_Manager.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

        public int maxpoint { get; set; }
        public int minpointsgr { get; set; }
        public int minpointsig { get; set; }
    }
}