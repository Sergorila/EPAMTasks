using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.Entities.Map;
using Game.Entities.Map.Cells;
using Game.Entities.Map.Items;
using Game.Entities.Subjects;

namespace Game
{
    public class Play
    {
        private Field _field;
        private Player _player;
        private List<Monster> _monsters = new List<Monster>(5);
        private List<Item> _items = new List<Item>(5);

        public Play(int width, int height)
        {
            _field = new Field(width, height);
            _player = new Player();
            AddMonsters();
            AddItems();
            GameControll();
        }

        private void GameControll()
        {
            //отслеживает все действия
        }

        private void PlayerMove(Cell cell)
        {
            //отслеживание передвижения игрока по полю
        }

        private void MonsterMove()
        {
            //отслеживание передвижения монстров по полю
        }

        private void AddMonsters()
        {
            //добавляет случайных монтров на карту
        }

        private void AddItems()
        {
            //добавляет случайные итемы на карту
        }

        private void CheckCell(Cell cell)
        {
            //проверяет событие в данной ячейке
            //1. стоит ли там враг
            //2. есть ли там препятствие или ловушка
            //3. содержит ли предмет
        }

        private void TheEnd()
        {
            if (_player.Health <= 0)
            {
                Console.WriteLine("WASTED");
                return;
            }
            if (_player.Items == 5)
            {
                Console.WriteLine("#1 Victory Royal!");
                return;
            }
        }
    }
}
