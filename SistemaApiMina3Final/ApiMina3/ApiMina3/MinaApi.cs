namespace ApiMina3
{
    public class eqt_real_time  //nome da tabela
    {
       public int Id { get; set; }
        public int state_id { get; set; }
        public DateTime state_start { get; set; }

        public Double hourmeter_value { get; set; }

        public Double east {  get; set; }

        public Double north { get;set; }


        public int destination_id { get; set; }

        public byte speed { get; set; }


        public byte device_signal_level { get; set; }

        public int device_status { get; set; }

    }
}
