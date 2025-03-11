using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle="Mechanic apprentice ";
        job1._companyName="Tony Motos";
        job1._starYear= 2015;
        job1._endYear= 2016;

        Job job2 = new Job();
        job2._jobTitle="Mechanic";
        job2._companyName="Dani motors";
        job2._starYear= 2018;
        job2._endYear= 2022;

        Job job3 = new Job();
        job3._jobTitle="Post venta lead";
        job3._companyName="Punto Motriz";
        job3._starYear= 2022;
        job3._endYear= 2025;

        Resume myResume= new Resume();
        myResume._personName="Daniel Tudela";
        myResume._listJobs.Add(job1);
        myResume._listJobs.Add(job2);
        myResume._listJobs.Add(job3);

        myResume.Display();

    }

}