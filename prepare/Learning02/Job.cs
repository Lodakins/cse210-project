using System;


public class Job{
        public string _company;
        public string _job_title;

        public string _start_year;

        public string _end_year;

        public Job(){

        }

        public void Display(){
            Console.WriteLine($"{this._job_title} ({this._company}) {this._start_year} - {this._end_year}");
        }

}