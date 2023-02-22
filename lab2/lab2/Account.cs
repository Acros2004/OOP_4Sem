using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    public class Account
    {
        public List<History> histories;
        [Range(0, 10000)]
        public int num { get; set; }
        public enum Types { closed, open };
        public Types Type;
        [Range(0, 10000000)]
        public int Balance { get; set; }
        public DateTime OpeningDate;
        public bool Sms = false;
        public Owner owner;
        public Account(int num, Types type, int balance, DateTime openingDate, bool sms, Owner owner)
        {
            histories = new List<History>();
            this.num = num;
            Type = type;
            Balance = balance;
            OpeningDate = openingDate;
            Sms = sms;
            this.owner = owner;
        }
        public Account()
        {
            histories = new List<History>();
            num = 0;
            Type = Types.closed;
            Balance = 0;
            OpeningDate = DateTime.Now;
            owner = new Owner() { Name = null, Birthdate = DateTime.Now, Passport = null };
        }
        
        public override string ToString()
        {
            return $"Номер: {num} Тип вклада:{Type} SMS: {Sms} \n ФИО:{owner.Name} Баланс:{Balance} Дата открытия:{owner.Birthdate}";
        }
    }
    public class Owner
    {
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime Birthdate;

        [PassportRB]
        public string Passport { get; set; }
    }
    public class PassportRB : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var reg = new Regex(@"\d{7}A\d{3}PB\d");
            return reg.IsMatch((value as string));
        }
    }
}
