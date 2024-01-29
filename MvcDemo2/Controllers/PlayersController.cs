using Microsoft.AspNetCore.Mvc;
using MvcDemo2.Models;

namespace MvcDemo2.Controllers
{
    public class PlayersController : Controller
    {
        public static List<Player> Players { get; set; } = new()
        {
            new Player { Id = 1, Username = "ShadowStriker", Level = 5 },
            new Player { Id = 2, Username = "PixelNinja", Level = 10 },
            new Player { Id = 3, Username = "MysticWarrior", Level = 7 },
            new Player { Id = 4, Username = "GalacticRanger", Level = 12 },
            new Player { Id = 5, Username = "AquaReaper", Level = 3 },
            new Player { Id = 6, Username = "FirePhoenix", Level = 8 },
            new Player { Id = 7, Username = "IronVanguard", Level = 6 },
            new Player { Id = 8, Username = "StormChaser", Level = 9 },
            new Player { Id = 9, Username = "BladeMaster", Level = 11 },
            new Player { Id = 10, Username = "CelestialMage", Level = 4 },
            new Player { Id = 11, Username = "QuantumKnight", Level = 15 },
            new Player { Id = 12, Username = "EclipseAssassin", Level = 13 },
            new Player { Id = 13, Username = "FrostSentinel", Level = 2 },
            new Player { Id = 14, Username = "SolarSorcerer", Level = 16 },
            new Player { Id = 15, Username = "VoidWalker", Level = 14 },
            new Player { Id = 16, Username = "ThunderGuardian", Level = 1 },
            new Player { Id = 17, Username = "RuneSeeker", Level = 18 },
            new Player { Id = 18, Username = "LightBringer", Level = 17 },
            new Player { Id = 19, Username = "DarknessSlayer", Level = 19 },
            new Player { Id = 20, Username = "StarGazer", Level = 20 },
        };

        // Visa en view med alla spelare
        public IActionResult Index()
        {
            return View(Players);
        }

        // Visa en view med en spelare
        public IActionResult Details(int id)
        {
            Player selectedPlayer = Players.FirstOrDefault(p => p.Id == id);

            return View(selectedPlayer);
        }
    }
}
