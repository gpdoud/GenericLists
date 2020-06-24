using System;
using System.Collections.Generic;

namespace ListOfScores {
    class Program {
        static void Main(string[] args) {
            RunSimFields();
        }
        static void RunSimFields() {
            
            var accounts = new Dictionary<int, Account>();

            var acct1 = new Account {
                AccountNumber = 1, Description = "1st Account", Balance = 1000
            };
            var acct2 = new Account {
                AccountNumber = 2, Description = "2nd Account", Balance = 2000
            };
            var acct3 = new Account {
                AccountNumber = 3, Description = "3rd Account", Balance = 3000
            };

            var accountList = new List<Account>(new Account[] { acct1, acct2, acct3 });
            foreach(var acct in accountList) {
                if(acct.AccountNumber == 3) {
                    break;
                }
            }

            accounts.Add(acct1.AccountNumber, acct1);
            accounts.Add(acct2.AccountNumber, acct2);
            accounts.Add(acct3.AccountNumber, acct3);

            var selectedAccount = accounts[3];

        }
        static void RunBowling() {
            Random rnd = new Random();
            var frames = new List<int>(10);
            for(var idx = 0; idx < 10; idx++) {
                var score = rnd.Next(0, 31);
                frames.Add(score);
            }
            var total = 0;
            foreach(var frame in frames) {
                total += frame;
            }
            Console.WriteLine($"Score is {total}");
        }
        static void Run1() { 

            var scores = new List<int>();
            scores.Add(42);
            scores.Add(98);
            scores.Add(66);
            scores.Add(5);
            scores.Add(100);

            var fixedScores = scores.ToArray();
            var genericFixedScore = new List<int>(fixedScores);

            var total = 0;
            foreach(var item in scores) {
                total += item;
            }

        }
    }
}
