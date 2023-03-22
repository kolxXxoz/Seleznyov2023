using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Consigment
    {
        int quantity;
        double price;

        public int Quantity 
        { 
            get => quantity;
            set
            {
                if (value < 0) throw new ArgumentException("Количество товара должно быть положительным");
                quantity = value;
            }
        }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentException("Цена должна быть положительной");
                price = Math.Round(value, 2);
            }
        }

        public double Cost
        {
            get => Math.Round(quantity * price, 2);
        }

        public Consigment(int quantity, double price) : this()
        {
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Quantity} шт. по {Price:0.00} руб.";
        }

        public override bool Equals(object obj)
        {
            if (obj is Consigment) return Quantity == ((Consigment)obj).Quantity && Price == ((Consigment)obj).Price;
            throw new ArgumentException("Объект для сравнения не является партией товара");
        }

        public override int GetHashCode() => ToString().GetHashCode();

        public static Consigment operator +(Consigment x, Consigment y)
        {
            if (x.Price == y.Price) return new Consigment(x.Quantity + y.Quantity, x.Price);
            throw new ArgumentException("Невозможно объединить данные партии товара");
        }

        public static Consigment operator -(Consigment x, Consigment y)
        {
            if (x.Price == y.Price)
            {
                if (x.Quantity >= y.Quantity) return new Consigment(x.Quantity - y.Quantity, x.Price);
                else throw new ArgumentException("Вычитаемое количество товара в партии больше наличествующего");
            }

            throw new ArgumentException("Невозможно разбить данные партии товара");
        }
    }
}
