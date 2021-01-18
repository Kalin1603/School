namespace Кафемашина
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const double espresoBZ = 0.90;
            const double espresoN = 1.00;
            const double espresoDZ = 1.20;

            const double kapuchinoBZ = 1.00;
            const double kapuchinoN = 1.20;
            const double kapuchinoDZ = 1.60;

            const double chaiBZ = 0.50;
            const double chaiN = 0.60;
            const double chaiDZ = 0.70;

            string napitka = Console.ReadLine();
            string zahar = Console.ReadLine();
            int broiNapitki = int.Parse(Console.ReadLine());

            switch (napitka)
            {
                case "Espresso":
                    switch (zahar)
                    {
                        case "Without":

                            double cenaEspresoBZ = broiNapitki * espresoBZ;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaEspresoBZ}");
                            double otstupkaBZ = cenaEspresoBZ - cenaEspresoBZ * 0.35;
                            Console.WriteLine($"Otstupka za napitka bez zahar -> {otstupkaBZ}");
                            double otstupkaPriPokupka = otstupkaBZ - otstupkaBZ * 0.25;
                            Console.WriteLine($"Otstupka pri pokupka na pone 5 broq espreso -> {otstupkaPriPokupka}");
                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupkaPriPokupka} lv.");

                            break;

                        case "Normal":

                            double cenaEspresoN = broiNapitki * espresoN;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaEspresoN}");
                            double otstupkaN = cenaEspresoN - cenaEspresoN * 0.35;
                            Console.WriteLine($"Otstupka za napitka bez zahar -> {otstupkaN}");
                            double otstupkaPriPokupkaN = otstupkaN - otstupkaN * 0.25;
                            Console.WriteLine($"Otstupka pri pokupka na pone 5 broq espreso -> {otstupkaPriPokupkaN}");
                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupkaPriPokupkaN} lv.");

                            break;

                        case "Extra":

                            double cenaEspresoDZ = broiNapitki * espresoDZ;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaEspresoDZ}");
                            double otstupkaDZ = cenaEspresoDZ - cenaEspresoDZ * 0.35;
                            Console.WriteLine($"Otstupka za napitka bez zahar -> {otstupkaDZ}");
                            double otstupkaPriPokupkaDZ = otstupkaDZ - otstupkaDZ * 0.25;
                            Console.WriteLine($"Otstupka pri pokupka na pone 5 broq espreso -> {otstupkaPriPokupkaDZ}");

                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupkaPriPokupkaDZ} lv.");

                            break;

                        default:
                            break;
                    }
                    break;

                case "Cappuccino":
                    switch (zahar)
                    {
                        case "Without":

                            double cenaKapuchinoBZ = broiNapitki * kapuchinoBZ;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaKapuchinoBZ}");

                            if (cenaKapuchinoBZ >= 15.00)
                            {
                                double otstupka1N = cenaKapuchinoBZ - cenaKapuchinoBZ * 0.2;

                                Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupka1N} lv.");
                            }

                            break;

                        case "Normal":

                            double cenaKapuchinoN = broiNapitki * kapuchinoN;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaKapuchinoN}");

                            if (cenaKapuchinoN >= 15.00)
                            {
                                double otstupka1N = cenaKapuchinoN - cenaKapuchinoN * 0.2;

                                Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupka1N} lv.");
                            }

                            break;

                        case "Extra":

                            double cenaKapuchinoDZ = broiNapitki * kapuchinoDZ;
                            Console.WriteLine($"Cena Espreso bez zahar -> {cenaKapuchinoDZ}");

                            if (cenaKapuchinoDZ >= 15.00)
                            {
                                double otstupka1N = cenaKapuchinoDZ - cenaKapuchinoDZ * 0.2;

                                Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {otstupka1N} lv.");
                            }

                            break;

                        default:
                            break;
                    }
                    break;

                case "Tea":
                    switch (zahar)
                    {
                        case "Without":

                            double cenaChaiBZ = broiNapitki * chaiBZ;
                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {cenaChaiBZ:f2} lv.");

                            break;

                        case "Normal":

                            double cenaChaiN = broiNapitki * chaiN;
                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {cenaChaiN:f2} lv.");

                            break;

                        case "Extra":

                            double cenaChaiDZ = broiNapitki * chaiDZ;
                            Console.WriteLine($"You bought {broiNapitki} cupsof {napitka} for {cenaChaiDZ:f2} lv.");

                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}



