using Calculator_using_Delegates;
using static Calculator_using_Delegates.Calculate;

Calculate cal = new Calculate();
CalculateDelegate calDelegateObject = new CalculateDelegate(cal.CalAdd);

calDelegateObject += cal.CalSubtract;
    calDelegateObject += cal.CalMultiply;
calDelegateObject += cal.CalDivide;

calDelegateObject += cal.CalRemainderOrModulus;

calDelegateObject(2.3, 4.5);