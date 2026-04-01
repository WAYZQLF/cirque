using Moncirque;
Accessoire a1 =new Accessoire("ballon","rouge",0.3,15,5);
Console.WriteLine(a1.ToString());
Personnel p1 = new Personnel("clovis", "jongleur");
Console.WriteLine(p1.ToString());
Utilisation u1 = new Utilisation(p1, a1);
Console.WriteLine(u1.ToString());
Utilisation u2 = new Utilisation(p1, a1);

