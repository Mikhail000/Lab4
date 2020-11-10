using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Plant
    {
        public static void Start()
        {
            Assembly root = new Assembly("Car", 1);
            Assembly engineV6 = new Assembly("Engine V6", 1);
            Assembly wheel = new Assembly("Wheel", 4);
            Assembly door = new Assembly("Door", 4);
            Assembly differential = new Assembly("Differential", 2);

            root.Add(engineV6);
            root.Add(wheel);
            root.Add(new Transmission(quantity: 1));
            root.Add(door);
            root.Add(differential);
            root.Add(new GasTank(quantity: 1));

            Assembly pistonSystem = new Assembly("Piston system", 1);
            Assembly valueSystem = new Assembly("Value system", 1);

            engineV6.Add(pistonSystem);
            engineV6.Add(valueSystem);
            engineV6.Add(new intakeManifold(quantity: 1));
            engineV6.Add(new exhaustManifold(quantity: 2));
            engineV6.Add(new Radiator(quantity: 1));

            pistonSystem.Add(new Piston(quantity: 4));
            pistonSystem.Add(new Crankshaft(quantity: 1));
            pistonSystem.Add(new Link(quantity: 4));
            pistonSystem.Add(new Gasket(quantity: 1));

            valueSystem.Add(new Value(quantity: 24));
            valueSystem.Add(new Camshaft(quantity: 2));

            wheel.Add(new Disk(quantity: 1));
            wheel.Add(new Tire(quantity: 1));

            door.Add(new Glass(quantity: 1));
            door.Add(new doorCard(quantity: 1));

            differential.Add(new gears(quantity: 5));
            differential.Add(new Bearing(quantity: 3));
            differential.Add(new shank(quantity: 1));

            ShowInfo(root);
        }



        static public void ShowInfo(Assembly root)
        {
            root.Display(0);
            root.Work();
        }
    }
}
