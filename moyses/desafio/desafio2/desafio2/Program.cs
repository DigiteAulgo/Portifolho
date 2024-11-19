using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        bool pr = false, pr2 = false;
        double pc, od;
        while(pr==false)
        {
            Console.WriteLine("\ndigite sua horas trabalhadas: ");
            double h=double.Parse(Console.ReadLine());
            Console.WriteLine("\ndigite o valor das horas trabalhadas: ");
            double vh=double.Parse(Console.ReadLine());
            Console.WriteLine("\nvoce tem vale trasporte?:\ns=sim\nn=nao");
            string op=Console.ReadLine();
            double sl = vh * h;
            if(op=="s")
            {
                double vt = (sl / 100) * 6 - sl;
                if(sl<1320.0)
                {
                    double inss = (sl / 100) * 7.50 - sl;
                    double sb = (vt + inss);
                }
                else if(sl<2571.29)
                {
                    double inss = (sl / 100) * 9.00 - sl;
                    double sb = (vt + inss);
                }
                else if (sl<3856.94)
                {
                    double inss = (sl / 100) * 12.00 - sl;
                    double sb = (vt + inss);
                }
                else
                {
                    double inss = (sl / 100) * 14.00 - sl;
                    double sb = (vt + inss);
                }
                

                if (sl < 2112.0)
                {
                    double irpf = 0;
                }
                else if (sl < 2826.65)
                {
                    double irpf = (sl / 100) * 7.50 - sl;
                }
                else if (sl < 3751.06)
                {
                    double irpf = (sl / 100) * 15.00 - sl;
                }
                else if (sl <4664.68)
                {
                    double irpf = (sl / 100) * 22.50 - sl;
                }
                else
                {
                    double irpf = (sl / 100) * 27.50 - sl;
                }
                Console.WriteLine("\ntem outras deduções:\ns=sim\nn=nao");
                string op2=Console.ReadLine();
                if(op2 =="s")
                {
                    Console.WriteLine("que porcentagem");
                    pc=double.Parse(Console.ReadLine());
                    od=(sl / 100) * pc - sl;
                }
                
                
            }
            else if(op=="n")
            {

            }
            else
            {
                
            }
        }
    }
}