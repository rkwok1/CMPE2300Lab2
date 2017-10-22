using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300Lab2 
{
    class Package : IComparable
    {
        /**************************Properties**************************/
        public string Name { get; set; }
        private List<string> packageDependencies = new List<string>(); 
        public List<string> copyList
        {
            get
            { 
                return packageDependencies.CopyTo(copyList);
            }
        }

        /**************************Cosntructor*************************/
        public Package (string[] m_Name)
        {
            Name = m_Name[0];
            for (int i = 1; i < m_Name.Length; i++)
            {
                packageDependencies[i] = m_Name[i];
            }
        }


        /**************************Overrides*******************/
        //override equals
        public override bool Equals(object obj)
        {
            //If obj is not of type Package return not equals
            if (!(obj is Package))
                return false;

            //Copy of incoming obj for comparison
            Package copy = (Package)obj;

            //If names of objects are the same return true
            return Name.Equals(copy.Name);
            
        }

        //Override GetHash
        public override int GetHashCode()
        {
            return 1;
        }

        //Overload ToString

        public override string ToString()
        {
            return packageDependencies + ",";
        }

        //Icomparable support
        public int CompareTo(object obj)
        {
            if (!(obj is Package))
                throw new ArgumentException("Incorrect type in the Package.CompareTo!");
            //Ascending sort based on name.
            return Name.CompareTo(((Package)obj).Name);
        }

        public static int SortDCN(Package pOne, Package pTwo)
        {
            if (pOne.Name.CompareTo(pTwo.Name) == 0)
            {
                return pOne.packageDependencies.CompareTo(pTwo.packageDependencies);
            }
        }
    }
}
