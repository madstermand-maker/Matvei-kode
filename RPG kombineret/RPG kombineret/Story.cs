using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_kombineret
{
    internal class Story
    {
        public void gamestory()
        {
            Gamecode gamecode = new Gamecode();
            Items WaterBottle = new Items("Water bottle", ConsoleColor.Blue, 10);
            gamecode.inventory.Add(WaterBottle);

            Console.WriteLine("Du står foran et lig som har en taske");
            Items apple = new Items("Apple", ConsoleColor.Green, 20);
            gamecode.LootItem = apple;
            Items Pizza = new Items("Pizza", ConsoleColor.Yellow, 20);
            gamecode.LootItem2 = Pizza;
            gamecode.Muligheder();
            Console.WriteLine("Så går vi videre");

                //Victor: Her printes en tekst direkte til konsollen til brugeren - følgende linjer, gentages gennem hele programmet og betyder det samme
                Console.WriteLine("Du er taget på rejse til det smukke egypten");
                //Victor: Her bruges thread.sleep som får programmet til at "sove" i 3000 millisekunder (3 sekunder) så brugeren har tid til at læse hvert besked.
                Thread.Sleep(3000);
                Console.WriteLine("Der er rigtigt varmt og du står i et meget svært dillema.");
                Thread.Sleep(3000);
                Console.WriteLine("Vil du gå til poolen, eller ");
                Thread.Sleep(3000);
                Console.WriteLine("lavet noget pratisk og besøge det omtalte verdenskendte marked:");
                Console.WriteLine("Skriv om du vil i pool eller på marked:");
                //User idiot:
                //Victor: Her bruger jeg User idiot for at vi kun får det input som vi skal bruge. I følgende tilfælde acceptere vi kun inputtet pool eller marked
                //Victor: Så jeg laver et loop og så længe at det er true, så kører loopet.
                while (true)
                {
                    //Victor: Her gøres det muligt for brugeren at skrive et input som gemmes i en stringen fritid eftersom det er en tekst.
                    string fritid = Console.ReadLine();
                    //Victor: Her findes en if-sætning. Her bruges ToLower til at gøre alt småt som brugeren har skrevet således det er ligegyldigt om brugeren skriver med stort eller småt begyndelses bogstav.
                    //Victor: Hvis variablen fritid = pool altså hvis inputtet fra brugeren er pool så går vi ind i if-sætningen
                    if (fritid.ToLower() == "pool")
                    {
                        //Victor: Her kaldes en ny metode kaldet ValgmulighedPool
                        ValgmulighedPool();
                        //Victor: Her går vi ud af loopet. Sådan at historien kan fortsætte
                        break;
                    }
                    //Victor: Hvis inputtet fra brugeren derimod er marked så det noget nyt der skal ske. Samme gør sig gældende med ToLower som før.
                    else if (fritid.ToLower() == "marked")
                    {
                        //Victor: Her kaldes en ny metode igen så vi kan fortsætte historien
                        ValgmulighedMarked();
                        //Victor: Her forlades loopet igen.
                        break;
                    }
                    //Victor: Hvis der derimod ikke er blevet skrevet enten pool eller marked som ikke er det vi skal bruge i dette tilfælde. Så skal der ske noget nyt.
                    else
                    {
                        //Victor: Her gøres farve på teksten i konsollen til rød
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Victor: Her skrives en "fejl tekst" som informere brugeren om at der ikke er det rigtig input.
                        Console.WriteLine("Du vil altså kun i poolen eller på markedet.");
                        //Victor: Her gøres farven tilbage til hvid
                        Console.ForegroundColor = ConsoleColor.White;
                        //Victor: Da inputtet fra brugeren ikke er det godkendte så fortsætter loopet ved brug af continue.
                        continue;
                    }

                }

            void ValgmulighedPool()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Du valgte at gå i poolen.");
                Thread.Sleep(3000);
                Console.WriteLine("På vejen hen til poolen hører du nogle snakke om et mystisk og hemmeligt kammer.");
                Thread.Sleep(3000);
                Console.WriteLine("Du synes det lyder mega spændende men meget uhyggeligt.");
                Thread.Sleep(3000);
                Console.WriteLine("Da du kommer op til poolen ser du et stort skilt hvor der står....");
                Thread.Sleep(3000);
                Console.WriteLine("Poolen holder lukket i dag.");
                Thread.Sleep(3000);
                Console.WriteLine("Det ærger dig meget, men du beslutter at tage på marked i stedet.");
                ValgmulighedMarked();
            }

            void ValgmulighedMarked()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Du valgte at tage på markedet og undersøger hvordan man nemmest kommer afsted");
                Thread.Sleep(3000);
                Console.WriteLine("Du finder frem til at bussen er den hurtigste måde.");
                Thread.Sleep(3000);
                Console.WriteLine("Mens du venter på bussen læser du om den egyptiske hemmelighed...");
                Thread.Sleep(3000);
                Console.WriteLine("Og hvilke hemmeligheder der gemmer sig. Du synes det mega spændende.");
                Thread.Sleep(3000);
                Console.WriteLine("Efter en lang og meget varm tur er du nu ankommet til det velkendte marked.");
                ForbryderMarked();
            }

            void ForbryderMarked()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Du har nu gået rundt i lidt tid,");
                Thread.Sleep(2000);
                Console.WriteLine("og du beslutter dig for at købe en vand og en ny sej hat for at klare varmen");
                Thread.Sleep(3000);
                Console.WriteLine("Du finder en butik der sælger billig vand i baggrunden kan du hører nogle der skændes");
                Thread.Sleep(3000);
                Console.WriteLine("Du kigger rundt for at se, hvad der sker, men du ser intet");
                Thread.Sleep(3000);
                Console.WriteLine("Lige pludselig kommer en mand løbende med hans ansigt forklædt i klæder");
                Thread.Sleep(3000);
                Console.WriteLine("En gammel mand råber noget du ikke forstår men overvejer:");
                Thread.Sleep(3000);
                Console.WriteLine("Skal jeg løbe efter manden og hjælpe den gamle mand?");
                Thread.Sleep(3000);
                Console.WriteLine("Skriv om du vil jagte manden eller ignorere det.");
                //Victor: Samme user idiot gør sig gældende ligesom tidligere i programmet.
                while (true)
                {
                    string jagt = Console.ReadLine();
                    //Victor: Her ser vi tilgengæld en forskel fra tidligere. Da der kan være forskellige opfattelser af hvordan man vil skrive jage, gøres flere forskellige mulige her. || disse to streger betyder eller. hvis det ikke er jagt så kan det være jage osv.
                    if ((jagt.ToLower() == "jagt") || (jagt.ToLower() == "jagte") || (jagt.ToLower() == "jage"))
                    {
                        ValgmulighedJagt();
                        break;
                    }
                    //Victor: Ligesom tidligere beskrives bruges der disse her || som betyder eller.
                    else if ((jagt.ToLower() == "ignorer") || (jagt.ToLower() == "ignorere"))
                    {
                        ValgmulighedIgnorer();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du vil enten på jagt eller ignorere ham.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }

            void ValgmulighedJagt()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Du beslutter dig for at løbe efter manden");
                Thread.Sleep(3000);
                Console.WriteLine("Han løber rigtigt stærkt og det meget varmt, og er ikke vant til varmen");
                Thread.Sleep(3000);
                Console.WriteLine("Du kæmper igennem men du sakker bagud.");
                Thread.Sleep(3000);
                Console.WriteLine("Du følger efter ham rundt om et hjørne men da du kommer frem er han væk.");
                Thread.Sleep(3000);
                Console.WriteLine("Men du kan se der ligger noget og glimter i jorden.");
                Thread.Sleep(3000);
                Console.WriteLine("Han har tabt noget. Du samler det op og ser...");
                Thread.Sleep(3000);
                Console.WriteLine("Det en gammel nøgle hvor der står noget på egyptisk.");
                Thread.Sleep(3000);
                Console.WriteLine("Den ligner den nøgle som du læste om og beslutter du vil finde...");
                Thread.Sleep(3000);
                Console.WriteLine("Det hemmelige og uopdaget egyptiske kammer.");
                IndgangTilKammer();
            }
            void ValgmulighedIgnorer()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Du gider ikke besværet med at jagte en kriminel.");
                Thread.Sleep(2000);
                Console.WriteLine("Desuden ser du at politet er på vej.");
                Thread.Sleep(3000);
                Console.WriteLine("Der går ikke længe så har politet fanget den kriminelle.");
                Thread.Sleep(3000);
                Console.WriteLine("Det en meget voldsom anholdelse.");
                Thread.Sleep(1000);
                Console.WriteLine("Da politet forlader scenen ser du noget...");
                Thread.Sleep(3000);
                Console.WriteLine("Du går derover og samler det op.");
                Thread.Sleep(3000);
                Console.WriteLine("Det en gammel nøgle hvor der står noget på egyptisk.");
                Thread.Sleep(3000);
                Console.WriteLine("Den ligner den nøgle som du læste om og beslutter du vil finde...");
                Thread.Sleep(3000);
                Console.WriteLine("Det hemmelige og uopdaget egyptiske kammer.");
                IndgangTilKammer();
            }

            void IndgangTilKammer()
            {
                Thread.Sleep(1000);
                Console.WriteLine("Efter rigtig langtids søgende ude i ørknen finder du endelig");
                Thread.Sleep(2000);
                Console.WriteLine("Porten til det egyptiske kammer.");
                Thread.Sleep(2000);
                Console.WriteLine("Du sætter nøglen i. Og er meget anspændt og nervøs for hvad der vil ske");
                Thread.Sleep(2000);
                Console.WriteLine("Døren knager og åbner sig selv foran dig");
                Thread.Sleep(2000);
                Console.WriteLine("Du er nu gået ind i det egyptiske kammer.");
                Thread.Sleep(2000);
                Console.WriteLine("På væggen hænger en oldgammel rustning.");
                Thread.Sleep(2000);
                Console.WriteLine("Du beslutter at tage sværdet med for beskyttelse.");
            }
        }
    }
}
