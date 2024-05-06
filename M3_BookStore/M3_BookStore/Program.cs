using System;
using System.Collections;
using System.Collections.Generic;


public static class BookStore
{

    //Problem 1: Spagetthi Code - Total does too many things at once
    //Problem 2: I am doing a deep search where i complete one set before the next one is opened.
    //This does not give the correct solution since it is the goal to find the cheapest price possible. 

    public static void Main(string[] args)
    {
        var basket = new[]
        {
            1, 1,2,2,3,3,4,4
                  
        };

        Console.WriteLine("Total: "+Total(basket));
        var basket2 = new[] { 1,2,3,4,5,1,2,3};
        Console.WriteLine("Total: " + Total(basket2));

    }

    public static int NumberOfSets(IDictionary<int, int> bookCollection)
    {
        
        
        int numberOfSets = 0;

        foreach (int key in bookCollection.Keys)
        {
            if (bookCollection[key]>numberOfSets) numberOfSets = bookCollection[key];
        }

                return numberOfSets;

    }

    public static decimal Total(IEnumerable<int> books)
    {
        decimal initialCost = 8.00m; //cost of a single book
        decimal price = 0.00m; //price of the whole purchase

        //Put all the entries in a dictionary <int, int> with <Book, numberOfExemplars>

        IDictionary<int, int> bookCollection = Duplicates(books);

        //print dictionary to see if it is correct

        // the array sets in Total is as long as the minimum number of possible sets - the highest value in the bookCollection
        int[] sets = new int[(NumberOfSets(bookCollection))];
       
        //creates sets of books (set[0]: 5 different books, set[1]: 3 different books, etc.)

        foreach (int key in bookCollection.Keys)
        {
           
            
            for (int i = 0; i< sets.Length; i++)
            {
                if (bookCollection[key] > 0)
                {
                    bookCollection[key]--;
                    sets[i]++;
                }
               
            }
        }

        /* Control structure to test whether sets has been created correctly

        Console.WriteLine("set:");
        foreach (int set in sets)
        {
           
            Console.WriteLine(set);
        }

        */


        //calculates the discounted price for the sets and adds them together

        foreach (int set in sets)
        {
            decimal discount;
            switch (set)
            {
                case 5:
                    discount = (initialCost * set) * 0.75m;
                    break;
                case 4:
                    discount = (initialCost * set) * 0.80m;
                    break;
                case 3:
                    discount = (initialCost * set) * 0.90m;
                    break;
                case 2:
                    discount = (initialCost * set) * 0.95m;
                    break;
                default:
                    discount = (initialCost * set);
                    break;
            }

            
            price += discount;
            Console.WriteLine($"set: {set}, discout: {discount}, price: {price}");

        }

        return price;

    }

    public static IDictionary<int, int> Duplicates(IEnumerable<int> books)
    {
        IDictionary<int, int> bookList = new Dictionary<int, int>();

        foreach (int book in books)
        {
            if (bookList.ContainsKey(book))
            {
                bookList[book]++;
            }
            else
            {
                bookList.Add(book, 1);
            }
        }
        return bookList;
    }

}



