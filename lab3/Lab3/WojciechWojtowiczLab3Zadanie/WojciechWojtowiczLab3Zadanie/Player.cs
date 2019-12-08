using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab3Zadanie
{
    public class Player
    {
        //numer gracza
        int userId;
        //pieniadze
        int money;
        //honor
        int honor;
        //karta wedkarska czy jest posiadana
        bool fishingCard;
        //czy zdany jest egzamin na kartę
        bool passedExam;
        //lista obieków typu Fish
        List<Fish> fishList = new List<Fish>();

        /// <summary>
        /// konstruktor ustawia pola na wartosci domyslne
        /// </summary>
        public Player()
        {
            money = 0;
            honor = 0;
            fishingCard = false;
            passedExam = false;
            userId = 0;
        }

        /// <summary>
        /// akcesor ustawiający pole money
        /// </summary>
        /// <param name="_money"></param>
        public void SetMoney(int _money)
        {
            money = _money;
        }

        /// <summary>
        /// akcesor zwracajacy pole money
        /// </summary>
        /// <returns></returns>
        public int GetMoney()
        {
            return money;
        }

        /// <summary>
        /// akcesor ustawiający pole honor
        /// </summary>
        /// <param name="_honor"></param>
        public void SetHonor(int _honor)
        {
            honor = _honor;
        }

        /// <summary>
        /// akcesor zwracający pole honor
        /// </summary>
        /// <returns></returns>
        public int GetHonor()
        {
            return honor;
        }

        /// <summary>
        /// akcesor ustawiający pole fishingCard
        /// </summary>
        /// <param name="_fishingCard"></param>
        public void SetFishingCard(bool _fishingCard)
        {
            fishingCard = _fishingCard;
        }

        /// <summary>
        /// akcesor zwracajacy pole fishingCard
        /// </summary>
        /// <returns></returns>
        public bool GetFishingCard()
        {
            return fishingCard;
        }

        /// <summary>
        /// metoda dodaje element do listy
        /// </summary>
        /// <param name="fish"></param>
        public void AddFishToList(Fish fish)
        {
            fishList.Add(fish);
        }

        /// <summary>
        /// metoda zwracająca referencje do listy
        /// </summary>
        /// <returns></returns>
        public ref List<Fish> GetList()
        {
            return ref fishList;
        }

        /// <summary>
        /// akcesor ustawiający pole passedExam
        /// </summary>
        /// <param name="_passedExam"></param>
        public void SetPassedExam(bool _passedExam)
        {
            passedExam = _passedExam;
        }

        /// <summary>
        /// akcesor zwracający pole passedExam
        /// </summary>
        /// <returns></returns>
        public bool GetPassedExam()
        {
            return passedExam;
        }

        /// <summary>
        /// akcesor ustawiający pole userId
        /// </summary>
        /// <param name="_userId"></param>
        public void SetUserId(int _userId)
        {
            userId = _userId;
        }

        /// <summary>
        /// akcesor zwracający pole userId
        /// </summary>
        /// <returns></returns>
        public int GetUserId()
        {
            return userId;
        }
    }
}
