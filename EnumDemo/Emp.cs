using System;
/*Types in C#
1.Value type → memory will be allocated on stack
  Int,float,double,enum, struct,
2.Reference type  → memory will be allocated on Heap
  String, array,class, interfaces,delegates 
Enum in C#
To create a set of constants in C# we can use enum
It is a value type
Compiler will generate the set of integers constants for enum type
Definition: An enumeration type is a value type defined by the a set of
named constants of underlying integral numeric type
*/


namespace EnumDemo
{
    public enum Department { HR = 100, Sales, Marketing ,Testing}
    public enum Roles {Emp=100,CEO=200,Manager=300 }
    public class Emp
    {
        private int id;
        private string name;
        private Department dept;
        private Roles roles;

        public Emp(int id,string name,Department dept,Roles roles)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.roles = roles;
        }
        public override string ToString()
        {
            return $"Id:{id} Name:{name} Department:{dept} Role:{roles}";
        }
    }
}
