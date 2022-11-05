using System.Collections;
using System.Collections.Generic;

public class Student
{
    public Student()
    {
        this.Name ='';
        this.Classroom ='';
        this.Registration = 0;
        this.Deficiency = '';
        this.Password = '';

    }

    public Student( string name, string classroom, int registration, string deficiency, string password ){
        this.Name = name;
        this.Classroom = classroom;
        this.Registration = registration;
        this.Deficiency = deficiency;
        this.Password = password;

    }


        public string Name { get; set; }
        public string Classroom { get; set; }
        public int Registration { get; set; }
        public string Deficiency { get; set; }
        public string Password { get; set; }
    
}
