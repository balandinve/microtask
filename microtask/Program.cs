using System;

namespace microtask
{
    public class Some
    {
        public void Do()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            var item = new Some();
            int i = 1;
            try
            {
                item.Do();
                i = 2;
            }
            catch (Exception)
            {
                i = 4;
            }
            finally
            {
                i = 3;
            }
            Console.WriteLine(i);
            Console.ReadLine();
            #endregion

            #region task 2
            //using (var db = new AppDbContext())
            //{
            //    var users = db.Users;
            //    foreach(var users in users)
            //    {
            //        Console.WriteLine(users.Name);
            //    }
            //}
            #endregion

            #region task 3
            //задачка сс двумя стеками

            #endregion

            #region task 4
            // задачка с рядом чисел на sql

            #endregion

            #region task 5 


            #endregion

        }
    }
}
