
namespace LinqPractices.DbOperations
{

    public class DataGenerator
    {
        
        public static void Initialize()
        {
            using(var context = new LinqDbContext())
            {
                if(context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange(
                    new Student(){
                        StudentId =1,
                        Name = "Ayse",
                        Surname = "Yılmaz",
                        ClassId = 1
                    },

                     new Student(){
                        StudentId =2,
                        Name = "Deniz",
                        Surname = "Yılar",
                        ClassId = 1
                    },
                     new Student(){
                        StudentId =3,
                        Name = "Umut",
                        Surname = "Önal",
                        ClassId = 2
                    }

                );

                context.SaveChanges(); 

            }
        }
    }

}