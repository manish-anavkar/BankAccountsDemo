using BankAccountsDemo;

namespace BankAccountsDemoTests
{
    public class BankAccountDemoTests
    {
        private Bank bank;
        private IAccount checkingAccount;
        private IAccount indiInvestmentAccount;
        private IAccount corpInvestmentAccount;

        [SetUp]
        public void Setup()
        {
            // Arrange
            bank = new Bank { Name = "Oceanside Bank" };
            checkingAccount = new CheckingAccount { Owner = "John Doe", Balance = 0 };
            indiInvestmentAccount = new InvestmentAccount { Owner = "Jane Doe", Balance = 0, AccountType = Constants.InvestmentAccountTypes.Individual };
            corpInvestmentAccount = new InvestmentAccount { Owner = "Jane Doe", Balance = 0, AccountType = Constants.InvestmentAccountTypes.Corporate };
        }

        [Test]
        public void TestCheckingDeposit()
        {
            // Act & Assert
            checkingAccount.Deposit(1000);
            Assert.That(checkingAccount.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void TestCheckingWithdraw()
        {
            // Act & Assert
            checkingAccount.Deposit(1000);
            checkingAccount.Withdraw(300);
            Assert.That(checkingAccount.Balance, Is.EqualTo(700));
        }

        [Test]
        public void TestCheckingWithdrawFailure()
        {
            // Act & Assert
            checkingAccount.Deposit(400);
            Assert.Throws<Exception>(() => checkingAccount.Withdraw(450));
        }

        [Test]
        public void TestInvestmentDeposit()
        {
            // Act & Assert
            indiInvestmentAccount.Deposit(1000);
            Assert.That(indiInvestmentAccount.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void TestInvestmentWithdraw()
        {
            // Act & Assert
            indiInvestmentAccount.Deposit(1000);
            indiInvestmentAccount.Withdraw(200);
            Assert.That(indiInvestmentAccount.Balance, Is.EqualTo(800));
        }

        [Test]
        public void TestIndiInvestmentWithdrawalLimit()
        {
            // Act & Assert
            indiInvestmentAccount.Deposit(1000);
            Assert.Throws<Exception>(() => indiInvestmentAccount.Withdraw(501));
        }

        [Test]
        public void TestCorpInvestmentNoWithdrawalLimit()
        {
            // Act & Assert
            corpInvestmentAccount.Deposit(1000);
            corpInvestmentAccount.Withdraw(501);
            Assert.That(corpInvestmentAccount.Balance, Is.EqualTo(499));
        }

        [Test]
        public void TestInvestmentWithdrawFailure()
        {
            // Act & Assert
            indiInvestmentAccount.Deposit(300);
            Assert.Throws<Exception>(() => indiInvestmentAccount.Withdraw(400));
        }

        [Test]
        public void TestCheckingToInvestmentTransfer()
        {
            // Act & Assert
            checkingAccount.Deposit(1000);
            checkingAccount.Transfer(indiInvestmentAccount, 300);
            Assert.That(checkingAccount.Balance, Is.EqualTo(700));
            Assert.That(indiInvestmentAccount.Balance, Is.EqualTo(300));
        }

        [Test]
        public void TestInvestmentToCheckingTransfer()
        {
            // Act & Assert
            corpInvestmentAccount.Deposit(1000);
            checkingAccount.Deposit(200);
            corpInvestmentAccount.Transfer(checkingAccount, 300);
            Assert.That(corpInvestmentAccount.Balance, Is.EqualTo(700));
            Assert.That(checkingAccount.Balance, Is.EqualTo(500));
        }

        [Test]
        public void TestInvestmentTransferFailure()
        {
            // Act & Assert
            indiInvestmentAccount.Deposit(600);
            Assert.Throws<Exception>(() => indiInvestmentAccount.Transfer(corpInvestmentAccount, 605));
        }
    }
}