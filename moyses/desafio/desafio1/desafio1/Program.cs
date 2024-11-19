internal class Program
{
    private static void Main(string[] args)
    {
        bool pr = false, pr2 = false;
        while (pr == false) 
        {
            Console.WriteLine("\ndigite seu nome: \nse quiser encerrar o progama digite; fim");
            string nome=Console.ReadLine();
            Console.WriteLine("\ndigite seu genero biologico:\nm=homem\nf=mulher\n");
            string genero=Console.ReadLine();
            Console.WriteLine("\ndigite seu peso: ");
            double peso=double.Parse(Console.ReadLine());
            Console.WriteLine("\ndigite sua altura: ");
            double altura =double.Parse(Console.ReadLine());
            double imc=peso/(altura*altura);
            double peso2 = peso;
            if (nome == "fim")
            {
                pr = true;
            }
            else if (genero == "f")
            {
                if (imc < 19.1)
                {
                    Console.WriteLine("\nabaixo do peso");
                }
                else if (imc < 25.8)
                {
                    Console.WriteLine("\nno peso normal");
                }
                else if (imc < 27.3)
                {
                    Console.WriteLine("\nmarginalmente acima do peso");
                }
                else if (imc < 32.3)
                {
                    Console.WriteLine("acima do peso ideal");
                }
                else
                {
                    Console.WriteLine("obeso");
                }
                while(pr2 == false)
                {
                    if(imc < 19.1)
                    {
                        peso = peso + 1;
                        double imc2= peso / (altura * altura);
                        if (imc2 >= 19.1)
                        {
                            Console.WriteLine("\n" + nome + " precisa ganhar: " +(peso-peso2));
                            pr2 = true;
                        }
                    }
                    else if(imc > 25.8)
                    {
                        peso= peso - 1;
                        double imc2 = peso / (altura * altura);
                        if (imc2 <= 25.8)
                        {
                            Console.WriteLine("\n" + nome + " precisa perde: " + (peso2 - peso));
                            pr2 = true;
                        }
                    }
                    else
                    {
                        pr2 = true;
                    }
                }
                pr2 = false;

            }
            else if (genero == "m") 
            {
                if (imc < 20.7)
                {
                    Console.WriteLine("\nabaixo do peso");
                }
                else if (imc < 26.4)
                {
                    Console.WriteLine("\nno peso normal");
                }
                else if (imc < 27.8)
                {
                    Console.WriteLine("\nmarginalmente acima do peso");
                }
                else if (imc < 31.1)
                {
                    Console.WriteLine("acima do peso ideal");
                }
                else
                {
                    Console.WriteLine("obeso");
                }
                while (pr2 == false)
                {
                    if (imc < 20.7)
                    {
                        peso = peso + 1;
                        double imc2 = peso / (altura * altura);
                        if (imc2 >= 20.7)
                        {
                            double pesof=peso - peso2;
                            Console.WriteLine("\n" + nome + " precisa ganhar: " + (pesof));
                            pr2 = true;
                        }
                    }
                    else if (imc > 26.4)
                    {
                        peso = peso - 1;
                        double imc2 = peso / (altura * altura);
                        if (imc2 <= 26.4)
                        {
                            Console.WriteLine("\n" + nome + " precisa perde: " + (peso2 - peso));
                            pr2 = true;
                        }
                    }
                    else
                    {
                        pr2 = true;
                    }
                }
                pr2 = false;
            }
            else
            {
                Console.WriteLine("dado incorreto, repita o progama");
            }
        }
        
    }
}