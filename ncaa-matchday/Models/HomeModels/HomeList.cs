namespace ncaa_matchday.Models.HomeModels
{
    public class HomeList
    {
        public class League
        {
            public required string Sport { get; set; }
            public required string Division { get; set; }
            public required string Link { get; set; }
            public string? Sex { get; set; }
        }

        public List<League> Leagues
        {
            get { return leagues; }
            set { leagues = value; }
        }

        public List<League> leagues =
        [
            new League{
                Sport = "Football",
                Division = "Division I-A Football Bowl Subdivision",
                Link = "football/fbs"
            },
            new League{
                Sport = "Football",
                Division = "Division I-B Football Championship Subdivision",
                Link = "football/fcs"
            },
            new League{
                Sport = "Football",
                Division = "Division II",
                Link = "football/d2"
            },
            new League{
                Sport = "Football",
                Division = "Division III",
                Link = "football/d3"
            },
            new League{
                Sport = "Basketball",
                Division = "Division I",
                Sex = "Men",
                Link = "basketball-men/d1"
            },
            new League{
                Sport = "Basketball",
                Division = "Division II",
                Sex = "Men",
                Link = "basketball-men/d2"
            },
            new League{
                Sport = "Basketball",
                Division = "Division III",
                Sex = "Men",
                Link = "basketball-men/d3"
            },
            new League{
                Sport = "Basketball",
                Division = "Division I",
                Sex = "Women",
                Link = "basketball-women/d1"
            },
            new League{
                Sport = "Basketball",
                Division = "Division II",
                Sex = "Women",
                Link = "basketball-women/d2"
            },  
            new League{
                Sport = "Basketball",
                Division = "Division III",
                Sex = "Women",
                Link = "basketball-women/d3"
            },
            new League{
                Sport = "Ice Hockey",
                Division = "Division I",
                Sex = "Men",
                Link = "icehockey-men/d1"
            },
            new League{
                Sport = "Ice Hockey",
                Division = "Division II",
                Sex = "Men",
                Link = "icehockey-men/d2"
            },   
            new League{
                Sport = "Ice Hockey",
                Division = "Division III",
                Sex = "Men",
                Link = "icehockey-men/d3"
            },            
            new League{
                Sport = "Ice Hockey",
                Division = "Division I",
                Sex = "Women",
                Link = "icehockey-women/d1"
            },            
            new League{
                Sport = "Ice Hockey",
                Division = "Division II",
                Sex = "Women",
                Link = "icehockey-women/d2"
            },            
            new League{
                Sport = "Ice Hockey",
                Division = "Division III",
                Sex = "Women",
                Link = "icehockey-women/d3"
            },
            new League{
                Sport = "Soccer",
                Division = "Division I",
                Sex = "Men",
                Link = "soccer-men/d1"
            },
            new League{
                Sport = "Soccer",
                Division = "Division II",
                Sex = "Men",
                Link = "soccer-men/d2"
            },
            new League{
                Sport = "Soccer",
                Division = "Division III",
                Sex = "Men",
                Link = "soccer-men/d3"
            },
            new League{
                Sport = "Soccer",
                Division = "Division I",
                Sex = "Women",
                Link = "soccer-women/d1"
            },
            new League{
                Sport = "Soccer",
                Division = "Division II",
                Sex = "Women",
                Link = "soccer-women/d2"
            },
            new League{
                Sport = "Soccer",
                Division = "Division III",
                Sex = "Women",
                Link = "soccer-women/d3"
            }
        ];
    }
}
