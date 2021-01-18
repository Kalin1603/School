namespace Players_and_Monsters
{
    using System;
    public class Program
    {
       public static void Main()
        {
            Hero hero = new Hero("Vallhalla",35);
            Elf elf = new Elf("Mugy",20);
            Wizard wizard = new Wizard("Plateu", 50);
            Knight knight = new Knight("Barey", 200);
            MuseElf museElf = new MuseElf("Tracy", 10);
            DarkWizard darkWizard = new DarkWizard("Protorabe", 350);
            DarkKnight darkKnight = new DarkKnight("Unstoppable", 500);
            SoulMaster soulMaster = new SoulMaster("Lingly", 220);
            BladeKnight bladeKnight = new BladeKnight("Killer", 330);

            Console.WriteLine
                (
                $"" +
                $"{hero}\n" +
                $"{elf}\n" +
                $"{wizard}\n" +
                $"{knight}\n" +
                $"{museElf}\n" +
                $"{darkWizard}\n" +
                $"{darkKnight}\n" +
                $"{soulMaster}\n" +
                $"{bladeKnight}"
                );
        }
    }
}
