namespace resume{

    public class Resume{


        public string _person_name;
        
        public List<Job> _job_list  = new List<Job>();


        public Resume(){

        }


        public void DisplayResume(){
            Console.WriteLine($"Name: {this._person_name}");

            Console.WriteLine("Jobs: ");
            foreach( Job job in this._job_list){
                job.Display();
            }
        }




    }
}