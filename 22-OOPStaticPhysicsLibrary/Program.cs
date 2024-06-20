using _22_OOPStaticPhysicsLibrary;
using System.Security.Authentication.ExtendedProtection;
using System.Transactions;

Physics physics = new Physics();
Physics.Gravity = 9.8m;

//a static class MUST have static members. however a normal class might have static members.

Console.WriteLine(ExtensionMethods.ClearString("BIlge Adâm AKADEMI KadIKöy ŞUBESİ BooST YılDIZ YazILIMCI ProgRAMı")); //here we wrote a static method to clear a string and return the cleared text. we did it under a normal class.
string isim = "BIlge Adâm AKADEMI KadIKöy ŞUBESİ BooST YılDIZ YazILIMCI ProgRAMı";
Console.WriteLine(isim.ClearString());
