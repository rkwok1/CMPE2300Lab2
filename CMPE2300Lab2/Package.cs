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
        /********************************************
         * To Do List:
         * Requires mergepackage and check
         * constructors
         * ******************************************/
        /**************************Properties**************************/
        public string Name { get; set; }
        private List<string> packageDependencies = new List<string>();
        private List<string> copyList = new List<string>();
        public List<string> pList
        {
            get
            {
                foreach  (string item in packageDependencies)
                {
                    copyList.Add(item);
                }
                return copyList;
            }
        }

        /**************************Cosntructor*************************/
        public Package (string[] m_Name)
        {
            //Add to the first element of the list the name
            Name = m_Name[0];
            //Check each other element in the packageDependecy list. 
            for (int i = 1; i < m_Name.Length; i++)
            {
                for (int x = 0; x < m_Name.Length; x++)
                {
                    //If one of the elements matches what we are checking in the array, don't add a duplicate
                    if (packageDependencies[x] != m_Name[i])
                    {
                        packageDependencies[i] = m_Name[i];
                    }
                }
            }
        }

        public Package (string m_Name)
        {
            Name = m_Name;
            packageDependencies.Clear();
        }
        /**************************Equals Overrides*******************/
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

        /**************************ToString Overrides*******************/

        public override string ToString()
        {
            return packageDependencies + ",";
        }

        /************************Icomparable overrides*******************/
        //Default sort ascending by name
        public int CompareTo(object obj)
        {
            if (!(obj is Package))
                throw new ArgumentException("Incorrect type in the Package.CompareTo!");
            //Ascending sort based on name.
            return Name.CompareTo(((Package)obj).Name);
        }

        //comparison compliant function ordering dependency count within name
        public int SortDWN(Package pOne, Package pTwo)
        {
            //If the names are the same, compare package order based on dependencies count
            if (pOne.Name.Equals(pTwo.Name))
            {
                return pOne.packageDependencies.Count().CompareTo(pTwo.packageDependencies.Count());
            }
            else
            {
                return pOne.Name.CompareTo(pTwo.Name);
            }
        
        }
        //comparison compliant function to allow ordering by Name within dependency count.
        public int SortNWD(Package pOne, Package pTwo)
        {
            if (pOne.packageDependencies.Count().Equals(pTwo.packageDependencies.Count))
            {
                return pOne.Name.CompareTo(pTwo.Name);
            }
            else
            {
                return pOne.packageDependencies.Count().CompareTo(pTwo.packageDependencies.Count);
            }
        }
        //Merge package function 
        public void MergePackage(Package pack)
        {
            //If the name of the of the package arguement is not the same, throws an exception
            if (!(Name.Equals(pack.Name)))
            {
                throw new ArgumentException("Names are not the same in mergepack function!");
            }
            //Otherwise combine packages together with no duplicates
            

        }
    }
}
