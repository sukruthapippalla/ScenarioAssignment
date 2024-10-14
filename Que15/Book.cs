﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que15
{
    public class Book
    {
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;
        public Book() { }
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }
        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages / daysToRead;
        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int daysLate = (returnedDate - dueDate).Days;
            if(daysLate > 0)
            {
                return daysLate * dailyLateFeeRate;
            }
            return 0;
        }
    }
}
