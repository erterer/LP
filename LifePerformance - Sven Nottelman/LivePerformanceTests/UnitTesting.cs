using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifePerformance___Sven_Nottelman.Data;
using LifePerformance___Sven_Nottelman.Forms;
using LifePerformance___Sven_Nottelman.Logic;
using LifePerformance___Sven_Nottelman.Models;
using System.Collections.Generic;
using LifePerformance___Sven_Nottelman;

namespace LivePerformanceTests
{
    [TestClass]
    public class UnitTesting
    {
        private ProjectRepository projectRepo;
        private DierenRepository dierenRepo;

        [TestInitialize]
        public void Initialize()
        {
            projectRepo = new ProjectRepository(new ProjectOracleContext());
            dierenRepo = new DierenRepository(new DierenOracleContext());
        }

        /// <summary>
        /// Testen van de database
        /// </summary>
        [TestMethod]
        public void TestOphalenDieren()
        {
            List<Dier> dieren = new List<Dier>();
            bool test = dierenRepo.HaalDierenOp();
            dieren = dierenRepo.Dieren;

            Assert.AreEqual(true, test);
            Assert.AreNotEqual(0, dieren.Count);
        }

        /// <summary>
        /// Testen van de database
        /// </summary>
        [TestMethod]
        public void TestOphalenProjecten()
        {
            List<Project> projecten = new List<Project>();
            bool test = projectRepo.HaalProjectenOp();
            projecten = projectRepo.Projecten;

            Assert.AreEqual(true, test);
            Assert.AreNotEqual(0, projecten.Count);
        }

        /// <summary>
        /// Testen van de models
        /// </summary>
        [TestMethod]
        public void TestWaarneming()
        {
            Waarneming w = new Waarneming("Gans", SoortWaarneming.NestIndicerend, DateTime.Now.Date, 10, new Vogel("Gans", "G"));

            Assert.AreEqual("Gans", w.Naam);
            Assert.AreEqual(SoortWaarneming.NestIndicerend, w.Soort);
            Assert.AreEqual(DateTime.Now.Date, w.Tijdstip);
            Assert.AreEqual(10, w.Punten);
            Assert.AreEqual("Gans", w.Dier.Naam);
            Assert.AreEqual("G", w.Dier.Afkorting);
        }

        /// <summary>
        /// Testen van de models
        /// </summary>
        [TestMethod]
        public void TestProject()
        {
            Project p = new Project("Sven Nottelman");
            p.bezoeken.Add(new Bezoek(DateTime.Now.Date, DateTime.Now.Date));

            Assert.AreEqual("Sven Nottelman", p.Naam);
            Assert.AreNotEqual(0, p.bezoeken.Count);
        }

        /// <summary>
        /// Testen van de models
        /// </summary>
        [TestMethod]
        public void TestGebied()
        {
            Gebied g = new Gebied("Veluwe");

            Assert.AreEqual("Veluwe", g.Naam);
        }

        /// <summary>
        /// Forms testen
        /// </summary>
        [TestMethod]
        public void TestFormOpties()
        {
            Bezoek b = new Bezoek(DateTime.Now.Date, DateTime.Now.Date);
            Project p = new Project("Sven Nottelman");
            var v = new formOpties(b, p);

            Assert.IsNotNull(v);
        }

        /// <summary>
        /// Forms testen
        /// </summary>
        [TestMethod]
        public void TestFormBezoek()
        {
            Project p = new Project("Sven Nottelman");
            var v = new formBezoek(p, DateTime.Now.Date, DateTime.Now.Date);

            Assert.IsNotNull(v);
        }

        /// <summary>
        /// Forms testen
        /// </summary>
        [TestMethod]
        public void TestHoofdForm()
        {
            var v = new Hoofdscherm();

            Assert.IsNotNull(v);
        }
    }
}
