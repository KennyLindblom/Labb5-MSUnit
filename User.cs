using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace TeamGrapeBankApp
{
    public  class User
    {
        //Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool LockedOut { get; set; }

        //List to hold users
        public static List<User> userList = new List<User>();
        

        //Constructor
        public User(int id, string username, string password, string firstname, string lastname, bool lockedOut)
        {
            Id = id;
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            LockedOut = lockedOut;
        }
        public static void GenerateUsers()
        {
            //Create User objects as Admin and Customers and add to list
            //This should be handled by a database in the future
            User sven = new Customer(1, "billgates", "pass1", "Bill", "Gates", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);
            User anna = new Customer(2, "annasvensson", "pass2", "Anna", "Svensson", "Nygatan 26 31176 Falkenberg", "anna@svensson.se", "+46703333333", false);
            User hermes = new Customer(3, "hermessaliba", "pass3", "Hermes", "Saliba", "Nygatan 28 31176 Falkenberg", "hermes@gmail.com", "+46704444444", false);
            User admin = new Admin(4, "admin", "pass", "Anas", "Qlok", false);


            userList.Add(sven);
            userList.Add(anna);
            userList.Add(hermes);
            userList.Add(admin);
        }

        //Method to login user
        public static bool Login(string enteredUsername, string enteredPassword)
        {
            string username = enteredUsername;
            User userTryLogin = userList.FirstOrDefault(x => x.Username == username);

            if (userTryLogin == null || userTryLogin.LockedOut)
            {
                return false;
            }

            int loginTries = 3;
            bool loginSuccess = false;
            do
            {
                string password = enteredPassword;
                loginTries--;

                if (password == userTryLogin.Password)
                {
                    loginSuccess = true;
                    break;
                }
            } while (loginTries > 0 && !loginSuccess);

            if (loginSuccess)
            {
                return true;
            }
            else
            {
                userTryLogin.LockedOut = true;
                return false;
            }
        }



        //static void LogoArt()
        //{
        //    Console.WriteLine("\r\n   _____                        ____              _    \r\n  / ____|                      |  _ \\            | |   \r\n | |  __ _ __ __ _ _ __   ___  | |_) | __ _ _ __ | | __\r\n | | |_ | '__/ _` | '_ \\ / _ \\ |  _ < / _` | '_ \\| |/ /\r\n | |__| | | | (_| | |_) |  __/ | |_) | (_| | | | |   < \r\n  \\_____|_|  \\__,_| .__/ \\___| |____/ \\__,_|_| |_|_|\\_\\\r\n                  | |                                  \r\n                  |_|                                  ");

        //}

        //static void LogginInSound()
        //{
        //    int C = 264;
        //    int D = 297;
        //    int E = 330;
        //    int F = 352;
        //    int G = 396;
        //    int A = 440;
        //    int B = 495;
        //    int C2 = 528;


        //    int half = 1000 / 2;
        //    int quarter = 1000 / 4;



        //    Console.Beep(C, quarter);
        //    Console.Beep(D, quarter);
        //    Console.Beep(E, quarter);
        //    Console.Beep(F, quarter);
        //    Console.Beep(G, quarter);
        //    Console.Beep(A, quarter);
        //    Console.Beep(B, quarter);
        //    Console.Beep(C2, half);
        //    Thread.Sleep(quarter);


        //}


    }

    }

