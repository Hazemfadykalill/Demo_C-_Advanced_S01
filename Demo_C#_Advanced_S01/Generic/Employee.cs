using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__Advanced_S01.Generic
{
    public class Employee:IComparable
    {

        #region Property

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        #endregion


        #region Operator OverLoading
        // == 
        //public static bool operator ==  (Employee left ,Employee right)
        //{
        //    //return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);//True
        //   return left.Equals(right);//True
        //}
        // !=

        //public static bool operator !=(Employee left, Employee right)
        //{
        //    //return (left.Id != right.Id) && (left.Name != right.Name) && (left.Salary != right.Salary);//true
        //    return !left.Equals(right);//true
        //}
        #endregion


        #region Method
        public override string ToString()
        {
            return $"Id = {Id} :: Name = {Name} :: Salary = {Salary}";
        }


        public override bool Equals(object? obj)
        {
            if (obj is not null)//true
            {
                Employee employee = (Employee)obj;//Explicit Casting And Unsafe Casting
                return (this.Id.Equals(employee.Id)) && (this.Name.Equals(employee.Name)) && (this.Salary.Equals(employee.Salary));

            }
            return false ;

            /* Place if condition Employee? employee = (Employee?)obj;*/ //True

        }

        public override int GetHashCode()
        {
            //return 
            //    this.Id.GetHashCode() +
            //    this.Name?.GetHashCode()??0 +
            //    this.Salary.GetHashCode() ; // Kan Zaman

            return HashCode.Combine(this.Id, this.Name,this.Salary);
           
        }

        public int CompareTo(object? obj)
        {
            if (obj is not null)
            {
                Employee employee = (Employee)obj;
                return this.Salary.CompareTo(employee.Salary);  

            }
            return -1;
        }



        #endregion
    }
}
