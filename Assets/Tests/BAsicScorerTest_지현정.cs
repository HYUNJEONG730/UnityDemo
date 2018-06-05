using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDemo.Models.Scorers;
using NUnit.Framework;
using UnityDemo.Models;

namespace Assets.Tests
{
    class BasicScorerTest_지현정
    {
        [Test]
        public void 광땡으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("현정");//101점
            p1.AddCard(new Card(1, true));
            p1.AddCard(new Card(3, true));

            Player p2 = new Player("문범");//7점
            p2.AddCard(new Card(2, false));
            p2.AddCard(new Card(5, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

        [Test]
        public void 땡으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("현정");//100점
            p1.AddCard(new Card(10, true));
            p1.AddCard(new Card(10, true));

            Player p2 = new Player("문범");//6점
            p2.AddCard(new Card(4, false));
            p2.AddCard(new Card(2, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

        [Test]
        public void 끗으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("현정");//4점
            p1.AddCard(new Card(9, true));
            p1.AddCard(new Card(5, true));

            Player p2 = new Player("문범");//1점
            p2.AddCard(new Card(7, false));
            p2.AddCard(new Card(4, false));



            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

    }
}
