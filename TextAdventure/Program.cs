using System;


namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Welcome to the Dark Dungeon..");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            DarkDungeonTitle();

        }


        public static void DarkDungeonTitle()
        {
            


            Console.WriteLine("You awakein to the smell of rusty copper and a clatrapoic darkness...");
            Console.WriteLine("You stand up but almost lose your balance to something sharp stabing your foot");
            Console.WriteLine("You move forword carefully holding on to the wall as the only stable structure that you can see...");
            Console.WriteLine("Press 'Enter' to begin your decent");
            Console.ReadLine();
            Console.Clear();
            Choice1();
        }


        public static void Choice1()
        {

            string playerchoice;
            Console.WriteLine("You travel for hours in what you believe to be a straight path, but the darkness could be deciving you...");
            Console.WriteLine("Feeling comfort in the walls you lean heavyly into your only cling to reality.");
            Console.WriteLine("Those walls part and you almost fall towards an opening you can not see");
            Console.WriteLine("You ground your self and find that there are two paths");
            Console.WriteLine("Which shall you take?");
            Console.WriteLine("1. Keep heading North, the way you came");
            Console.WriteLine("2. Travel to the left, and see where it leads..");
            Console.WriteLine("3. STAY where you are and catch your breath");
            Console.Write("Choose: ");
            playerchoice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (playerchoice)
            {
                case "1":
                case "n":
                case "North":
                    {
                        Console.WriteLine("You decide that you will not take the chance and precede forwards");
                        Console.WriteLine("As you get a little further you fill the floor begin to shift downwards");
                        Console.WriteLine("The sudden change takes your balance and land hard on your rear sliding furthur into the abyss..");
                        Console.WriteLine("Just a sliver of light creeps from a unknown source and lets you witness metal post slide violently into you");
                        Console.WriteLine("The pain feels endless till your eyes become to heavy and you fall into the darkness");
                        Console.WriteLine("Twas a short meaningless life... Press Enter to Continue...");
                        Console.ReadLine();
                        GameOver();
                        break;
                    }
                case "2":
                case "Left":
                case "l":
                case "East":
                case "e":
                    {
                        Console.WriteLine("You travel to the left, feeling your gut twitch..");
                        Console.WriteLine("The darkness this way seems less heavy and you can see hints of light coming from a corner");
                        Console.WriteLine("You race to the light cauostiously and see the light filling more and more of a room");
                        Console.WriteLine("As you turn into the light you see to your surprize a door holding back the light");
                        Console.WriteLine("You turn the knob and enter the room");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        Choice2();
                        break;
                    }
                case "Stay":
                case "s":
                case "Do Nothing":
                case "Nothing":
                case "3":
                    {
                        Console.WriteLine("You decide you need a break...");
                        Console.WriteLine("As you lay your back to the wall you realize you were more tired than you thought");
                        Console.WriteLine("You decide to close your eyes for only a few minutes");
                        Console.WriteLine("Sleep takes you fast, and you feel yourself lost in another abyss, but this one is familar");
                        Console.WriteLine("You feel a pinch in your neck and try to jerk yourself back to life");
                        Console.WriteLine("You open your eyes and fear creeps back into your life as you find you cant move");
                        Console.WriteLine("You see something crawling on you but you can't swat it away");
                        Console.WriteLine("You open your mouth to scream but realize you can't breath");
                        Console.WriteLine("You lie there choking on your last breathe.");
                        Console.WriteLine("You close your eyes as the world gets even darker... Press 'Enter' to continue..");
                        Console.ReadLine();
                        GameOver();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is not a thing you can do...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        Console.Clear();
                        Choice1();
                        break;
                    }
            }

        }


        public static void Choice2()
        {
            Console.Clear();
            string playerchoice;
            Console.WriteLine("You slowly open the door not to be surprised of what lies ahead");
            Console.WriteLine("Your eyes begin to widen as you unbelivebly see what looks like a libarary");
            Console.WriteLine("You realize that the light however bright you saw it before, was actualy very dim, making it difficult to make since of much of the room");
            Console.WriteLine("An old voice makes you shreak in horror");
            Console.WriteLine("'Welcome to my home young one. You seem lost'");
            Console.WriteLine("The old man is sitting in a relic of a chair in the darkest cornor");
            Console.WriteLine("'Take a seat, of what other choice do you really have'");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. SIT next to the old man");
            Console.WriteLine("2. Demand answers!");
            Console.WriteLine("3. Attack the old man");
            Console.Write("Choose: ");
            playerchoice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (playerchoice)
            {
                case "1":
                case "Sit":
                case "s":
                case "Take a seat":
                    {
                        Console.WriteLine("You find a seat across from the old man and caoutiously sit");
                        Console.WriteLine("'Intresting, most scream and try to kill me' the man laughs...");
                        Console.WriteLine("'Most believe I am the one that put them in this pit'");
                        Console.WriteLine("'No one ever wonders if I too am trapped in my own hell'");
                        Console.WriteLine("'Listen to me ramble, you probably want some answers");
                        Console.WriteLine("Press 'Enter' to continue...");
                        Console.ReadLine();
                        Choice2A();
                        break;
                    }
                case "2":
                case "Demand answers":
                case "yell":
                case "d":
                    {
                        Console.WriteLine("You scream at the old man demanding answers...");
                        Console.WriteLine("All the fear gives you strength and you embace it, beginning to become increasly violent with him");
                        Console.WriteLine("As you begin to move forward towards him, you blink");
                        Console.WriteLine("In that split second the old man has sprung to life holding you above the air by the throat");
                        Console.WriteLine("'You stink of fear human... I am tired of the violence of man kind child...'");
                        Console.WriteLine("He picks you hire with ease and violently throws you to the other side of the room");
                        Console.WriteLine("'Leave before I end you child...'");
                        Console.WriteLine("Trying to catch your breath you see you landed on a door not there before, and sprint out trying to escape whatever this thing was..");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Choice3();
                        break;
                    }
                case "3":
                case "Attack":
                case "Attack the old man":
                case "a":
                    {
                        Console.WriteLine("Spratticly you look for something to kill the old man");
                        Console.WriteLine("You see a knife next to a rotten apple and despcriptly grab for it");
                        Console.WriteLine("As you lung forward only half of your body moves with you");
                        Console.WriteLine("You begin to scream as you feel a tight pain on your neck");
                        Console.WriteLine("The old man is standing over you, holding you in place, biting into your throat");
                        Console.WriteLine("He jerks you violently grunting with lust as he bites harder");
                        Console.WriteLine("You scream but no sound escapes");
                        Console.WriteLine("As your eyes get heavy the pain subsides, darkness swollows you...");
                        Console.WriteLine("Press 'Enter' please...");
                        Console.ReadLine();
                        GameOver();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is not a thing you can do...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        Console.Clear();
                        Choice2();
                        break;
                    }
            }

            

        }


        public static void Choice2A()
        {
            Console.Clear();
            Console.WriteLine("You feel a weird calming sense taking over forcing you to relax");
            Console.WriteLine("The old man smiles, as if understanding your paralasis");
            Console.WriteLine("'So you must wonder why you are here child'");
            Console.WriteLine("You feel a strange force nod your head, but words can not escape your mouth");
            Console.WriteLine("The old man smile grows even larger, revealing unnaturally sharp teeth");
            Console.WriteLine("'You may speak child' the old man says laughing at an inside joke that went completely over your head");
            Console.WriteLine("You tell him of how you just awoke in the dark place and have no memory of what happened");
            Console.WriteLine("'Well how unlucky you are..' he pauses 'I like you child so pay attention because this might save your life'");
            Console.WriteLine("'In the next room there is a sword plunged in the very ground.. Do not touch it'");
            Console.WriteLine("The old man stands and escorts you to the door..");
            Console.WriteLine("As he opens the door he turns to you 'Tread carefully little one, these caverns have taken many of your kind much braver than your self'");
            Console.WriteLine("You nod and head out back into the darkness confused..");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();
            Choice3A();
        }



        public static void Choice3()
        {
            string playerchoice;
            Console.WriteLine("As you step back into the dark you feel it swallowing you again");
            Console.WriteLine("Your eyes adjust and to your surprise you can see much more than originaly");
            Console.WriteLine("You walk a little further gaining confidence in the little sight gained");
            Console.WriteLine("You see a sword but even more you see a giant statue of a warrior behind it");
            Console.WriteLine("What do you want to do?....");
            Console.WriteLine("1. PICK UP the weapon, it could be useful");
            Console.WriteLine("2. GO TO warrior statue");
            Console.WriteLine("3. Nothing! I need to get out of here, need to keep moving");
            Console.Write("Choice: ");
            playerchoice = Console.ReadLine().ToLower();


            switch (playerchoice)
            {
                case "1":
                case "Pick up":
                case "p":
                case "pick up weapon":
                    {
                        Console.Clear();
                        Console.WriteLine("You decide that trusting a monster is probably not a good idea");
                        Console.WriteLine("As you grab the hilt you get pricked on the grip");
                        Console.WriteLine("You lift your hand to see blood dripping into the darkness..");
                        Console.WriteLine("When you look closer at your hand a pain shockes your body");
                        Console.WriteLine("You fall on the ground and start convulging and feel your heart pounding");
                        Console.WriteLine("The shakes become increasly violent and you strike your head hard on the ground to escape the pain");
                        Console.WriteLine("You feel a warm bath comfort your head and begin to fall into a slumper");
                        Console.WriteLine("Press 'Enter'....");
                        Console.ReadLine();
                        Console.Clear();
                        GameOver();
                        break;
                    }
                case "2":
                case "Go to":
                case "g":
                case "go to warrior statue":
                    {
                        string playerchoice1;
                        Console.Clear();
                        Console.WriteLine("You head over to the statue");
                        Console.WriteLine("As you get closer you see that the statue is chipped and weathered");
                        Console.WriteLine("The statue then swivles its head towards you");
                        Console.WriteLine("Terrified you fall to the ground hard");
                        Console.WriteLine("To your surprise the statue begins to speak");
                        Console.WriteLine("'Hello traveler, I am the guardian of this maze'");
                        Console.WriteLine("'There is no need to be frighten, I am your way out of this hell'");
                        Console.WriteLine("Caustiously you get to your feet");
                        Console.WriteLine("The statue continues 'To escape this prison you but only need to answer one question'");
                        Console.WriteLine("'But, I must warn you, to answer long will most certianly lead to your death'");
                        Console.WriteLine("Warily you tell the statue you want nothing more than to leave this place");
                        Console.WriteLine("Alright traveler, let us begin");
                        Console.WriteLine("Press 'Enter' to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("I have but only one riddle that you must answer with");
                        Console.WriteLine("I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. ");
                        Console.Write("What am I?:");
                        playerchoice1 = Console.ReadLine().ToLower();
                        if (playerchoice1 == "a map")
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'That is correct young traveler, you are a smart one..'");
                            Console.WriteLine("You are the first in what feels like a century to pass one of my riddles");
                            Console.WriteLine("The statue begins to move and a trap door presents itself");
                            Console.WriteLine("'Head underneath you will find safe passage back to your world...'");
                            Console.WriteLine("You look at the trap door, wondering how going father down could ever lead back home");
                            Console.WriteLine("As you see it you have no other option so you open the trap door and decide YOLO..");
                            Console.WriteLine("Press 'Enter' to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            WinGame();

                        }

                        else if (playerchoice1 == "map")
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'That is correct young traveler, you are a smart one..'");
                            Console.WriteLine("You are the first in what feels like a century to pass one of my riddles");
                            Console.WriteLine("The statue begins to move and a trap door presents itself");
                            Console.WriteLine("'Head underneath you will find safe passage back to your world...'");
                            Console.WriteLine("You look at the trap door, wondering how going father down could ever lead back home");
                            Console.WriteLine("As you see it you have no other option so you open the trap door and decide YOLO..");
                            Console.WriteLine("Press 'Enter' to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            WinGame();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'I am sorry traveler that is incorrect...'");
                            Console.WriteLine("'I do apolgize for this part'");
                            Console.WriteLine("As the statue finishes, the statue sinks into the floor");
                            Console.WriteLine("You quickly snap around to try to escape whatever punishment that is coming");
                            Console.WriteLine("To your horror you see nothing is actually left in the hall");
                            Console.WriteLine("The hallway has turned into four walls with no sight of where you came from");
                            Console.WriteLine("Then the room begins to enclose slowly on itself");
                            Console.WriteLine("Fantically, you try to look for a wedge the walls but nothing is around");
                            Console.WriteLine("The walls are getting closer, you use your own body to try and stall the walls");
                            Console.WriteLine("It does not work however, and your legs buckle under the weight");
                            Console.WriteLine("The walls are now on top of you, crushing your body");
                            Console.WriteLine(" You let a deep wrenchting hollow but your words only vibrate off the walls and tear your eardrums");
                            Console.WriteLine("You die a slow and agonizing death");
                            Console.WriteLine("Press 'Enter'...");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                        }
                        break;
                    }
                case "3":
                case "Nothing":
                case "n":
                case "do nothing":
                    {
                        Console.Clear();
                        Console.WriteLine("You decide this is as good as place as any to rest");
                        Console.WriteLine("As you lay down you hear absloute silence and feel you could actually asleep");
                        Console.WriteLine("You have horrible nightmares as you dream and awaken hours later to see this is your reality");
                        Console.WriteLine("You stand up ready now to make a decision");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Choice3A();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is not a thing you can do...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        Console.Clear();
                        Choice1();
                        break;
                    }
            }
        }

        public static void Choice3A()
        {
            string playerchoice;
            Console.WriteLine("As you step back into the dark you feel it swallowing you again");
            Console.WriteLine("Your eyes adjust and to your surprise you can see much more than originaly");
            Console.WriteLine("You walk a little further gaining confidence in the little sight gained");
            Console.WriteLine("You see the sword the old man told you about but even more you see a giant statue of a warrior behind it");
            Console.WriteLine("What do you want to do?....");
            Console.WriteLine("1. Screw the old man, PICK UP the weapon, it could be useful");
            Console.WriteLine("2. GO TO warrior statue");
            Console.WriteLine("3. Nothing! I need to get out of here, need to keep moving");
            Console.Write("Choice: ");
            playerchoice = Console.ReadLine().ToLower();


            switch (playerchoice)
            {
                case "1":
                case "Pick up":
                case "p":
                case "pick up weapon":
                    {
                        Console.Clear();
                        Console.WriteLine("You decide that trusting a monster is probably not a good idea");
                        Console.WriteLine("As you grab the hilt you get pricked on the grip");
                        Console.WriteLine("You lift your hand to see blood dripping into the darkness..");
                        Console.WriteLine("When you look closer at your hand a pain shockes your body");
                        Console.WriteLine("You fall on the ground and start convulging and feel your heart pounding");
                        Console.WriteLine("The shakes become increasly violent and you strike your head hard on the ground to escape the pain");
                        Console.WriteLine("You feel a warm bath comfort your head and begin to fall into a slumper");
                        Console.WriteLine("Press 'Enter'....");
                        Console.ReadLine();
                        Console.Clear();
                        GameOver();
                        break;
                    }
               case "2":
               case "Go to":
               case "g":
               case "go to warrior statue":
                    {
                        string playerchoice1;
                        Console.Clear();
                        Console.WriteLine("You head over to the statue");
                        Console.WriteLine("As you get closer you see that the statue is chipped and weathered");
                        Console.WriteLine("The statue then swivles its head towards you");
                        Console.WriteLine("Terrified you fall to the ground hard");
                        Console.WriteLine("To your surprise the statue begins to speak");
                        Console.WriteLine("'Hello traveler, I am the guardian of this maze'");
                        Console.WriteLine("'There is no need to be frighten, I am your way out of this hell'");
                        Console.WriteLine("Caustiously you get to your feet");
                        Console.WriteLine("The statue continues 'To escape this prison you but only need to answer one question'");
                        Console.WriteLine("'But, I must warn you, to answer long will most certianly lead to your death'");
                        Console.WriteLine("Warily you tell the statue you want nothing more than to leave this place");
                        Console.WriteLine("Alright traveler, let us begin");
                        Console.WriteLine("Press 'Enter' to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("I have but only one riddle that you must answer with");
                        Console.WriteLine("I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. ");
                        Console.Write("What am I?:");
                        playerchoice1 = Console.ReadLine().ToLower();
                        if (playerchoice1 == "a map")
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'That is correct young traveler, you are a smart one..'");
                            Console.WriteLine("You are the first in what feels like a century to pass one of my riddles");
                            Console.WriteLine("The statue begins to move and a trap door presents itself");
                            Console.WriteLine("'Head underneath you will find safe passage back to your world...'");
                            Console.WriteLine("You look at the trap door, wondering how going father down could ever lead back home");
                            Console.WriteLine("As you see it you have no other option so you open the trap door and decide YOLO..");
                            Console.WriteLine("Press 'Enter' to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            WinGame();

                        }

                        else if (playerchoice1 == "map")
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'That is correct young traveler, you are a smart one..'");
                            Console.WriteLine("You are the first in what feels like a century to pass one of my riddles");
                            Console.WriteLine("The statue begins to move and a trap door presents itself");
                            Console.WriteLine("'Head underneath you will find safe passage back to your world...'");
                            Console.WriteLine("You look at the trap door, wondering how going father down could ever lead back home");
                            Console.WriteLine("As you see it you have no other option so you open the trap door and decide YOLO..");
                            Console.WriteLine("Press 'Enter' to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            WinGame();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The stone stares at you for what seems like forever");
                            Console.WriteLine("'I am sorry traveler that is incorrect...'");
                            Console.WriteLine("'I do apolgize for this part'");
                            Console.WriteLine("As the statue finishes, the statue sinks into the floor");
                            Console.WriteLine("You quickly snap around to try to escape whatever punishment that is coming");
                            Console.WriteLine("To your horror you see nothing is actually left in the hall");
                            Console.WriteLine("The hallway has turned into four walls with no sight of where you came from");
                            Console.WriteLine("Then the room begins to enclose slowly on itself");
                            Console.WriteLine("Fantically, you try to look for a wedge the walls but nothing is around");
                            Console.WriteLine("The walls are getting closer, you use your own body to try and stall the walls");
                            Console.WriteLine("It does not work however, and your legs buckle under the weight");
                            Console.WriteLine("The walls are now on top of you, crushing your body");
                            Console.WriteLine(" You let a deep wrenchting hollow but your words only vibrate off the walls and tear your eardrums");
                            Console.WriteLine("You die a slow and agonizing death");
                            Console.WriteLine("Press 'Enter'...");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                        }
                        break;
                    }
                case "3":
                case "Nothing":
                case "n":
                case "do nothing":
                    {
                        Console.Clear();
                        Console.WriteLine("You decide this is as good as place as any to rest");
                        Console.WriteLine("As you lay down you hear absloute silence and feel you could actually asleep");
                        Console.WriteLine("You have horrible nightmares as you dream and awaken hours later to see this is your reality");
                        Console.WriteLine("You stand up ready now to make a decision");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Choice3A();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is not a thing you can do...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        Console.Clear();
                        Choice1();
                        break;
                    }



            }

            
        }


        public static void Choice4()
        {
            string playerchoice;
            Console.WriteLine("As you begin to stand you feel the ground open from underneath your feet");
            Console.WriteLine("You begin to slide down the hole that opened..");
            Console.WriteLine("The darkness swallows you whole and you are blind and falling");
            Console.WriteLine("You hit the ground hard on your nose begins to bleed from the impact");
            Console.WriteLine("You stand trying to find your balance and your eyes begin to adjust");
            Console.WriteLine("The floor is almost empty, you can see that you were lucky enough to find ground.");
            Console.WriteLine("There are three platforms within jumping reach with numbers on them");
            Console.WriteLine("You look around and see that there is text carved into the wall");
            Console.WriteLine("The text reads 'The power of three will save you but becareful because not all three are powerful'");
            Console.WriteLine("You have no idea what that means...");
            Console.WriteLine("What do you want to do?...");
            Console.WriteLine("1.Jump to block '17'...");
            Console.WriteLine("2.Jump to block '23'...");
            Console.WriteLine("3.Jump to block '777'...");
            Console.WriteLine("4.Look around...");
            Console.Write("Choose: ");
            playerchoice = Console.ReadLine().ToLower();


            if(playerchoice == "1")
            {

            }



        }
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("I wonder did you ever believe you would escape this hell");
            Console.WriteLine("Give it another shot im sure you will do better this time");
            Console.WriteLine("To try again just push 'Enter' my friend...");
            Console.ReadLine();
            Console.Clear();
            DarkDungeonTitle();

        }


        public static void WinGame()
        {

            Console.WriteLine("You did survive.... for now");
            Console.WriteLine("But really did you even win");
            Console.Write("Press any key to exit... Or give yourself another try by pressing 'Enter' ...");
            ConsoleKeyInfo CKey;
            Console.TreatControlCAsInput = true;
            do
            {
                CKey = Console.ReadKey();
            } while (CKey.Key != ConsoleKey.Enter);
            Console.Clear();
            DarkDungeonTitle();
            
            
            
            

        }
    }
}
