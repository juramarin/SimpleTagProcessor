﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTagProcessor.Data
{
    public class InMemoryCompanyRepository : ICompanyRepository
    {
        private readonly IDictionary<long, string> _companies;

        public InMemoryCompanyRepository()
        {
            _companies = new Dictionary<long, string>
            {
                {3319361,"Sanford LLC"},
                {6314853123,"Gleichner, Rodriguez and Wilkinson"},
                {39266333,"Mertz, O'Conner and Heaney"},
                {213645,"McGlynn Inc"},
                {178504,"Thompson LLC"},
                {964495,"Halvorson and Sons"},
                {585675,"Torphy-Becker"},
                {9488123,"Kunze, Wilkinson and Sawayn"},
                {86906,"Blanda-Hagenes"},
                {2973701,"Bednar-Mitchell"},
                {7942595,"Hilpert Group"},
                {587451,"Lindgren, Witting and Wiegand"},
                {40777411,"Larson, Reilly and Cruickshank"},
                {227113,"Walsh-Schamberger"},
                {3733204,"Orn-Langosh"},
                {885734,"Deckow LLC"},
                {2871566,"Lueilwitz, Schumm and Walsh"},
                {584202,"Bailey LLC"},
                {5032891234,"Sawayn-Gibson"},
                {1999335,"Gibson-Cormier"},
                {83250532,"Fisher Inc"},
                {516232,"Leffler-Torphy"},
                {43907,"Nolan-Walter"},
                {4584903,"Heller, Koepp and Powlowski"},
                {983682,"Dickens and Sons"},
                {686748,"Steuber-Stracke"},
                {678362,"Lynch, Yundt and Howe"},
                {591271,"Lakin, Prosacco and Terry"},
                {69124,"Mondelēz International"},
                {107222,"Armstrong-Schinner"},
                {140037,"Torp-Reynolds"},
                {750917,"Becker, Schaefer and Greenholt"},
                {317580317580,"Medhurst-Romaguera"},
                {390007,"Carter-Reynolds"},
                {528209,"Morissette LLC"},
                {2180435,"Gottlieb, Stroman and Grimes"},
                {823332,"Durgan, Hahn and Runolfsdottir"},
                {511751,"Spencer, Block and Marks"},
                {543540,"Kozey Group"},
                {826025,"Little Group"},
                {110720,"O'Hara LLC"},
                {33314622,"Weissnat and Sons"},
                {764493764493,"Okuneva, Schneider and Collins"},
                {428651,"Cole LLC"},
                {950316,"Keeling, Nikolaus and Larkin"},
                {870953,"Dach-Herzog"},
                {8393604321,"Wolf Inc"},
                {719065,"Legros-Cruickshank"},
                {758601,"Schmeler-Lind"},
                {368305,"Macejkovic-Murazik"},
                {791586,"Raynor LLC"},
                {28600054,"Mosciski, Maggio and DuBuque"},
                {608240,"Von, Gusikowski and Farrell"},
                {60643,"Beer, Batz and Koch"},
                {127083,"Watsica-Labadie"},
                {178540,"Tromp-Pacocha"},
                {51578,"Kuvalis, Doyle and Flatley"},
                {21276,"Feil Inc"},
                {745230,"Nitzsche-Gerlach"},
                {107956107956,"Rodriguez, Beier and Ratke"},
                {7002011,"Orn, Ortiz and Keebler"},
                {4619611,"Rolfson, Collins and Runolfsson"},
                {108653,"Rath, Ferry and Moen"},
                {814875,"Cummerata-Schaden"},
                {378922,"Rowe-Gibson"},
                {4499823,"Daugherty, Hettinger and Koelpin"},
                {1210999912,"Heidenreich-Kessler"},
                {900706,"Weimann-Casper"},
                {7408273,"Stark-McCullough"},
                {828415,"Weber-Reichel"},
                {451802,"Koelpin, Kozey and Grimes"},
                {169691,"Smitham Group"},
                {563974,"Gusikowski-Leuschke"},
                {77605,"Shanahan, Bernier and Funk"},
                {349605,"Harvey-Weber"},
                {342472,"Macejkovic, Towne and Spencer"},
                {770270770270,"Halvorson, Schinner and Smitham"},
                {327884,"Welch and Sons"},
                {812302,"Spinka, Hauck and Bogan"},
                {905710,"Jakubowski-Veum"},
                {997970,"Stark-Ward"},
                {917969,"Aufderhar Group"},
                {96652,"Wisoky-Roob"},
                {51151534,"Schmidt-Quigley"},
                {5023208822,"Smitham, Swaniawski and Upton"},
                {446617,"Koelpin Inc"},
                {13332,"Little, King and Zboncak"},
                {600851600851,"O'Conner-Turner"},
                {196645,"Lynch-Fay"},
                {4984121,"O'Reilly Inc"},
                {676413,"Hayes-Schumm"},
                {485771,"Morar-Schulist"},
                {793681,"Carroll-Hammes"},
                {3209622,"Windler-Stark"},
                {823413,"Johnson-Donnelly"},
                {623828,"Wolf and Sons"},
                {655062,"Zboncak Inc"},
                {472731472731,"Dicki Group"},
                {443750,"Cole, Kemmer and Turner"},
                {2777462999,"Gottlieb-Denesik"}
            };
        }

        public IDictionary<long, string> GetCompanies()
        {
            return _companies;
        }
    }
}
