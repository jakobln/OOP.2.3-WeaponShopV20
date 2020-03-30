namespace WeaponShopV20
{
    public class Sword : Weapon
    {
        public const int InitialSwordMinDamage = 30;
        public const int InitialSwordMaxDamage = 75;

        #region Constructor
        public Sword(string description) : base(description, InitialSwordMinDamage, InitialSwordMaxDamage)
        {
        }
        #endregion

        #region Methods
        public override int DealDamage()
        {
            while (true)
            {
                int Random = base.RandomNumber(1,10);
                System.Console.WriteLine($"The random number is {Random}");

                if (Random == 10)
                {
                    int damage = Beheading();
                    return damage;
                }

                else
                {
                    MinDamage = InitialSwordMinDamage;
                    MaxDamage = InitialSwordMaxDamage;
                    int damage = base.DealDamage();
                    MinDamage = MinDamage < 3 ? 0 : MinDamage - 3;
                    MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 3;
                    return damage;
                }
            }
        }

        public int Beheading()
        {
            MinDamage = 1000;
            MaxDamage = 1000;
            int damage = base.DealDamage();
            return damage;
        }

        public void Sharpen()
        {
            MinDamage = InitialSwordMinDamage;
            MaxDamage = InitialSwordMaxDamage;
        } 
        #endregion
    }
}