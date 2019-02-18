using System.Collections.Generic;

namespace SimpleTagProcessor.Data
{
    public class Item
    {
        public long CompanyPrefix { get; set; }
        public string CompanyName { get; set; }
        public long ItemReference { get; set; }
        public string ItemName { get; set; }
    }

    public class InMemoryItemRepository
    {
        public InMemoryItemRepository()
        {
            List<Item> tmpItems = new List<Item>()
            {
                new Item {CompanyPrefix = 13332, CompanyName ="Little, King and Zboncak", ItemReference = 4770766, ItemName = "Wine - Red Oakridge Merlot"},
                new Item {CompanyPrefix = 21276, CompanyName ="Feil Inc", ItemReference = 9837077, ItemName = "Coffee Cup 8oz 5338cd"},
                new Item {CompanyPrefix = 43907, CompanyName ="Nolan-Walter", ItemReference = 3406731, ItemName = "Beans - Kidney White"},
                new Item {CompanyPrefix = 51578, CompanyName ="Kuvalis, Doyle and Flatley", ItemReference = 9086830, ItemName = "Chicken - Leg / Back Attach"},
                new Item {CompanyPrefix = 60643, CompanyName ="Beer, Batz and Koch", ItemReference = 9948173, ItemName = "Chicken Breast Wing On"},
                new Item {CompanyPrefix = 69124, CompanyName ="Mondelēz International", ItemReference = 1253252, ItemName = "Milka Oreo"},
                new Item {CompanyPrefix = 77605, CompanyName ="Shanahan, Bernier and Funk", ItemReference = 5749311, ItemName = "Trout - Smoked"},
                new Item {CompanyPrefix = 86906, CompanyName ="Blanda-Hagenes", ItemReference = 1437603, ItemName = "Pasta - Penne, Rigate, Dry"},
                new Item {CompanyPrefix = 96652, CompanyName ="Wisoky-Roob", ItemReference = 6172545, ItemName = "Pork - Kidney"},
                new Item {CompanyPrefix = 107222, CompanyName ="Armstrong-Schinner", ItemReference = 797011, ItemName = "Honey - Comb"},
                new Item {CompanyPrefix = 108653, CompanyName ="Rath, Ferry and Moen", ItemReference = 1180386, ItemName = "Wine - Spumante Bambino White"},
                new Item {CompanyPrefix = 110720, CompanyName ="O'Hara LLC", ItemReference = 5041310, ItemName = "V8 Pet"},
                new Item {CompanyPrefix = 127083, CompanyName ="Watsica-Labadie", ItemReference = 5256251, ItemName = "Crush - Grape, 355 Ml"},
                new Item {CompanyPrefix = 140037, CompanyName ="Torp-Reynolds", ItemReference = 9818542, ItemName = "Beef - Shank"},
                new Item {CompanyPrefix = 169691, CompanyName ="Smitham Group", ItemReference = 87387, ItemName = "Almonds Ground Blanched"},
                new Item {CompanyPrefix = 178504, CompanyName ="Thompson LLC", ItemReference = 2577266, ItemName = "Straws - Cocktale"},
                new Item {CompanyPrefix = 178540, CompanyName ="Tromp-Pacocha", ItemReference = 3505943, ItemName = "Cheese - Ricotta"},
                new Item {CompanyPrefix = 196645, CompanyName ="Lynch-Fay", ItemReference = 1236529, ItemName = "Broccoli - Fresh"},
                new Item {CompanyPrefix = 213645, CompanyName ="McGlynn Inc", ItemReference = 6152432, ItemName = "Pickles - Gherkins"},
                new Item {CompanyPrefix = 227113, CompanyName ="Walsh-Schamberger", ItemReference = 5935575, ItemName = "Wine - Chateau Bonnet"},
                new Item {CompanyPrefix = 327884, CompanyName ="Welch and Sons", ItemReference = 7703818, ItemName = "Crab - Blue, Frozen"},
                new Item {CompanyPrefix = 342472, CompanyName ="Macejkovic, Towne and Spencer", ItemReference = 6004566, ItemName = "Tamarind Paste"},
                new Item {CompanyPrefix = 349605, CompanyName ="Harvey-Weber", ItemReference = 4548221, ItemName = "Wine - Zonnebloem Pinotage"},
                new Item {CompanyPrefix = 368305, CompanyName ="Macejkovic-Murazik", ItemReference = 2620417, ItemName = "Chocolate Eclairs"},
                new Item {CompanyPrefix = 378922, CompanyName ="Rowe-Gibson", ItemReference = 8414833, ItemName = "Chutney Sauce - Mango"},
                new Item {CompanyPrefix = 390007, CompanyName ="Carter-Reynolds", ItemReference = 9160738, ItemName = "Cornflakes"},
                new Item {CompanyPrefix = 428651, CompanyName ="Cole LLC", ItemReference = 7619450, ItemName = "Creme De Cacao Mcguines"},
                new Item {CompanyPrefix = 443750, CompanyName ="Cole, Kemmer and Turner", ItemReference = 5573641, ItemName = "Spring Roll Veg Mini"},
                new Item {CompanyPrefix = 446617, CompanyName ="Koelpin Inc", ItemReference = 9353565, ItemName = "Wine - Sauvignon Blanc Oyster"},
                new Item {CompanyPrefix = 451802, CompanyName ="Koelpin, Kozey and Grimes", ItemReference = 2638491, ItemName = "Fond - Neutral"},
                new Item {CompanyPrefix = 485771, CompanyName ="Morar-Schulist", ItemReference = 5339535, ItemName = "Lamb - Whole Head Off,nz"},
                new Item {CompanyPrefix = 511751, CompanyName ="Spencer, Block and Marks", ItemReference = 6644044, ItemName = "Jam - Blackberry, 20 Ml Jar"},
                new Item {CompanyPrefix = 516232, CompanyName ="Leffler-Torphy", ItemReference = 7222702, ItemName = "Juice - Apple, 341 Ml"},
                new Item {CompanyPrefix = 528209, CompanyName ="Morissette LLC", ItemReference = 7791950, ItemName = "Shallots"},
                new Item {CompanyPrefix = 543540, CompanyName ="Kozey Group", ItemReference = 3141656, ItemName = "Wine - Clavet Saint Emilion"},
                new Item {CompanyPrefix = 563974, CompanyName ="Gusikowski-Leuschke", ItemReference = 4156235, ItemName = "Cranberries - Dry"},
                new Item {CompanyPrefix = 584202, CompanyName ="Bailey LLC", ItemReference = 2876851, ItemName = "Sugar - Brown, Individual"},
                new Item {CompanyPrefix = 585675, CompanyName ="Torphy-Becker", ItemReference = 4259784, ItemName = "Wine - Merlot Vina Carmen"},
                new Item {CompanyPrefix = 587451, CompanyName ="Lindgren, Witting and Wiegand", ItemReference = 1074506, ItemName = "Pork - Loin, Center Cut"},
                new Item {CompanyPrefix = 591271, CompanyName ="Lakin, Prosacco and Terry", ItemReference = 5771945, ItemName = "Chicken Giblets"},
                new Item {CompanyPrefix = 608240, CompanyName ="Von, Gusikowski and Farrell", ItemReference = 2412148, ItemName = "Beef - Top Butt Aaa"},
                new Item {CompanyPrefix = 623828, CompanyName ="Wolf and Sons", ItemReference = 4865650, ItemName = "Food Colouring - Orange"},
                new Item {CompanyPrefix = 655062, CompanyName ="Zboncak Inc", ItemReference = 1232213, ItemName = "Vermouth - White, Cinzano"},
                new Item {CompanyPrefix = 676413, CompanyName ="Hayes-Schumm", ItemReference = 8849362, ItemName = "Triple Sec - Mcguinness"},
                new Item {CompanyPrefix = 678362, CompanyName ="Lynch, Yundt and Howe", ItemReference = 4156060, ItemName = "Plastic Arrow Stir Stick"},
                new Item {CompanyPrefix = 686748, CompanyName ="Steuber-Stracke", ItemReference = 9119606, ItemName = "Cheese - Grie Des Champ"},
                new Item {CompanyPrefix = 719065, CompanyName ="Legros-Cruickshank", ItemReference = 9765179, ItemName = "Salami - Genova"},
                new Item {CompanyPrefix = 745230, CompanyName ="Nitzsche-Gerlach", ItemReference = 6232899, ItemName = "Truffle - Whole Black Peeled"},
                new Item {CompanyPrefix = 750917, CompanyName ="Becker, Schaefer and Greenholt", ItemReference = 7528000, ItemName = "Walkers Special Old Whiskey"},
                new Item {CompanyPrefix = 758601, CompanyName ="Schmeler-Lind", ItemReference = 2337085, ItemName = "Muffin Mix - Corn Harvest"},
                new Item {CompanyPrefix = 791586, CompanyName ="Raynor LLC", ItemReference = 5775051, ItemName = "Gooseberry"},
                new Item {CompanyPrefix = 793681, CompanyName ="Carroll-Hammes", ItemReference = 9774282, ItemName = "Jicama"},
                new Item {CompanyPrefix = 812302, CompanyName ="Spinka, Hauck and Bogan", ItemReference = 5276620, ItemName = "Juice Peach Nectar"},
                new Item {CompanyPrefix = 814875, CompanyName ="Cummerata-Schaden", ItemReference = 5090895, ItemName = "Pork - Tenderloin, Fresh"},
                new Item {CompanyPrefix = 823332, CompanyName ="Durgan, Hahn and Runolfsdottir", ItemReference = 6492584, ItemName = "Carrots - Purple, Organic"},
                new Item {CompanyPrefix = 823413, CompanyName ="Johnson-Donnelly", ItemReference = 4397760, ItemName = "Grouper - Fresh"},
                new Item {CompanyPrefix = 826025, CompanyName ="Little Group", ItemReference = 1130405, ItemName = "Salt - Sea"},
                new Item {CompanyPrefix = 828415, CompanyName ="Weber-Reichel", ItemReference = 5417914, ItemName = "Flower - Leather Leaf Fern"},
                new Item {CompanyPrefix = 870953, CompanyName ="Dach-Herzog", ItemReference = 8728496, ItemName = "Lychee - Canned"},
                new Item {CompanyPrefix = 885734, CompanyName ="Deckow LLC", ItemReference = 8756756, ItemName = "Muffins - Assorted"},
                new Item {CompanyPrefix = 900706, CompanyName ="Weimann-Casper", ItemReference = 8213657, ItemName = "Sea Bass - Whole"},
                new Item {CompanyPrefix = 905710, CompanyName ="Jakubowski-Veum", ItemReference = 9832832, ItemName = "Plate - Foam, Bread And Butter"},
                new Item {CompanyPrefix = 917969, CompanyName ="Aufderhar Group", ItemReference = 3602750, ItemName = "Cheese - Ricotta"},
                new Item {CompanyPrefix = 950316, CompanyName ="Keeling, Nikolaus and Larkin", ItemReference = 2380884, ItemName = "Berry Brulee"},
                new Item {CompanyPrefix = 964495, CompanyName ="Halvorson and Sons", ItemReference = 3508204, ItemName = "Cotton Wet Mop 16 Oz"},
                new Item {CompanyPrefix = 983682, CompanyName ="Dickens and Sons", ItemReference = 4365465, ItemName = "Mousse - Mango"},
                new Item {CompanyPrefix = 997970, CompanyName ="Stark-Ward", ItemReference = 9212388, ItemName = "Pasta - Ravioli"},
                new Item {CompanyPrefix = 1999335, CompanyName ="Gibson-Cormier", ItemReference = 642804, ItemName = "Compound - Raspberry"},
                new Item {CompanyPrefix = 2180435, CompanyName ="Gottlieb, Stroman and Grimes", ItemReference = 909583, ItemName = "Wine - Magnotta - Cab Franc"},
                new Item {CompanyPrefix = 2871566, CompanyName ="Lueilwitz, Schumm and Walsh", ItemReference = 145216, ItemName = "Beef - Bresaola"},
                new Item {CompanyPrefix = 2973701, CompanyName ="Bednar-Mitchell", ItemReference = 682407, ItemName = "Bols Melon Liqueur"},
                new Item {CompanyPrefix = 3209622, CompanyName ="Windler-Stark", ItemReference = 461277, ItemName = "Longos - Greek Salad"},
                new Item {CompanyPrefix = 3319361, CompanyName ="Sanford LLC", ItemReference = 407205, ItemName = "Beans - Kidney, Red Dry"},
                new Item {CompanyPrefix = 3733204, CompanyName ="Orn-Langosh", ItemReference = 647520, ItemName = "Extract - Lemon"},
                new Item {CompanyPrefix = 4499823, CompanyName ="Daugherty, Hettinger and Koelpin", ItemReference = 351572, ItemName = "Smoked Tongue"},
                new Item {CompanyPrefix = 4584903, CompanyName ="Heller, Koepp and Powlowski", ItemReference = 679405, ItemName = "Beer - Camerons Cream Ale"},
                new Item {CompanyPrefix = 4619611, CompanyName ="Rolfson, Collins and Runolfsson", ItemReference = 162323, ItemName = "Contreau"},
                new Item {CompanyPrefix = 4984121, CompanyName ="O'Reilly Inc", ItemReference = 901844, ItemName = "Pork - Back, Long Cut, Boneless"},
                new Item {CompanyPrefix = 7002011, CompanyName ="Orn, Ortiz and Keebler", ItemReference = 482701, ItemName = "Bread - Mini Hamburger Bun"},
                new Item {CompanyPrefix = 7408273, CompanyName ="Stark-McCullough", ItemReference = 664337, ItemName = "Turkey - Whole, Fresh"},
                new Item {CompanyPrefix = 7942595, CompanyName ="Hilpert Group", ItemReference = 565126, ItemName = "Pate - Cognac"},
                new Item {CompanyPrefix = 9488123, CompanyName ="Kunze, Wilkinson and Sawayn", ItemReference = 147805, ItemName = "Bread - Multigrain, Loaf"},
                new Item {CompanyPrefix = 28600054, CompanyName ="Mosciski, Maggio and DuBuque", ItemReference = 41912, ItemName = "Scallops - U - 10"},
                new Item {CompanyPrefix = 33314622, CompanyName ="Weissnat and Sons", ItemReference = 53619, ItemName = "Mustard Prepared"},
                new Item {CompanyPrefix = 39266333, CompanyName ="Mertz, O'Conner and Heaney", ItemReference = 21526, ItemName = "Fruit Mix - Light"},
                new Item {CompanyPrefix = 40777411, CompanyName ="Larson, Reilly and Cruickshank", ItemReference = 36953, ItemName = "Tea - Green"},
                new Item {CompanyPrefix = 51151534, CompanyName ="Schmidt-Quigley", ItemReference = 78331, ItemName = "Apple - Delicious, Red"},
                new Item {CompanyPrefix = 83250532, CompanyName ="Fisher Inc", ItemReference = 52838, ItemName = "Chicken - Whole"},
                new Item {CompanyPrefix = 1210999912, CompanyName ="Heidenreich-Kessler", ItemReference = 123, ItemName = "Ecolab - Hobart Washarm End Cap"},
                new Item {CompanyPrefix = 2777462999, CompanyName ="Gottlieb-Denesik", ItemReference = 401, ItemName = "Bread - Hamburger Buns"},
                new Item {CompanyPrefix = 5023208822, CompanyName ="Smitham, Swaniawski and Upton", ItemReference = 521, ItemName = "Hagen Daza - Dk Choocolate"},
                new Item {CompanyPrefix = 5032891234, CompanyName ="Sawayn-Gibson", ItemReference = 138, ItemName = "Pepper - Red Chili"},
                new Item {CompanyPrefix = 6314853123, CompanyName ="Gleichner, Rodriguez and Wilkinson", ItemReference = 877, ItemName = "Scallops - In Shell"},
                new Item {CompanyPrefix = 8393604321, CompanyName ="Wolf Inc", ItemReference = 179, ItemName = "Veal - Eye Of Round"},
                new Item {CompanyPrefix = 107956107956, CompanyName ="Rodriguez, Beier and Ratke", ItemReference = 2, ItemName = "Salmon - Atlantic, Fresh, Whole"},
                new Item {CompanyPrefix = 317580317580, CompanyName ="Medhurst-Romaguera", ItemReference = 7, ItemName = "Pork - Ground"},
                new Item {CompanyPrefix = 472731472731, CompanyName ="Dicki Group", ItemReference = 2, ItemName = "Soup - Knorr, Chicken Noodle"},
                new Item {CompanyPrefix = 600851600851, CompanyName ="O'Conner-Turner", ItemReference = 2, ItemName = "Wild Boar - Tenderloin"},
                new Item {CompanyPrefix = 764493764493, CompanyName ="Okuneva, Schneider and Collins", ItemReference = 4, ItemName = "Pumpkin"},
                new Item {CompanyPrefix = 770270770270, CompanyName ="Halvorson, Schinner and Smitham", ItemReference = 9, ItemName = "Pepper Squash"}
            };
        }

        public List<Item> GetAllItems()
        {
            return null;
        }
    }
}