namespace ApiMina3.Models
{

    public class Eqt_real_time
    {
        public int Id { get; set; }
        public int state_id { get; set; }
        public DateTime state_start { get; set; }


        public Double hourmeter_value { get; set; }


        public Double east { get; set; }

        public Double north { get; set; }

        public int destination_id { get; set; }

        public byte speed { get; set; }

        public byte device_signal_level { get; set; }

        public int device_status { get; set; }

        public int state_image_id { get; set; }

    }


    public class Resource
    {

        public int id { get; set; }

        public string name { get; set; }

        public Byte[] content { get; set; }


    }
}
