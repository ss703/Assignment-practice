using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_pattern
{
    class Factory_Design_Pattern
    {
        static void Main(string[] args)
        {
            //Armour a = new Armour() { Id = 1, Name = "shield of sunlight", DefenceRating = 5, Weight = 67, Type = "shield" };
            //we cannot write the values all the time so we are taking class as well as common interface for this


            //we are craeting only one obj here by using singleton pattern
            Objectfactory objectfactory = new Objectfactory();
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Id", 1);

            Armour armour = objectfactory.Get(ObjectType.Armour, data) as Armour;
            Weapon weapon = objectfactory.Get(ObjectType.Weapon, data) as Weapon;

            Console.WriteLine(armour.GetInfo());
            Console.WriteLine(weapon.GetInfo());
            Console.ReadLine();



        }
    }
    enum ObjectType//it is used to identofy the type of obj which factory need to create
    {
        Armour,
       Weapon

    }
    class Objectfactory
    {
        private ObjectType _type;
        private Dictionary<string, object> _data;
        public Iobject Get(ObjectType type, Dictionary<string, object> data)
        //get should be called everytime if any code need to fetch any new obj like armour weapon obj ,thiis
        //factory is responsible  by proving diff details by reading info like id of obj an.......
        {
            _type = type;
            _data = data;
            return GetObject();
        }
        private Iobject GetObject()
        {
            Iobject obj = null;

            int id = Convert.ToInt32(_data["Id"]);
            //fetching obj info based on the supplied data
            switch(_type)
            {
                case ObjectType.Armour:
                    if(id==1)
                    {
                        obj = new Armour() { Id = 1, Name = "shield of sunlight", DefenceRating = 5, Weight = 67, Type = "shield" };

                    }
                    break;

                case ObjectType.Weapon:
                    if(id==1)
                    {
                        obj = new Weapon() { Id = 1, Name = "shield of sunlight", DamageRating = 5, Weight = 67, Type = "shield" };
                    }
                    break;

                default:
                    obj = null;
                    break;
            }
            return obj;

        }
    }

    interface Iobject
    {
        string GetInfo();
    }
    class Armour:Iobject
    {
        public int Id;
        public string Name;
        public Int32 DefenceRating;
        public Int32 Weight;
        public string Type;

        public virtual string GetInfo()
        {
            return string.Format("Armour name is{0},Defence rating is {1},Type{2},Weight is{3}",Name, DefenceRating, Weight, Type);
        }
    }
    class Weapon:Iobject
    {
        public int Id;
        public string Name;
        public Int32 DamageRating;
        public Int32 Weight;
        public string Type;

        public virtual string GetInfo()
        {
            return string.Format("weapon name is{0},Damage rating is {1},Type{2},Weight is{3}",Name, DamageRating, Weight, Type);
        }
    }
}
