
namespace ConsoleApp2
{
    public class MedicinJornal
    {
        private string name;
        private string tidigarebesök;
        private string behandling;



        public MedicinJornal(string name, string tidigarebesök, string behandling)
        {
            this.name = name;
            this.tidigarebesök = tidigarebesök;  
            this.behandling = behandling;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }

        } 

        public string Tidigarebesök
        {
            get { return tidigarebesök; }
            set { tidigarebesök = value; }
        }

        public string Behandling
        { 
            get { return behandling; } 
            set { behandling = value; }
        }
    }
}
