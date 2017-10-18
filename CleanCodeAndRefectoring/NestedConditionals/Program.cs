using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested condition example
            //var a = true;
            //var b = true;
            //var c = false;

            //if (a)
            //{
            //    if (b)
            //    {
            //        if (c)
            //        {
            //            Console.WriteLine("True Statement");
            //        }
            //        else
            //        {
            //            Console.WriteLine("false Statement");
            //        }
            //    }
            //}

            // Solution for nested condition
            TernaryOperator();
            SimplifyTrueFalse();
            Combine();
            EarlyExit();
            SwapOrder();
            SwapOrderAndCombine();
            SwapOrderAndCombineAndSimplify();
        }

        static void TernaryOperator()
        {
            var customer = new Customer();
            var order = new Order();
            order.OrderQty = 30;

            // Normal Condition
            //if (order.OrderQty > 20)
            //    customer.Discount = 0.1f;
            //else
            //    customer.Discount = 0.01f;

            // Ternary Operator
            customer.Discount = (order.OrderQty > 20) ? 0.01f : 0.1f;
            Console.WriteLine($"Discount rate is {customer.Discount}");
        }

        static void SimplifyTrueFalse()
        {
            var customer = new Customer();
            var order = new Order();
            order.OrderQty = 100;

            // Normal Condition
            //if (order.OrderQty > 50)
            //    customer.GoldCustomer = true;
            //else
            //    customer.GoldCustomer = false;

            // Simplufy true/false
            customer.GoldCustomer = order.OrderQty > 50;
            Console.WriteLine($"Gold Customer: {customer.GoldCustomer}");
        }

        static void Combine()
        {
            var a = true;
            var b = true;

            // Normal Condition
            //if (a)
            //{
            //    if (b)
            //    {
            //        Console.WriteLine("Combine: a equals b");
            //    }
            //}

            // Combine 
            if (a && b)
            {
                Console.WriteLine("Combine: a equals b");
            }
        }

        static void EarlyExit()
        {
            var a = true;
            var b = true;

            // Normal Condition
            //if (a)
            //{
            //    if (b)
            //    {
            //        Console.WriteLine("a equals b");
            //    }
            //}

            // Early Exit 
            if (!a)
                return;

            if (!b)
                return;

            Console.WriteLine("EarlyExit: a equals b");

        }

        static void SwapOrder()
        {
            var a = true;
            var b = true;
            var c = true;

            var isValid = false;

            // Normal Condition
            //if (a)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}
            //if (c)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}

            // Swap Order 
            if (b)
            {
                if (a)
                {
                    isValid = true;
                }
                if (c)
                {
                    isValid = true;
                }
            }

            Console.WriteLine($"SwapOrder is {isValid}");
        }

        static void SwapOrderAndCombine()
        {
            var a = true;
            var b = true;
            var c = true;

            var isValid = false;

            // Normal Condition
            //if (a)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}
            //if (c)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}

            // Swap Order 
            //if (b)
            //{
            //    if (a)
            //    {
            //        isValid = true;
            //    }
            //    if (c)
            //    {
            //        isValid = true;
            //    }
            //}

            // Swap Order + Combine
            if (b && (a || c))
            {
                isValid = true;
            }

            Console.WriteLine($"SwapOrderAndCombine is {isValid}");
        }

        static void SwapOrderAndCombineAndSimplify()
        {
            var a = true;
            var b = true;
            var c = true;

            var isValid = false;

            // Normal Condition
            //if (a)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}
            //if (c)
            //{
            //    if (b)
            //    {
            //        isValid = true;
            //    }
            //}

            // Swap Order 
            //if (b)
            //{
            //    if (a)
            //    {
            //        isValid = true;
            //    }
            //    if (c)
            //    {
            //        isValid = true;
            //    }
            //}

            // Swap Order + Combine
            //if (b && (a || c))
            //{
            //    isValid = true;
            //}

            // Swap Order + Combine + Simplify
            isValid = (b && (a || c));

            Console.WriteLine($"SwapOrderAndCombineAndSimplify is {isValid}");
        }

    }
}
