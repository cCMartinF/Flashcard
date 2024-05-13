// See https://aka.ms/new-console-template for more information
using Flashcard;

bool flashAgain = true;
List<FlashCard> fakeDatabase = new List<FlashCard>
        {
            new FlashCard { Id = 1, Question = "Vad är en MVP?", Answer = "Minimum Viable Product. Produkt med bara det absolut minim och fungerar." },
            new FlashCard { Id = 2, Question = "Vad är skillnaden på mogna team och icke-mogna team", Answer = "Mogna team har ett mer HiveMind och en bättre känsla för tid." },
            new FlashCard { Id = 3, Question = "Cermonier i en sprint?", Answer = "1: Sprint Planering, 2: Stand-up, 3: Sprint Review, 4: Sprint Retro." },
            new FlashCard { Id = 4, Question = "Vad är agiltarbete?", Answer = "Hur ett team kan arbeta för att leverera värde." },
            new FlashCard { Id = 5, Question = "När och vart skapades det agila manifestet?", Answer = "February 2001 i Utah, USA." },
            new FlashCard { Id = 6, Question = "Vad är tofsen i LEAN?", Answer = "Ett sätt att uppmärksamma fel i produktion och uppmanas att dra i." },
            new FlashCard { Id = 7, Question = "5 punkterna i Team Culture", Answer = "1: Psycholigical Safety, 2: Dependability, 3: Structure, 4: Meaning, 5: Impact." },
            new FlashCard { Id = 8, Question = "Agildokumentation", Answer = "Jira" },
            new FlashCard { Id = 9, Question = "Arbetsgrupp VS Team", Answer = "Arbetsgrupp jobbar oberoende utifrån varandra med en ledare. Ofta Vattenfall struktur. Team jobbar beroende utav varandra med en scrum master (servent leader)." },
            new FlashCard { Id = 10, Question = "Beskriv KatzenBach-Smith", Answer = "Tid för ett team som går ifrån effektiva till effektiva team. 1: Form, 2: Storm, 3: Norm, 4: Perfection." },
            new FlashCard { Id = 11, Question = "Vad gör man i en retro?", Answer = "Går igenom förra retros Action Points. Medlemmar får tid på sig att göra en retro övning. Diskution och sedan förbättring." },
            new FlashCard { Id = 12, Question = "Skillnaden mellan Kanban och ScrumBoard", Answer = "Kanban har WIP." },
            new FlashCard { Id = 13, Question = "Vad är TDD", Answer = "Test Driven Development." },
            new FlashCard { Id = 14, Question = "När har man kommunicerat?", Answer = "När man är överens om vad som har sagts." },
            new FlashCard { Id = 15, Question = "Nämn olika retro övningar.", Answer = "Mood Graph, Segelbåten, Plus & Minus." },
            new FlashCard { Id = 16, Question = "Är demo och Sprint-review samma sak?", Answer = "Nej. Demo är endast en uppvisning av produkt, medan sprint-review går man igenom Målen för reviewen. Tar emot feedback ifrån StakeHolders." },
            new FlashCard { Id = 17, Question = "Vad är extremeprogramming", Answer = "En serie förhållningssätt kring programmering." },
            new FlashCard { Id = 18, Question = "Beskriv Check In", Answer = "En Icebreaker som öppnar upp medlemmar för kommukation." },
            new FlashCard { Id = 19, Question = "Hur kan man estimera komplexiteten i en uppgift?", Answer = "Planning Poker" },
            new FlashCard { Id = 20, Question = "Varför kan att rita uppgiften förbättra kommunikationen?", Answer = "Man får insyn hur de andra tänker och deras uppfattning om komplexiteten om en uppgift." },
            new FlashCard { Id = 21, Question = "Vilka måste vara med på estimering?", Answer = "Product Owner och Dev-team." },
            new FlashCard { Id = 22, Question = "Beskriv Fist to Five", Answer = "Fingrar- 0: No way!, 1: Need to talk, 2: Have reservations, 3: Okay, 4: Sounds good, 5: Total agreement." },
            new FlashCard { Id = 23, Question = "När gör man estimering?", Answer = "I refinement"},
            new FlashCard { Id = 24, Question = "Beskriv ParProgrammering", Answer = "En är Driver som skriver koden och en är Navigator som säger vilken kod som ska skrivas."},
            new FlashCard { Id = 25, Question = "Vad är Testdriven Utveckling", Answer = "Bestämmer först vad koden ska klara av, sedan kodar man lösningen och sen testar om koden klarade av uppgiftskraven."},
            new FlashCard { Id = 26, Question = "VAD ÄR SCRUMS VIKTIGASTE CERMONI", Answer = "Retrospektive"},
            new FlashCard { Id = 27, Question = "Beskriv Retro", Answer = "En cermoni i Scrum där man går igenom vad som var bra och inte i sprinta och sedan utvärdera och förbättra inför kommande sprint."},
            new FlashCard { Id = 28, Question = "Vad är en Action Point", Answer = "En åtgärdspunkt som måste hanteras för framsteg ska vara möjliga."},
            new FlashCard { Id = 29, Question = "Beskriv Projekttringeln", Answer = "Time, Cost, Quality. Kan enbart optimera 2."},
            new FlashCard { Id = 30, Question = "Hur bestämmer man vilken UserStory som man ska börja med?", Answer = "Via value/effort matrisen, Gant Schema, Projekttringeln."},
            new FlashCard { Id = 31, Question = "Hur kan man dela upp en UserStory", Answer = "Genom UserStory Mapping."},
            new FlashCard { Id = 32, Question = "Scrum - I.N.V.E.S.T", Answer = "Independet, Negotiable, Valueble, Estimated, Small, Testable."},
            new FlashCard { Id = 33, Question = "Vad är en RoadMap?", Answer = "En lös tidsplan för vad som ska göras i kommande sprint."},
            new FlashCard { Id = 34, Question = "Utmaningar med vattenfall.", Answer = "Projektet bestämt innan man skapar det, vilket då inte tar hänsyn till t.ex. buggar som uppstår i senare ledet och som leder till budgetökningar och förseningar." },
            new FlashCard { Id = 35, Question = "Varför är CI/CD bra?", Answer = "Små leveranser minskar större buggar och effektiviserar leveranser."},
            new FlashCard { Id = 36, Question = "Vad är CI/CD?", Answer = "Continous Integration, Continuous Delivery/Deployment."},
            new FlashCard { Id = 37, Question = "Beskriv VattenFall diagrammet.", Answer = "KravSpecifikation -> Design -> Konstruktion -> Test -> Underhåll."},
            new FlashCard { Id = 38, Question = "Vad är Refinement / Backlogg grooming?", Answer = "Sker innan SprintPlanering. Uppskattar kommande uppgifter och hinder."},
            new FlashCard { Id = 39, Question = "Vad gör en Product Owner?", Answer = "äger vad som ska prioriteras, planerar och tar bort hinder för utvecklarna."},
            new FlashCard { Id = 40, Question = "Vad gör en Scrum Master?", Answer = "Den som leder teamet genom facilitera självorganisering."},
            new FlashCard { Id = 41, Question = "Vad är Working Agreements", Answer = "Ett kontrakt där team kommer överens om gemensamma spelregler i ett projekt. T.ex. Definitions of Done, Mötestider osv..."},
            new FlashCard { Id = 42, Question = "När tweakar och vässar man saker i Backlog?", Answer = "I refinement."},
            new FlashCard { Id = 43, Question = "WIP", Answer = "Work In ProgressLimit"},
            new FlashCard { Id = 44, Question = "Vad är en User Story", Answer = "En uppgift som beskrivs som en story. T.ex. Som en X, vill jag Y, för att Z."},
            new FlashCard { Id = 45, Question = "Vad är tvärfunktionella Team", Answer = "Team med olika kunskapsområden som arbetar i samma team. T.ex. Designer med BackendDev."},
            new FlashCard { Id = 46, Question = "Skillnaden mellan SprintBacklogg och Backlogg", Answer = "SprintBacklogg är uppgifter i en sprint och förändras EJ. Backlogg har uppgifter som förändras efter behov/information."},
            new FlashCard { Id = 47, Question = "Hur är en person som är T-shaped", Answer = "En person som är specialist inom ett område, men även kan stötta andra områden."},
            new FlashCard { Id = 48, Question = "Vad är en sprint?", Answer = "Ett återkommande tidsblock för att utföra uppgifterna ifrån SprintBacklogg. Vanligen 2 veckor, men inte mer än 4 veckor i vanliga projekt."},
            new FlashCard { Id = 50, Question = "Vad är Versionshantering?", Answer = "Ett gemensamt system för att hantera och integrera filer. T.ex. GitHub."},
            new FlashCard { Id = 51, Question = "När kan man ge beröm eller feedback till en person?", Answer = "Beröm inför grupp, feedback enskilt."},
            new FlashCard { Id = 52, Question = "Vad gör en DevOps?", Answer = "Ser till att verktyg och olika utvecklingsmiljöer finns för utvecklarna."},
            new FlashCard { Id = 53, Question = "Vad gör pipeline i CI/CD", Answer = "Kör olika Automatiska Tester vid en commit?"},


        };

while (flashAgain)
{
    foreach (var flashCard in fakeDatabase)
    {
        Console.WriteLine($"Fråga - {flashCard.Id}: {flashCard.Question}");
        Console.ReadKey();
        Console.WriteLine($"Answer - {flashCard.Answer}");
        Console.WriteLine();
        Console.ReadKey();
    }
    Console.WriteLine("Slut på frågor... Vill du köra igen? (Y)");
    char? resp = Console.ReadKey().KeyChar;
    if(resp == 'Y' || resp == 'y' )
    {
        Console.WriteLine("");
        flashAgain = true;




        Console.WriteLine("");
    }
    else
    {
        flashAgain = false;
        Console.WriteLine("Bye");
    }
}


