using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System;
using System.Reflection;

namespace Dossier_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Titel geben
            Console.Title = "Black Out - dein Wissen ist gefragt!";
            ///Codeabschnitt zum langsam zählen
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("Los");

            //Textbasiertes Spiel

            /// Idee: Stromausfall: Was tust du? 

            /// Titelbild
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Versuche, diese Challenge möglichst schnell und geschickt zu lösen.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bestätige mit A und Enter, wenn du das Spiel starten möchtest.");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /// Szene 1
            string start = Console.ReadLine();
            
            if(start.ToLower() == "a")
            {


                // Text langsam lesen
                {
                    string meinText = ("Es ist mitten in der Nacht. Du schreckst auf und weisst im ersten Moment gar nicht, wo du dich befindest. Deine Hand tastet die rechte Wand ab. Da merkst du: Alles ist gut, du liegst du Hause im Bett deiner Einzimmerwohnung. Aber irgendetwas hat dich aufgeweckt – ein ungewohntes Geräusch? Du stehst auf, um nach deiner Katze Garfield zu sehen. Drückst mit deiner Hand auf den Lichtschalter – und nochmals. Doch das Licht geht nicht an. Der Strom ist ausgefallen.");
                    SlowTyping(meinText);

                }
                static void SlowTyping(string meinText)
                {
                    for (int i = 0; i < meinText.Length; i++)
                    {
                        Console.Write(meinText[i]);
                        System.Threading.Thread.Sleep(70);
                    }
                }
               
                Console.ReadKey();

                ///Entscheidung 1
                Console.WriteLine
                ("Was tust du nun?");
                Console.ReadKey();

                // A
                Console.WriteLine
                ("a: Ich lege mich wieder schlafen und hoffe, dass das Problem morgen früh gelöst ist.");

                // B
                Console.WriteLine
                ("b: Ich taste mich zum Sicherungskasten im Flur und betätige den Schalter.");

                // Aufforderung
                  Console.WriteLine
                  ("Tipp a oder b ein und bestätige mit der Enter-Taste.");
                  string eingabe = Console.ReadLine();

                   //Wenn man A eingegeben hat
                    if (eingabe.ToLower() == "a")
                    {
                      Console.WriteLine
                      ("Gute Nacht. Schlafen lässt es sich auch ohne Strom gut.");
                    }

                    //Wenn man B eingegeben hat
                    else if (eingabe.ToLower() == "b")
                    {
                      Console.WriteLine
                      ("Gefunden! Schnell legst du den Sicherungsschalter um und wartest gespannt. " +
                      "Doch es tut sich nichts.");
                      /// Szene 2

                      ///Entscheidung 2
                       Console.WriteLine
                       ("Was nun?");

                        // A
                        Console.WriteLine
                          ("a: Ich rufe die Feuerwehr! " +
                          "Schliesslich handelt es sich um einen Notfall! ");

                        // B
                         Console.WriteLine
                         ("b: Ich muss das Elektrizitätswerk benachrichtigen. " +
                          "Vielleicht handelt es sich um einen grossflächigen Ausfall.");

                       // Aufforderung
                          Console.WriteLine
                          ("Tipp a oder b ein und bestätige mit der Enter-Taste.");
                          eingabe = Console.ReadLine();

                        //Wenn man A eingegeben hat
                        if (eingabe.ToLower() == "a")
                        {
                          Console.WriteLine
                           ("Wie lautet nochmals die Nummer der Feuerwehr?");
                        Console.WriteLine
                         ("Antworte schnell! Du hast nur 10 Sekunden Zeit, um zu antworten!");
                        string notfallnummertext = Reader.ReadLine(10 * 1000);

                            switch (notfallnummertext)
                            {
                            case "118":
                                Console.WriteLine
                                    ("Perfekt, du hast die richtige Nummer gewählt. " +
                                    "Doch die Feuerwehr lacht nur, als du ihnen von deinem Notfall erzählst. " +
                                    "Sie empfehlen dir, dich wieder schlafen zu legen.");
                            break;

                            case "112":
                                Console.WriteLine
                                    ("Du hast die allgemeine Notfallnummer gewählt und wirst zur Feuerwehr weitergeleitet. " +
                                    "Doch die Feuerwehr lacht nur, als du ihnen von deinem Notfall erzählst. " +
                                    "Sie empfehlen dir, dich wieder schlafen zu legen.");
                            break;

                            case "144":
                                Console.WriteLine
                                    ("Du hast die Sanitäts-Notfallnummer gewählt und wirst zur Feuerwehr weitergeleitet. " +
                                    "Doch die Feuerwehr lacht nur, als du ihnen von deinem Notfall erzählst. " +
                                    "Sie empfehlen dir, dich wieder schlafen zu legen.");
                            break;

                            case "Langsam!":
                                Console.WriteLine
                                    ("Du warst zu langsam. Das Spiel ist zu Ende.");
                            break;

                            default:
                                Console.WriteLine
                                    ("Du hast die falsche Nummer gewählt. " +
                                    "Wahrscheinlich bist du noch etwas müde. " +
                                    "Lege dich am besten wieder schlafen.");
                                break;
                            }

                        }


                        //Wenn man B eingegeben hat
                        else if (eingabe.ToLower() == "b")
                        {
                        Console.WriteLine
                        ("Nach mehrmaligem Klingeln ertönt eine generische Stimme: " +
                        "Du rufst ausserhalb der Öffnungszeiten an und kannst deshalb nur eine Nachricht " +
                        "hinterlassen. Schade. In diesem Moment fällt dir auf, dass in einem nahegelegenen" +
                        " Hochhaus ein Licht brennt. Heisst das etwa, dass der Stromausfall nur deine Wohnung " +
                        "betrifft?");

                          /// Szene 3
                          ///Entscheidung 3
                          Console.WriteLine
                          ("Was tust du als nächstes?");

                          // A
                          Console.WriteLine
                          ("a: Ich laufe jetzt zum Hochhaus und frage meinen Nachbarn um Rat.");

                          // B
                          Console.WriteLine
                          ("b: Das hat mich nun beruhigt. " +
                          "Wichtig ist nur, dass ich vor dem Schlafengehen meinen Fernseher und Laptop ausstecke.");

                          // Aufforderung
                           Console.WriteLine
                           ("Tipp a oder b ein und bestätige mit der Enter-Taste.");
                            eingabe = Console.ReadLine();

                        //Wenn man A eingegeben hat
                        if (eingabe.ToLower() == "a")
                        {
                            Console.WriteLine
                            ("Im Dunkeln läufst du der Strasse entlang zum Hochhaus und klingelst bei der Wohnung, in der Licht brennt." +
                            "Einige Sekunden vergehen – dann öffnet ein zerzauster Mann die Tür. " +
                            "Du fragst ihn, warum bei ihm Licht brennt, obwohl sogar die Strassenlaternen ausgeschaltet sind. " +
                            "Da lacht er und sagt: „Hast du nicht von den Wartungsarbeiten gehört? " +
                            "Ich habe extra einen Generator angeschlossen, um das Spiel meiner Lieblingsmannschaft in dieser Nacht sehen zu können. " +
                            "Komm doch rein, die Lakers spielen!“");


                            /// Szene 4

                            ///Entscheidung 4
                            Console.WriteLine
                            ("Nimmst du die Einladung deines Nachbars an?");

                            // A
                            Console.WriteLine
                            ("a:Warum eigentlich nicht? Jetzt bin ich sowieso wach. " +
                            "Und Nachbars-Bekanntschaften sind goldwert!");

                            // B
                            Console.WriteLine
                            ("b: Ich lehne dankend ab und gehe wieder nach Hause.");

                            // Aufforderung
                            Console.WriteLine
                            ("Tipp a oder b ein und bestätige mit der Enter-Taste.");
                            eingabe = Console.ReadLine();

                            //Wenn man A eingegeben hat
                            if (eingabe.ToLower() == "a")
                            {
                                Console.WriteLine
                                ("Du und dein Nachbar Philipp erleben einen lustigen Match. " +
                                "Mit Bier und Red Bull haltet ihr euch wach und habt um vier Uhr morgens Grund zum Feiern: " +
                                "Die Lakers gewinnen mit 4:1. Was für eine Nacht…");
                            }
                            //Wenn man B eingegeben hat
                            else if (eingabe.ToLower() == "b")
                            {
                                Console.WriteLine
                                ("Nach deinem kleinen Ausflug liegst du wieder in deinem Bett. " +
                                "Was für eine Nacht, denkst du dir und drehst dich zur Seite. " +
                                "Innert Minuten bist du wieder eingeschlafen.");
                            }
                            else
                            {
                                Console.WriteLine
                                ("Ungültige Eingabe. Das Spiel wird beendet.");
                                Console.ReadKey();
                            }
                        }

                        //Wenn man B eingegeben hat
                            else if (eingabe.ToLower() == "b")
                            {
                             Console.WriteLine
                             ("Im Dunkeln tappst du durch deine kleine Wohnung und legst dich wieder ins Bett " +
                              "– deine Powerbank ist voll geladen, daher kannst du beruhigt schlafen.");
                            }
                        
                        }
                          //Ungültige Eingabe
                        else
                        {
                          Console.WriteLine("Ungültige Eingabe. Das Spiel wird beendet.");
                          Console.ReadKey();
                        }
                    }
                     //Ungültige Eingabe
                    else
                    {
                      Console.WriteLine("Ungültige Eingabe. Das Spiel wird beendet.");
                      Console.ReadKey();
                    }

            }
            else
            {
             Console.WriteLine("Ungültige Eingabe. Das Spiel wird beendet.");
             Console.ReadKey();
            }
                    
                
        }

    }
    class Reader
    {
        private static Thread inputThread;
        private static AutoResetEvent getInput, gotInput;
        private static string input;

        static Reader()
        {
            getInput.WaitOne();
            input = Console.ReadLine();
            gotInput.Set();

        }

        private static void reader()
        {
            while (true)
            {
                getInput.WaitOne();
                input = Console.ReadLine();
                gotInput.Set();
            }
        }
        ///neue Readline-Methode (nicht selbst programmiert)
        public static string ReadLine(int timeOutMillisecs = Timeout.Infinite)
        {
            getInput.Set();
            bool success = gotInput.WaitOne(timeOutMillisecs);
            if (success)
            {
                return input;
            }
            else
            {
                {
                    return "Langsam";

                }
            }
        }
    }
}
