using System;
using SustainableSeasTrust.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SustainableSeasTrust.Controllers
{
    public class HomeController : Controller
    {

        public static List<HopeSpot> hopespots = new List<HopeSpot>();
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult HopeSpots()
        {
            hopespots.Clear();
            HopeSpot HS1 = new HopeSpot(
                "Algoa Bay",
                "Algoa Bay is one of the South Africa’s largest bays, and richest thanks to the fact that it’s at the conjuncture of two oceanic systems, the Cape Agulhas and the upwelling current of the Benguela: two systems means two different ecosystems.",
                "The St Croix Islands are located within the bay and are home to a great number of bird species; Algoa Bay was declared an Important Bird and Biodiversity Area by Birdlife International in 2001. The bay is also home to the largest breeding colony of African penguins in the world, and has migratory humpback and Southern right whales visiting in the winter months. Another species you’ll definitely see there is dolphins, both bottlenose and common. Usually orcas also visit once a year.",
                "https://web.facebook.com/algoabayhopespot/?_rdc=1&_rdr",
                "penguin.jpg"
                );
            HS1.addSpecies("African penguin", "This adorable creature makes a not-so-adorable donkey-like bray, which is why it’s also known as the jackass penguin. It’s endangered and is found in only a few areas along South Africa’s coast: Betty’s Bay (part of the Cape Whale Hope Spot), Simon’s Town (part of the False Bay Hope Spot), Algoa Bay (part of the Algoa Bay Hope Spot).", "Spheniscus", "demersus");
            HS1.addActivity("Get educated lectures", "Every month, the Algoa Bay Hope Spot organises a series of talks called Know your Bay.", "https://www.facebook.com/algoabayhopespot/");
            HS1.addActivity("Join a beach cleanup", "The Hope Spot organises a monthly clean-up. Or organise your own event and never look at an earbud in the same way again…", "https://www.facebook.com/algoabayhopespot/");
            HS1.addActivity("Get the kids water smart", "The NSRI, SANCCOB and others make presentations to children from dozens of schools, who learn about the wonders and dangers of the sea, at various times during the year.", "https://www.nmbt.co.za/");
            HS1.addActivity("Swim at the blue flag beaches", "Humewood Beach, one of the first beaches in South Africa to be granted Blue Flag status in 2000, has rock pools and safe swimming (there’s a lifeguard). PS: Also flying the Blue Flag are Hobie Beach (with Shark Rock Pier) and Kings Beach (with kids activities like paddling pools, mini-golf and a go-kart track). Pollock Beach has a natural tidal pool.", "https://www.nmbt.co.za/");
            HS1.addActivity("Dive Deeper", "The silent blue world of the bay contains amazing soft corals and exceptional marine diversity. Evania Snyman of Elite Scuba PE, for one, has found over 50 species of nudibranch in her years of diving. Commercial reef and wreck tours are offered by a variety of operators; visibility is generally better in winter. But even beginners can go looking for toothy ‘raggie’ sharks in alleys just five minutes off Hobie beach from November to May.", "https://www.elitescuba.co.za/");
            HS1.addActivity("Canter on an empty beach", "Heavenly Stables offers 2.5 to three-hour rides through the Sardina Nature Reserve; a section of the route unfurls on the wide beach, part of a Marine Protected Area. Besides playing centaur, one may see antelope in the reserve and whales or dolphins in the water.", "https://heavenlystables.co.za/");
            HS1.addActivity("Dip into the past", "Bayworld’s museums and oceanarium, where in the marine hall, some early models of fish were carved from wood and then painted, unlike today’s fibreglass casts.  Bayworld cares for the largest marine mammal collection in the southern hemisphere and 20,300 ear-bones from marine bony fishes… Contact them for any strandings.", "https://www.bayworld.co.za/");
            HS1.iconurl = "AlgoaBay.jpg";
            hopespots.Add(HS1);

            HopeSpot HS2 = new HopeSpot(
                "Plettenburg Bay",
                "Plettenberg Bay is one of South Africa’s richest areas in terms of biodiversity. The Hope Spot incorporates Robberg Island, which is home to over 7 000 Cape cormorants, the largest kelp gull breeding colony in the country, and an incredible richness of other birdlife.", 
                "The St Croix Islands are located within the bay and are home to a great number of bird species; Algoa Bay was declared an Important Bird and Biodiversity Area by Birdlife International in 2001. The bay is also home to the largest breeding colony of African penguins in the world, and has migratory humpback and Southern right whales visiting in the winter months. Another species you’ll definitely see there is dolphins, both bottlenose and common. Usually orcas also visit once a year.",
                "https://web.facebook.com/Plett-Hope-Spot-1421945568057790/?_rdc=1&_rdr",
                "dolphin.jpg"
                );
            HS2.addSpecies("Indo-Pacific Humpback dolphin", "his near-threatened dolphin has a distinctive fatty hump on its back, and prefers shallower water. It’s a medium-sized dolphin (about 2 – 2.8 metres in length), and is usually a darker grey.", "Sousa", "plumbea");
            HS2.addSpecies("The Pansy shell", "Plettenberg Bay is one of the few places where you can find the beautiful pansy shell on the beaches. It is, in fact, the skeleton of a sea urchin, which belongs to a group of burrowing urchins that live in sheltered bays and estuaries. Keurbooms and Robberg beaches (near the Peninsula) are the best places to find them at low tide.", "Echinodiscus", "bisperforatus");
            HS2.addActivity("Visit Robberg Nature Reserve", "There are a number of hikes you can do here. One takes you past a seal colony and another of Cape cormorants. It’s a gorgeous reserve, wonderful for bird and whale and dolphin watching in season. ", "https://www.capenature.co.za/");
            HS2.addActivity("Swim with seals and pelagic sharks", "Offshore Adventures is a recommended operation for snorkelling with these playful creatures – suitable for kids – and adults can also brave the sardine migration or swim with sharks.", "https://www.offshoreadventures.co.za/");
            HS2.addActivity("Go whale watching", "Ocean Blue Adventures is one of two operations permitted to do the above in the bay.From oceanadventures.co.za Ocean Safaris is another option for marine tours. From 12 and under.", "https://oceansafaris.co.za/");
            HS2.addActivity("Do an eco-tour by kayak", "Dolphin Adventures explores sea life along the coastline from their stable sea-level craft.", "https://dolphinadventures.co.za/");
            HS2.addActivity("Do the Salt River Hiking Trail", "Park at Natures Valley Trading Store (check). Trail maps are available at the shop or the Nature’s Valley Trust office. This hike is in the SANParks Garden Route National Park and is regarded as one of the most spectacular walks in the region. It’s a 15 km hike, and please note that the trail is not passable during high tide. ", "https://www.sanparks.org/");
            HS2.addBeach("Arch Rock", "A ‘path less travelled’ and there are beautiful rock pools and caves to explore.Park at Enrico Ristorante in Keurbooms village and walk east.", "https://goo.gl/maps/tmqU5qc8nVPt8wbe6");
            HS2.addBeach("Lookout Beach", "A walk from the car park at Lemongrass restaurant to the Keurbooms River mouth and around the edge of the lagoon. Breeding seabirds nest here. Please note: no dogs are allowed on this beach.", "https://goo.gl/maps/9ujHG4pa2RaBirRn6");
            HS2.addBeach("Poortjies Beach", "On the edges of the Keurbooms estuary. The area offers several dog-friendly beaches, the favourite being at the end of Robberg Beach, from Sanctuary Beach to Wreck Beach. New regulations have been put in place to protect breeding seabirds and a dogs-on-leashes rule is being enforced. Look out for the signs telling you which beaches are dog friendly, either on or off the leash. Watch hermit crabs scuttle away from you, or hire a SUP board and explore further.", "https://goo.gl/maps/Dq6f7c2o412qkp327");
            HS2.iconurl = "PlettenbergBay.jpeg";
            hopespots.Add(HS2);

            HopeSpot HS3 = new HopeSpot(
                "Cape Whale Coast",
                "The Cape Whale Coast Hope Spot stretches 200kms from Rooi Els to Quoin Point and is recognized for its incredibly vibrant and visible whale visits.",
                "It’s unique in its combination of rich and abundant biodiversity, spectacular scenery and cultural heritage. Much of the area is already protected: Kogelberg Biosphere Reserve (the heart of the Cape Floristic Kingdom), the Stony Point Penguin Colony at Betty’s Bay (one of only two mainland penguin colonies in South Africa), the Betty’s Bay Marine Protected Area, the Bot/Kleinmond and Klein river estuaries, the Walker Bay Whale Sanctuary Marine Protected Area, the Dyer Island Nature Reserve complex, as well as a network of conservation stewardship sites. It’s home to the marine Big 5: whales, dolphins, sharks, seals and African penguins.",
                "https://web.facebook.com/capewhalecoasthopespot/?_rdc=1&_rdr",
                "humpback.jpg"
                );
            HS3.addSpecies("African penguin", "This adorable creature makes a not-so-adorable donkey-like bray, which is why it’s also known as the jackass penguin. It’s endangered and is found in only a few areas along South Africa’s coast: Betty’s Bay (part of the Cape Whale Hope Spot), Simon’s Town (part of the False Bay Hope Spot), Algoa Bay (part of the Algoa Bay Hope Spot).", "Spheniscus", "demersus");
            HS3.addSpecies("Southern right whales", " is a baleen whale and it’s massive – it can weigh up to 80 tonnes and is distinguishable by many things: a massive head that is almost a third of its body, a long mouth that begins above the eye, many callosities on its head, no dorsal fin, a broad almost triangular tail. Did you know they’re susceptible to sunburn? For this reason, they shy away from exposure on bright, sunny days.", "Eubalaena", "australis");
            HS3.addSpecies("Great white shark", "can reach up to six metres – the female is bigger than the male. Although many studies are ongoing, there is still some mystery surrounding facts about this impressive creature – it’s thought they grow as old as 70 years, that the males take over 20 years to reach sexual maturity, while the females take over 30. This low reproduction rate is what makes them more rare. They are listed as vulnerable.", "Carcharodon", "carcharias");
            HS3.addActivity("Dive with sharks", "Shark-cage diving is a huge attraction in the area, and there are seven operators in the area.", "https://www.sharkwatchsa.com/en/home/");
            HS3.addActivity("Visit the African penguin & seabird sanctuary", "This is based in Gaansbaai and visiting hours are from 9am-4pm every day, but the best time to go is feeding time at 3pm.", "https://dict.org.za/");
            HS3.addActivity("Kayak with whales and into the bay", "It’s a remarkable experience being on the water in the presence of a whale, because you’re at the same level and hear only the sounds of the sea and its life. Walker Bay Adventures do regular trips (it’s weather dependent).", "https://www.walkerbayadventures.co.za/");
            HS3.addActivity("Watch whales from a boat", "In Hermanus, there are three certified operators. Areas of operation have been carefully chosen so as not to interfere with the natural habitat and behaviours of the whales. ", "https://www.southernrightcharters.co.za/");
            HS3.addActivity("Watch whales from the air", "Seeing whales from a bird’s eye view allows you to get a sense of their full environmental context and is a remarkable experience. There are two operators in the area. African Wins departs from Stanford airstrip and takes one to three people.", "https://www.africanwings.co.za/");
            HS3.addBeach("Walker bay", "Part of a nature reserve and stretches kilometres, from Klein River to Gansbaai. It’s a blue flag beach and the sea is wonderfully clear, and in season there are lifeguards (and a bar). There are also sheltered nooks in which you can snorkel, and coastal caves to explore. Plus there’s plenty of birdlife.", "https://goo.gl/maps/gp61H3X5G9G3iVaMA");
            HS3.addBeach("The old harbour", "Beach in the centre of Hermanus has a small sandy patch that goes down to a stunning snorkeling area that is very biodiverse.", "https://goo.gl/maps/w4fKaYEn6u7eJFvp8");
            HS3.iconurl = "CapeWhaleCoast.jpg";
            hopespots.Add(HS3);

            HopeSpot HS4 = new HopeSpot(
               "Aliwal Shoal",
               "Aliwal Shoal is set close to Umkomaas on the South Coast, and is rated as one of the top 10 dive sites in the world because it’s so rich in life, plus the water is warm and visibility is usually very good.", 
               "The shoal is a rocky reef about five kilometres off the KwaZulu-Natal’s coast; it’s about three kilometres long and a kilometer wide; it’s part of one of South Africa’s 24 marine protected areas.",
               "https://www.facebook.com/aliwalshoalhopespot/",
               "shark.jpg"
               );
            HS4.addSpecies("Ragged-tooth shark", "This fierce-looking creature can grow to about 3,2 metres, and live up to 40 years. Their teeth grow in rows and forwards, so they’re assured of constant, sharp new tools and can lose and replace thousands in their lifetime. They gather around KZN’s southern waters and in the northern Eastern Cape to mate in November and December, then head north to Mozambique to gestate. They come back to waters around the Kei River to give birth.", "Carcharias", "taurus");
            HS4.iconurl = "AliwalShoal.jpg";
            hopespots.Add(HS4);

            HopeSpot HS5 = new HopeSpot(
               "Knysna",
               "Knysna is notable because it’s the world’s first estuarine Hope Spot. It’s located within the Garden Route National Park, surrounded by incredible coastal shrub, with over 6000 species from the Cape Floral Kingdom.",
               "The estuary is South Africa’s most significant thanks to its remarkable biodiversity. Due to the coexistence of both marine and endemic estuarine forms, a myriad species occur here, including the Knysna Seahorse and the Knysna goby, two rare fish species that occur in this 1 800 hectare expansive estuary.",
               "https://www.facebook.com/knysnahopespot",
               "seahorse.jpg"
               );
            HS5.addSpecies("Knysna seahorse", "These amazing, fantastical creatures are tiny; they only grow to about 12 centimetres in length. There are over 30 kinds of seahorses, but only five are evident around southern African shores, of which this is one. The Knysna seahorse, which ranges in colour from green to brown, is only found in the Knysna, Keurbooms and Swartvlei estuaries and is endangered.", "Hippocampus", "capensis");
            HS5.iconurl = "Knysna.jpg";
            hopespots.Add(HS5);

            HopeSpot HS6 = new HopeSpot(
              "False Bay",
              "False Bay lies underneath the Table Mountain National Park, which is a World Heritage Site. The bay is rich in marine life.",
              "One can see whales, particularly from June to October, as well as dolphins and even orcas have been spotted here. It has rich kelp forests, which are wonderful to explore, hiding pyjama and shy sharks, nudibranchs, anemones and other exquisitely colourful creatures. It is also home to the African penguin, seals, octopus and great white shark.",
              "http://capetownattractions.com/cape-town-guide/false-bay-beaches",
              "orca.jpg"
              );
            HS6.addSpecies("Great white shark", "can reach up to six metres – the female is bigger than the male. Although many studies are ongoing, there is still some mystery surrounding facts about this impressive creature – it’s thought they grow as old as 70 years, that the males take over 20 years to reach sexual maturity, while the females take over 30. This low reproduction rate is what makes them more rare. They are listed as vulnerable.", "Carcharodon", "carcharias");
            HS6.addBeach("Gordon's Bay", "Gordon's Bay is a small picturesque seaside townon the eastern side of False Bay. Framed with the exquisite views of the slopes of Hottentots Hollandin the background, it enjoys the warm Mediterranean climate.", "https://goo.gl/maps/Qb3mNC2p2fcTjxQr9");
            HS6.addBeach("Boulder's Beach", "Boulders beach is found in Simon's Town and is one of the most beautiful beaches in Cape Town.It is a cove of fine sand and big granite boulders. The big round granite boulders are estimated to date back to 540 million yearsand protect the beach from currents, gusts of winds and large waves.Boulders beach is part of the Table Mountain National Park Marine Protected Areaand an access fee is required to go to the beach. Strict control to the beach makes it that the beach is always clean and tidy.Other amenities include toilets and outdoor beach showers. Park rangers keep patrolling the beach to ensure the safety of visitors as well as the African Penguins.", "https://goo.gl/maps/AiKkCmpnsyQdzwqq5");
            HS6.iconurl = "FalseBay.jpg";
            hopespots.Add(HS6);


            ViewBag.Message = "HopeSpots - South Africa";
            
            return View(hopespots);
        }

        public ActionResult TakeAction()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}