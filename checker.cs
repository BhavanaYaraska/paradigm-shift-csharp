using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
{
    static bool batteryIsOkWithTemp(float temperature) {
        if(temperature < 0 || temperature > 45) {
            Console.WriteLine("Temperature is out of range!");
            return false;
        } 
      return true;
      }
    static bool batteryIsOkWithSOC(float soc) {
        if(soc < 20 || soc > 80) {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        }
      return true;
        }
    static bool batteryIsOkWithChargeRate(float chargeRate) {
        if(chargeRate > 0.8) {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(batteryIsOkWithTemp(25));
        ExpectTrue(batteryIsOkWithSOC(70));
        ExpectTrue(batteryIsOkWithChargeRate(0.7f));
        ExpectFalse(batteryIsOkWithTemp(50));
         ExpectFalse(batteryIsOkWithSOC(85));
         ExpectFalse(batteryIsOkWithChargeRate(0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
    
}
}
