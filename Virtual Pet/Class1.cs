using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet

{
    public class Virtual_Pet
    {

        private string nameOfPet;
        private string genderOfPet;
        private string colorOfPet;
        //------------------------------
        private string dietOfPet;  // I am going to design a method to feed the monkey
        private string foodoption; // I may need to have a way to store the selected item
        string[] myFoods = new string[] { "apple", "banana", "roots", "leaves" };

        // --------------------------------------------------------------------------
        string[] playforpet = { "wrestle", "catch", "groom", "swing" };//going to make a method to play with monkey
        private string playOfPet;//to activate method?
        private string playoption; // I may need to store the option picked from play to verify or at least print out for user, to know if it worked.
                                   // I may need to 


        //These are my contructors for my object
        //This is the input that my user would pass to these variables
        //The "this" keyword enables the user to call that variable(get access) to input data
        //Change of plans, I wanted to incorporate other animal types but this would cause too much focus on too many things


        //This will enable my user to put in a name for their monkey
        //This will enable my user to put in a gender
        //In all constructor will build for the virutal pet: Monkey, MOMO, Female, AKA Momo the monkey 
        //The "this" keyword enables the user to call that variable(get access) to input data

        //PROPERTIES

        public string name
        {
            get { return nameOfPet;}
            set { nameOfPet = value;}
        { 
        
                

        public string color
        {
            get { return colorOfPet; }
            set { colorOfPet = value; }
        }

        public string gender
        {
            get { return genderOfPet; }
            set { genderOfPet = value; }
        }


        public Virtual_Pet(string name, string gender, string color)
        {

            this.nameOfPet = name;
            this.colorOfPet = color;
            this.genderOfPet = gender;
        }







    }

}
