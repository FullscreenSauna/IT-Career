using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___Parking
{
    class Parking
    {
        private Car Head { get; set; }
        private Car Tail { get; set; }
        public int Count { get; private set; }

        public void AddCar(string carNumber)
        {
            Car newCar = new Car(carNumber);

            if (Head == null)
            {
                Head = Tail = newCar;
            }
            else
            {
                Tail.Next = newCar;
                Tail = newCar;
            }

            Count++;
        }

        public void AddFancyCar(string carNumber)
        {
            Car newCar = new Car(carNumber);

            if (Head == null)
            {
                Head = Tail = newCar;
            }
            else
            {
                newCar.Next = Head;
                Head = newCar;
            }

            Count++;
        }

        public Car CheckCarIsPresent(string carNumber)
        {
            Car currentCar = Head;
            
            while (currentCar != null)
            {
                if (currentCar.CarNumber == carNumber)
                {
                    break;
                }

                currentCar = currentCar.Next;
            }

            return currentCar;
        }

        public bool ReleaseCar(string carNumber)
        {
            if (Head.CarNumber == carNumber)
            {
                Head = Head.Next;
                Count--;
                return true;
            }

            Car currentCar = Head;

            while (currentCar.Next != null)
            {
                if (currentCar.Next.CarNumber == carNumber)
                {
                    if (currentCar.Next == Tail)
                    {
                        Tail = currentCar;
                    }
                    currentCar.Next = currentCar.Next.Next;
                    Count--;
                    return true;
                }
            }

            return false;
        }

        public bool ReleaseCar(int index)
        {
            if (index > -1 && index < Count) 
            {
                if (index == 0)
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }

                Car currentCar = Head;
                int currentIndex = 1;

                for (int i = 0; i < Count - 1; i++)
                {
                    if (currentIndex == index)
                    {
                        if (currentCar.Next == Tail)
                        {
                            Tail = currentCar;
                        }
                        currentCar.Next = currentCar.Next.Next;
                        Count--;
                        return true;
                    }

                    currentIndex++;
                    currentCar = currentCar.Next;
                }

                return false;
            }

            return false;
        }

        public StringBuilder ParkingInformation()
        {
            StringBuilder sb = new StringBuilder();

            Car currentCar = Head;

            while (currentCar != null)
            {
                sb.Append(currentCar + "\n");

                currentCar = currentCar.Next;
            }

            return sb;
        }
    }
}
