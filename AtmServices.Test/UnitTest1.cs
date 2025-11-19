using AtmServices;

namespace AtmServices.Test;

public class UnitTest1
{
    [Fact]
    public void TestInitialBalance()
    {
        var atm = new Atm(100);
        Assert.Equal(100, atm.getBalance());
    }

    [Fact]
    public void TestSuccessfulWithdraw()
    {
        var atm = new Atm(100);
        bool result = atm.withdraw(50);
        Assert.True(result);
        Assert.Equal(50, atm.getBalance());
    }

    [Fact]
    public void TestFailedWithdraw()
    {
        var atm = new Atm(100);
        bool result = atm.withdraw(150);
        Assert.False(result);
        Assert.Equal(100, atm.getBalance());
    }

    [Fact]
    public void TestSuccessfulDeposit()
    {
        var atm = new Atm(100);
        bool result = atm.deposit(50);
        Assert.True(result);
        Assert.Equal(150, atm.getBalance());
    }

    [Fact]
    public void TestNegativeDeposit()
    {
        var atm = new Atm(100);
        bool result = atm.deposit(-50);
        Assert.False(result);
        Assert.Equal(100, atm.getBalance());
    }
}