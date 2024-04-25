using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.progect.sec
{
    class basic_form
    {
        public string kind;
        public double price;
        
        public void writen()
        {
            Console.WriteLine("kind : " +kind + " ; price for kilo : " + price);
        }
    }
    class mango: basic_form
    {
       
    }
    class banana : basic_form
    {

    }
    class apple : basic_form
    {

    }
    class apricot : basic_form
    {

    }
    class peach : basic_form
    {

    }
    class grape : basic_form
    {

    }
    class cherry : basic_form
    {

    }
    class tomato : basic_form
    {

    }
    class potato : basic_form
    {

    }
    class cucamber : basic_form
    {

    }
    class cabbage : basic_form
    {

    }
    class lemon : basic_form
    {

    }
    class carrot: basic_form
    {

    }
    class onion : basic_form
    {

    }
    class spinach : basic_form
    {

    }
    class zucchini : basic_form
    {

    }
    public class Program
    {
//text methode
        static void add_metode(double wgh , string kn )
        {
            Console.WriteLine("your wheight :- "+ wgh);
            Console.WriteLine("choosed kind :- "+ kn);
        }
        static void choose_add() {            
            Console.WriteLine("you want put another thing in basket ? ");
            Console.WriteLine("write 'y' to continuo in the same section.");
            Console.WriteLine("write 'a' to go a home page.");
            Console.WriteLine("write 'h' to show contents of the basket.");
            Console.WriteLine("write 'f' to finish order.");
            Console.WriteLine("write 'x' to close the app.");
            Console.WriteLine("---> ");
            
        }
        static void messg_history()
        {
            Console.WriteLine("write '1' to return to home page ");
            Console.WriteLine("write '2' finish order.");
            Console.WriteLine("write '3' to close the APP.");
        }
        static void close_app()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("we are happy to help you");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        static void Main(string[] args)
        {
//array of history            
            List<string> historys = new List<string>();
//array of total cost
            double[] total_cost = new double[100];
//variable 
            string section, kind, change_wheight;
            char continuo;
            double wheight, cost, tot_cost_print;
            double mango_price, banana_price, apple_price, apricot_price, peach_price, grape_price, cherry_price, tomato_price;
            double potato_price, cucamber_price, Cabbage_price, lemon_price, carrot_price, onion_price, spinach_price, zucchini_price;
            int var_distanca, i = 0;
// methode fruits
//mango
            void MANGO()
            {
               mango Mango = new mango();
               Mango.kind = "mango";
               Mango.price = 30;
               Mango.writen();
               mango_price = Mango.price;
            }
//banana           
            void BANANA()
            {
                banana Banana = new banana();
                Banana.kind = "BANANA";
                Banana.price = 25;
                Banana.writen();
                banana_price = Banana.price;
            }
//apple
            void APPLE()
            {
                apple Apple = new apple();
                Apple.kind = "APPLE";
                Apple.price = 50;
                Apple.writen();
                apple_price = Apple.price;
            }
//apricot
            void APRICOT()
            {
                apricot Apricot = new apricot();
                Apricot.kind = "APRICOT";
                Apricot.price = 15;
                Apricot.writen();
                apricot_price = Apricot.price;
            }
//peach
            void PEACH()
            {
                peach Peach = new peach();
                Peach.kind = "PEACH";
                Peach.price = 35;
                Peach.writen();
                peach_price = Peach.price;
            }
//grape
            void GRAPE()
            {
                grape Grape = new grape();
                Grape.kind = "GRAPE";
                Grape.price = 50;
                Grape.writen();
                grape_price = Grape.price;
            }
//cherry
            void CHERRY()
            {
                cherry Cherry = new cherry();
                Cherry.kind = "CHERRY";
                Cherry.price = 80;
                Cherry.writen();
                cherry_price = Cherry.price;
            }
//tomato
            void TOMATO()
            {
                tomato Tomato = new tomato();
                Tomato.kind = "TOMATO";
                Tomato.price = 5;
                Tomato.writen();
                tomato_price = Tomato.price;
            }
//vegetables methode
//potato
            void POTATO()
            {
                potato Potato = new potato();
                Potato.kind = "potato";
                Potato.price = 2.5;
                Potato.writen();
                potato_price = Potato.price;
                ;
            }
//cucamber
            void CUCAMBER()
            {
                cucamber Cucamber = new cucamber();
                Cucamber.kind = "cucamber";
                Cucamber.price = 7.5;
                Cucamber.writen();
                cucamber_price = Cucamber.price;
            }
//cabbage
            void CABBAGE()
            {
                cabbage Cabbage = new cabbage();
                Cabbage.kind = "cabbage";
                Cabbage.price = 15;
                Cabbage.writen();
                Cabbage_price = Cabbage.price;
            }
//onion           
            void ONION()
            {
                onion Onion = new onion();
                Onion.kind = "onion";
                Onion.price = 2.5;
                Onion.writen();
                onion_price = Onion.price;
            }
//carrot            
            void CARROT()
            {
                carrot Carrot = new carrot();
                Carrot.kind = "carrot";
                Carrot.price = 17;
                Carrot.writen();
                carrot_price = Carrot.price;
            }
//zucchini           
            void ZUCCHINI()
            {
                zucchini Zucchini = new zucchini();
                Zucchini.kind = "zucchini";
                Zucchini.price = 12;
                Zucchini.writen();
                zucchini_price = Zucchini.price;
            }
//lemon            
            void LEMON()
            {
                lemon Lemon = new lemon();
                Lemon.kind = "lemon";
                Lemon.price = 12.5;
                Lemon.writen();
                lemon_price = Lemon.price;
            }
//spinach            
            void SPINACH()
            {
                spinach Spinach = new spinach();
                Spinach.kind = "spinach";
                Spinach.price = 18;
                Spinach.writen();
                spinach_price = Spinach.price;
            }            
//main page 
            b2:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n          WELCOME TO EL ZOZ STORE \n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            h3:
            Console.WriteLine(" we sell fruits & vegetables");
            Console.Write("enter the section  you want ---->");
            section = Console.ReadLine().ToLower();
            Console.Clear();
        b1:
//fruits section
            if (section == "fruits")
            {
            h1:
                MANGO();
                BANANA();
                APPLE();
                APRICOT();
                GRAPE();
                CHERRY();
                TOMATO();
                Console.Write("enter the kind : "); kind = Console.ReadLine().ToLower();
                if (kind == "mango" || kind == "banana" || kind == "apple" || kind == "apricot" || kind == "grape" || kind == "cherry" || kind == "tomato")
                {

                wm:
                    try
                    {
                        Console.Write("enter the weight : "); wheight = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("enter the wheight with numbers !!.");
                        goto wm;
                    }
                    Console.Clear();
                    switch (kind)
                    {
                        case "mango":
                            MANGO();Console.Clear();
                            h4:
                            add_metode(wheight, kind);
                            cost = (wheight * mango_price);
                            Console.WriteLine($"the cost is : {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if(change_wheight == "no")
                            {
                                Console.Clear();
                                d1:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {mango_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {mango_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {mango_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {mango_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d1;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)") ;
                                goto h4;
                            }
                            break;
                        case "banana":
                            BANANA(); Console.Clear();
                            h5:
                            add_metode(wheight, kind);
                            cost = (wheight * banana_price);
                            Console.WriteLine($"the cost is :-  {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if(change_wheight == "no")
                            {
                                Console.Clear();
                                d2:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {banana_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {banana_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {banana_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {banana_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d2;
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h5;
                            }
                        case "apple":
                            APPLE(); Console.Clear();
                            h6:
                            add_metode(wheight, kind);
                            cost = (wheight * apple_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d3:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apple_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apple_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apple_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apple_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d3;
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h6;
                            }
                        case "apricot":
                            APRICOT(); Console.Clear();
                            h7:
                            add_metode(wheight, kind);
                            cost = (wheight * apricot_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if(change_wheight == "no")
                            {
                                Console.Clear();
                                d4:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apricot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A': 
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apricot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apricot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {apricot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d4;
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h7;
                            }
                        case "grape":
                            GRAPE(); Console.Clear();
                            h8:
                            add_metode(wheight, kind);
                            cost = (wheight * grape_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d5:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {grape_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {grape_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        total_cost[i] = cost;
                                        i++;
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {grape_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {grape_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d5;
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h8;
                            }
                        case "cherry":
                            CHERRY(); Console.Clear();
                            h9:
                            add_metode(wheight, kind);
                            cost = (wheight * cherry_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d6:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cherry_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        Console.Clear();
                                        total_cost[i] = cost;
                                        i++;
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cherry_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cherry_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cherry_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d6;
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h9;
                            }
                        case "tomato":
                            TOMATO(); Console.Clear();
                            h10:
                            add_metode(wheight, kind);
                            cost = (wheight * tomato_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wm;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d7:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {tomato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {tomato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {tomato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {tomato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d7;
                                }
                                break;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h10;
                            }
                        default:

                            Console.Clear();
                            Console.WriteLine("please enter the kind correct !!.");
                            goto h1;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("please enter the kind correct !!.");
                    goto h1;
                }
            }
//vegetables sectione
            else if (section == "vegetables")
            {
            h2:
                POTATO();
                CUCAMBER();
                CABBAGE();
                LEMON();
                CARROT();
                ONION();
                SPINACH();
                ZUCCHINI();
                Console.Write("enter the kind : "); kind = Console.ReadLine().ToLower();
                if (kind == "potato" || kind == "cucamber" || kind == "cabbage" || kind == "carrot" || kind == "lemon" || kind == "onion" || kind == "spinach" || kind == "zucchini")

                {

                wv:
                    try
                    {
                        Console.Write("enter the weight : "); wheight = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("enter the wheight with numbers !!.");
                        goto wv;
                    }
                    Console.Clear();
                    switch (kind)
                    {
                        case "potato":
                            POTATO(); Console.Clear();
                            h11:
                            add_metode(wheight, kind);
                            cost = (wheight * potato_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                            d8:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {potato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {potato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {potato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {potato_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear() ;
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d8;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h11;
                            }
                            break;
                        case "cabbage":
                            CABBAGE(); Console.Clear();
                            h12:
                            add_metode(wheight, kind);
                            cost = (wheight * Cabbage_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d9:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {Cabbage_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {Cabbage_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {Cabbage_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {Cabbage_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d9;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h12;
                            }
                            break;
                        case "cucamber":
                            CUCAMBER(); Console.Clear();
                            h13:
                            add_metode(wheight, kind);
                            cost = (wheight * cucamber_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d10:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cucamber_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cucamber_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cucamber_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {cucamber_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d10;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h13;
                            }
                            break;
                        case "lemon":
                            LEMON(); Console.Clear();
                            h14:
                            add_metode(wheight, kind);
                            cost = (wheight * lemon_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if ( change_wheight == "no")
                            {
                                Console.Clear();
                                d11:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {lemon_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {lemon_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {lemon_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {lemon_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d11;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h14;
                            }
                            break;
                        case "carrot":
                            CARROT(); Console.Clear();
                            h15:
                            add_metode(wheight, kind);
                            cost = (wheight * carrot_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d12:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {carrot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {carrot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {carrot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {carrot_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d12;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h15;
                            }
                            break;
                        case "onion":
                            ONION(); Console.Clear();
                            h16:
                            add_metode(wheight, kind);
                            cost = (wheight * onion_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d13:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {onion_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {onion_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {onion_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {onion_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d13;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h16;
                            }
                            break;
                        case "spinach":
                            SPINACH(); Console.Clear();
                            h17:
                            add_metode(wheight, kind);
                            cost = (wheight * spinach_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d14:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {spinach_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {spinach_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {spinach_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {spinach_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d14;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h17;
                            }
                            break;
                        case "zucchini":
                            ZUCCHINI(); Console.Clear();
                            h18:
                            add_metode(wheight, kind);
                            cost = (wheight * zucchini_price);
                            Console.WriteLine($"the cost is :- {cost}");
                            Console.WriteLine("do you  want change the wheight ? (write 'yes' or 'no')");
                            change_wheight = Console.ReadLine().ToLower();
                            if (change_wheight == "yes")
                            {
                                Console.Clear();
                                goto wv;
                            }
                            else if (change_wheight == "no")
                            {
                                Console.Clear();
                                d15:
                                choose_add();
                                continuo = char.Parse(Console.ReadLine().ToLower());//need to read it with small letter
                                switch (continuo)
                                {
                                    case 'Y':
                                    case 'y'://same section
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {zucchini_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b1;
                                        break;
                                    case 'A':
                                    case 'a'://home page
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {zucchini_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        Console.Clear();
                                        goto b2;
                                        break;
                                    case 'H':
                                    case 'h'://history
                                        Console.Clear();
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {zucchini_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b4;
                                        break;
                                    case 'X':
                                    case 'x'://close app
                                        Console.Clear();
                                        close_app();
                                        goto b3;
                                        break;
                                    case 'F':
                                    case 'f':
                                        historys.Add($"choised kind : {kind} \nprice for kilo : {zucchini_price} \nyour wheight : {wheight} \nthe cost for your wheight :{cost}");
                                        total_cost[i] = cost;
                                        i++;
                                        goto b5;
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("enter the letter correct !!.");
                                        goto d15;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("enter the answer coorrect between(yes/no)");
                                goto h18;
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("please enter the kind correct !!.");
                            goto h2;
                            break;
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("please enter the kind correct !!.");
                    goto h2;
                }            
            }
//enter the section correct
            else
            {
                Console.Clear();
                Console.WriteLine("enter the section correct !!.");
                goto h3;
            }
// history
           void hist() 
            { 
           
              foreach (string memory in historys)
                {
                    Console.WriteLine($"{memory}  \n--------------------------\n");
                }
            }
            b4:
            hist();
            messg_history();
            try
            {
                var_distanca = int.Parse(Console.ReadLine());
            }
            catch(FormatException) 
            { 
                Console.Clear() ;
                Console.WriteLine("enter the number correct !!.");
                goto b4;
            }
            Console.Clear();
            if (var_distanca == 1) { goto b2; }
            else if (var_distanca == 2) { goto b5; }
            else if (var_distanca == 3) { close_app(); goto b3; }
            else 
            {
                Console.Clear();
                Console.WriteLine("enter the number correct !!.");
                goto b4; 
            }
//finish order
        b5:
            Console.Clear();
            hist();
            tot_cost_print = 0;
            foreach (int num in total_cost)
            {
                tot_cost_print += num;
            }
            Console.WriteLine( "------------------------");
            Console.WriteLine($"total cost is :- {tot_cost_print}");
            Console.WriteLine("------------------------");
            close_app();
            goto b3;
// close program 
        b3:
            ;
        }
    }
}
