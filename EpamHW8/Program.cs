namespace EpamHW8
{
    internal class Program
    {
        //Створити абстрактний базовий клас Небесне тіло (HeavenlyBody), та похідні класи Земля (Earh) та Місяць (Moon).
        //Клас Heavenly Body має абстрактні методи ReportAboutMovement() (повідомити навколо якого небесного тіла рухається об'єкт) та ReportAboutLife()
        //(повідомити про наявність життя). Кожний з похідних класів перевизначає методи Report About Movement(), ReportAboutLife() базового класу.
        //Використати принцип поліморфізму для виведення текстових повідомлень щодо руху та наявності життя на Землі та Місяці. Для цього:
        //1. Створити масив об'єктів типу HeavenlyBody
        //2. Створити по одному об'єкту класів Earh та Moon і додати їх до масиву.
        //3. За допомогою оператору циклу foreach для кожного елементу масиву через посилання на тип Heavenly Body викликати методи ReportAbout Movement(), ReportAboutLife().        
        static void Main(string[] args)
        {
            Earth earth = new Earth();
            Moon moon = new Moon();
            HeavenlyBody[] heavenlyBodies = { earth, moon };
            foreach (HeavenlyBody obj in heavenlyBodies) 
            { 
                obj.ReportAboutMovement();
                obj.ReportAboutLife();
            }
        }
    }
}