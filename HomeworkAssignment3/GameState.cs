using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment3
{
    class GameState
    {
        Player PlayerOne;
        Map WorldMap;
        Enemy EnemyOne, EnemyTwo;
        int worldWidth, worldHeight;
        public GameState()
        {
            PlayerOne = new Player();
            WorldMap = new Map();
            EnemyOne = new Enemy();
            EnemyTwo = new Enemy();
            worldWidth = 10000;
            worldHeight = 10000;

            WorldMap.SetSize(worldWidth, worldHeight);
            PlayerOne.setLocation(worldWidth / 2, worldHeight / 2);
            EnemyOne.setLocation(worldWidth / 4, worldHeight / 4);
            EnemyTwo.setLocation(3*worldWidth / 4, 3*worldHeight / 4);
        }

        public Boolean enemyHitPlayer(Enemy enemy)
        {
            return (enemy.X ==  PlayerOne.X && enemy.Y == PlayerOne.Y);
        }

        public void mainLoop()
        {
            for (;;)
            {
                PlayerOne.readInput();
                EnemyOne.MoveTowardsPlayer(PlayerOne.X, PlayerOne.Y);
                EnemyTwo.MoveTowardsPlayer(PlayerOne.X, PlayerOne.Y);
                if(enemyHitPlayer(EnemyOne) || enemyHitPlayer(EnemyTwo))
                {
                    PlayerOne.Die();
                }
                if (PlayerOne.IsDead)
                {
                    Console.WriteLine(" Enemy hit player, player is now dead. ");
                    break;
                }
            }
        }

    }
}
