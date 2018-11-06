using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.Models;

namespace Prototype.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 1", Description="Trin 1: Sid i en komfortabel position. Fokuser på et punkt i øjenhøjde med hovedet let foroverbøjet (ca. 20-30 grader). \n\nTrin 2: Fortsæt med at fokusere på punktet, mens du bevæger hovedet fra side til side. Husk at fokusere på punktet med øjnene, mens du bevæger hovedet!"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 2", Description="Trin 1: Sid i en komfortabel position. Fokuser på et punkt i øjenhøjde med hovedet let foroverbøjet (ca. 20-30 grader). \n\nTrin 2: Hovedet skal bevæges til højre og venstre side, men i tilfældig rækkefølge. Bevæg hovedet til hver side ca. 10-20 gange. Bevægelserne skal være med forskellig hastighed. \n\nHold hovedet i yderpositionen i et par sekunder, før du vender tilbage til startpositionen. \n\nHusk at fokusere på punktet med øjnene, mens du bevæger hovedet!" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 3", Description="Trin 1: Sid eller stå behageligt. \n\nTrin 2: Find 5 punkter (genstande) i rummet, en i midten, til højre, til venstre, i loftet og i gulvet. \n\nTrin 3: Bevæg hovedet for at se på de forskellige genstande du har udvalgt. Først i ordnet rækkefølge, derefter i vilkårlig rækkefølge. \n\nTrin 3: Gentag trin 1-2, hvor du får en hjælper til at sige, hvilken genstand du skal se på. \n\nTrin 4: Gentag Trin 2 og 3 gentagne gange (ca. 20 gange) 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 4", Description="Trin 1: Sid eller stå behageligt. Trin 2: Hold kroppen stille. Fokuser på et punkt, ca. en meter foran dig. Drej hovedet hurtigt (max 45 gr.) mod højre og hold hele tiden fokus mod punktet foran dig - Vent i 3 sek.. Drej hovedet tilbage til udgangsposition. Vent i 3 sek. Drej hovedet hurtigt (max 45 gr.) mod venstre og hold hele tiden fokus mod punktet foran dig - Vent i 3 sekunder. Drej hovedet tilbage til udgangsposition. \n\nTrin 3: Gentag trin 1-2, men denne gang med hovedet drejet 45 gr. mod højre. Fokuser på punktet foran dig. Prøv herefter at bevæge hovedet op og ned. \n\nTrin 4: Gentag Trin 2 og 3 gentagne gange (ca. 20 gange) 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 5", Description="Trin 1: Start med at gå ved siden af en væg. Drej hovedet forsigtigt fra side til side, mens du fortsætter med at gå lige ud. \n\nTrin 2: Øg gradvist hastigheden hvormed du bevæger hovedet. \n\nTrin 3: Gentag trin 1 og 2 gentagne gange (ca. 20 gange), 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Genopret 6", Description="Trin 1: Stå med benene let spredte (ca. en håndsbredde fra hinanden). Fordel vægten ligeligt på hvert enkelt ben. Lad armene hænge løst ned langs siden. Se lige ud. Bevæg langsomt kroppen fremad-bagud, samt til højre og venstre side. Kør i cirkel. Al bevægelse skal foregå i anklerne – hofterne må ikke bøjes. \n\nTrin 2: Når du er komfortabel med denne øvelse, kan du udføre øvelsen med lukkede øjne. \n\nTrin 3: Gentag trin 2 og 3 gentagne gange (ca. 20 gange), 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 1", Description="Trin 1: Start med at stå med ryggen tæt på en væg med benene let spredte. \n\nTrin 2: Kryds det højre ben ind foran det venstre. Hold benet krydset i luften i 5 sekunder og før det tilbage til udgangspositionen. \n\nTrin 3: Gentag denne bevægelse med det venstre ben. \n\nTrin 4: Gentag Trin 1-3 ca. 20 gange, 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 2", Description="Trin 1: Start med at stå foran en væg med fødderne pegende fremad mod væggen. \n\nTrin 2: Bevæg dig langs væggen med sideskridt mod den ene ende og herefter den anden. \n\nTrin 3: Gentag øvelsen med lukkede øjne. \n\nTrin 4: Gentag trin 2 og 3 ca. 20 gange, 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 3", Description="Trin 1: Start med at stå foran en væg med fødderne pegende fremad mod væggen. \n\nTrin 2: Begynd at bevæge dig langs væggen ved at dreje dig 360 grader rundt igen og igen til du når den ene ende af væggen. Herefter ”ruller” du den anden vej, til du når den modsatte ende af væggen. \n\nTrin 3: Gentag øvelsen med lukkede øjne \n\nTrin 4: Gentag trin 2 og 3 ca. 20 gange." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 4", Description="Trin 1: Start med at stå med siden til, tæt på en væg med benene let spredte. \n\nTrin 2: Gå tå-gang ligeud (a), diagonalt (b) og i en bue (c) mod den anden ende af væggen. \n\nTrin 3: Gå hæl-gang ligeud, diagonalt og i en bue mod den anden ende af væggen. \n\nTrin 4: Gentag trin 2 og 3 ca. 20 gange." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 5", Description="Trin 1: Stå med benene let spredte. Fordel vægten ligeligt på hvert enkelt ben. Lad armene hænge løst ned langs siden og se lige ud. Bevæg langsomt kroppen: Fremad-bagud - til højre og venstre side - i cirkel. Al bevægelse skal foregå i anklerne – hofterne må ikke bøjes. \n\nTrin 2: Når du har gjort dette ca 10 gange og er komfortabel med denne øvelse, kan du udføre samme bevægelser med lukkede øjne. \n\nTrin 3: Gentag trin 2 og 3 ca. 20 gange, 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Erstat 6", Description="Trin 1: Start med at stå med siden til, tæt på en væg med benene let spredte. Trin 2: Gå på tæerne mod den anden ende af væggen. \n\nTrin 3: Gå på hælene mod den anden ende af væggen. \n\nTrin 4: Gentag trin 2 og 3 ca. 20 gange, 3 gange dagligt." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Løse Øresten: Bagerste Buegang", Description="Epleys manøvre til at fjerne løse øresten fra bagerste buegang. \n\nTrin 1: Patienten sidder oprejst på briksen og kigger lige frem. Tag fat om patientens hoved. Patientens hoved drejes 45 grader ud mod det den berørte side. \n\nTrin 2: Med hovedet fortsat drejet, 45 grader, lægges patienten på ryggen. Få patienten hurtigt ned i liggende stilling med hovedet let bagoverbøjet (ekstenderet). Patienten skal forblive i denne stilling i ca. 30 sekunder eller til nystagmus og de subjektive symptomer er forsvundet. \n\nTrin 3: Fra positionen i liggende stilling, drejes hovedet 90 grader mod venstre. Stillingen holdes i ca. 30 sekunder. \n\nTrin 4: Patienten rulles om på venstre side, så patienten kommer til at ligge på venstre skulder med næsen pegende ned mod gulvet. Hold denne position i 30 sekunder. \n\nTrin 5: Patienten sættes i oprejst position, men skal stadig kigge over venstre skulder i ca. 30 sekunder. \n\nTrin 6: Patienten drejer hovedet mod midten, så han eller hun kigger ligefrem i ca. 30 sekunder." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Løse Øresten: Horisontale Buegang", Description="Lempert roll manøvre til at fjerne løse øresten fra horisontale buegang. \n\nTrin 1: Start i liggende position. \n\nTrin 2: Patienten drejer hovedet mod det raske øre (væk fra den side som giver nystagmus og svimmelhed), mens patienten fortsat ligger fladt på ryggen. \n\nTrin 3: Drej patienten 90 grader om på siden med det raske øre ned mod briksen. \n\nTrin 4: Drej patienten yderligere 90 grader, så patienten kommer til at ligge på maven med næsen pegende ned mod briksen. \n\nTrin 5: Patienten drejes yderligere 90 grader i samme retning, så patienten kommer til at ligge på den side, hvor der primært blev fundet tegn til løse øresten. \n\nTrin 6: Til sidst rejses patienten op til siddende position." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Løse Øresten: Forreste Buegang", Description="Yacovino manøvre til at fjerne løse øresten fra forreste buegang. \n\nTrin 1: Patienten sidder oprejst på briksen og kigger lige frem. \n\nTrin 2: Patienten lægges på ryggen og lader hovedet hænge ud over kanten på briksen, minimum 30 grader (dette kan udløse nystagmus). Patienten skal forblive i denne stilling i ca. 30 sekunder eller til nystagmus og de subjektive symptomer er forsvundet. \n\nTrin 3: Fra positionen i liggende stilling, bøjes hovedet fremover, så hagen møder brystet. Stillingen holdes i ca. 30 sekunder eller til nystagmus og de subjektive symptomer er forsvundet. \n\nTrin 4: Patienten sættes i oprejst position og blive i denne i yderligere 30 sekunder. Såfremtpatienten stadig er svimmel, kan proceduren gentages." }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}