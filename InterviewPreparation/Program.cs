﻿using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.BehaviouralPatterns.ChainOfResponsibility;
using DesignPatterns.BehaviouralPatterns.Command;
using DesignPatterns.BehaviouralPatterns.Command.UndoableCommand;
using DesignPatterns.BehaviouralPatterns.Iterator;
using DesignPatterns.BehaviouralPatterns.Mediator.MediatorWithObserver;
using DesignPatterns.BehaviouralPatterns.Momento;
using DesignPatterns.BehaviouralPatterns.Observer;
using DesignPatterns.BehaviouralPatterns.State;
using DesignPatterns.BehaviouralPatterns.Strategy;
using DesignPatterns.BehaviouralPatterns.Template.Strategy;
using DesignPatterns.BehaviouralPatterns.Visitor;
using DesignPatterns.CreationalPatterns.AbstractFactoryPattern;
using DesignPatterns.CreationalPatterns.FactorPattern;
using DesignPatterns.CreationalPatterns.PrototypePattern;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Adapter.Package;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Facade;
using DesignPatterns.StructuralPatterns.FlightWeight;
using DesignPatterns.StructuralPatterns.Proxy;
using DesignPatterns.StructuralPatterns.Proxy.Package;
using Microsoft.Win32;
using Camomile = DesignPatterns.BehaviouralPatterns.Template.TemplateMethod.Camomile;
using History = DesignPatterns.BehaviouralPatterns.Momento.History;
using Tea = DesignPatterns.BehaviouralPatterns.Template.TemplateMethod.Tea;

namespace InterviewPreparation
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            #region Momento => Behavioural

            /*
            var editor = new Editor();
            var history = new History(editor);

            history.Backup();
            editor.Title = "C# programming";
            history.Backup();
            editor.Content = "Anything programming";
            history.Backup();
            editor.Title = "This is the life of a dev";
            history.Backup();


            Console.WriteLine("Title => " + editor.Title);
            Console.WriteLine("Content => " + editor.Content);
            history.Restore();
            history.Restore();
            history.Restore();
            history.ShowHistory();
            */

            #endregion

            #region State => Behavioural

            /*
            var document = new Document(UserRoles.Admin);
            Console.WriteLine(document.State);
            Console.WriteLine(document.CurrentUserRole);

            document.Publish();
            Console.WriteLine(document.State);

            document.Publish();
            Console.WriteLine(document.State);*/

            #endregion

            #region Stratedgy => Behavioural

            /*var videoStorage = new VideoStorage(new CompressMov(), new OverLayBlackAndWhite());
            videoStorage.Store("/videos/recent");

            videoStorage.SetCompressor(new CompressMp4());
            videoStorage.SetOverlay(new OverLayNone());
            videoStorage.Store("/videos/recent-skits");*/

            #endregion

            #region Iterator => Behavioural

            /*var list = new ShoppingList();
            list.Push("Egusi");
            list.Push("Tomato");
            list.Push("Akara");

            var iterator = list.CreateIterator();
            while (iterator.HasNext())
            {
                var item = iterator.Current();
                Console.WriteLine(item);
                iterator.Next();
            }*/

            #endregion

            #region Command => Behavioural

            /*
            var light = new Light();
            var remote = new RemoteControl(new TurnOnCommand(light));
            remote.PressButton();
            */

            /*var htmlDoc = new HtmlDocument();
            var history = new DocHistory();

            htmlDoc.Content = "Hello World!";
            Console.WriteLine(htmlDoc.Content);

            var italicCommand = new ItalicCommand(htmlDoc, history);
            italicCommand.Execute();
            Console.WriteLine(htmlDoc.Content);

            italicCommand.UnExecute();
            Console.WriteLine(htmlDoc.Content);*/

            #endregion

            #region Template => Behavioural

            /*var beverageMaker = new BeverageMaker(new Tea());
            beverageMaker.MakeBeverage();

            beverageMaker.SetBeverage(new Coffee());
            beverageMaker.MakeBeverage();*/

            /*var tea = new Tea();
            tea.Prepare();

            var camomile = new Camomile();
            camomile.Prepare();*/

            #endregion

            #region Observer => Behavioural

            /*DataSource dataSource = new DataSource();
            Sheet2 sheet2 = new Sheet2(dataSource);
            Barchart barchart = new Barchart(dataSource);

            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(barchart);

            dataSource.SetValues(new List<int>(){5,5,2,52});
            dataSource.SetValues(new List<int>(){5,50,2,52});*/

            /*Console.WriteLine(ReverseString("alive"));

            var ageList = new List<int>() { 12, 33, 42, 18, 20, 30 };
            var  adults = ageList.GetWhere(x => x >= 18);

            var isAdult = ageList.IsExist(c => c > 18);
            Console.WriteLine(adults.ToArray());
            Console.WriteLine(isAdult);*/

            #endregion

            #region Mediator => Behavioural

            /*var postsDialogBox = new PostsDialogBox();
            postsDialogBox.SimulateUserInteraction();*/

            #endregion
            
            #region Chain of Responsibility => Behavioural

            /*var validator = new Validator();
            var authenticator = new Authenticator();
            var logger = new Logger();

            validator.SetNext(authenticator).SetNext(logger);
            var webServer = new WebServer(validator);

            var req = new HttpRequest("johny", "1234");
            webServer.Handler(req);*/

            #endregion
            
            #region  Visitor => Behavioural

            /*var clients = new List<Client>()
            {
                new RetailClient("Donal Duke", "don@yopmail.com"),
                new LawClient("Prof Saige", "saige@yopmail.com"),
                new RestaurantClient("Miami Foods", "miami@yopmail.com")
            };

            foreach (var client in clients)
            {
                //client.Accept(new EmailVisitor());
                client.Accept(new PdfExportVisitor());
            }*/

            #endregion
            
            #region  Composite => Structural

            /*var package = new Box();

            var box1 = new Box();
            box1.Add(new MicroPhone());

            var box2 = new Box();
            
            var box3 = new Box();
            box1.Add(new Mouse());
            
            var box4 = new Box();
            box1.Add(new KeyBoard());
            
            box2.Add(box3);
            box2.Add(box4);
            
            package.Add(box1);
            package.Add(box2);
            
            Console.Write("The total price of package is " + package.GetPrice());*/

            #endregion
            
            #region  Adapter => Structural

            //var videoEditor = new VideoEditor(new IVideo());
            //videoEditor.ApplyColor(new RainbowColor(new Rainbow()));

            #endregion
            
            #region  Bridge => Structural

            /*var lgRemoteControl = new RemoteControl(new LgRadio());
            lgRemoteControl.TurnOn();
            lgRemoteControl.TurnOff();
            
            var advancedRemoteControl = new AdvanceRemoteControl(new SonyRadio());
            advancedRemoteControl.TurnOn();
            advancedRemoteControl.TurnOff();
            advancedRemoteControl.SetChannel(55);*/
            
            #endregion
            
            #region  Proxy => Structural

            /*var videoList = new VideoList();
            string[] vidoeIds = { "abcd", "1234", "7890"};

            foreach (var videoId in vidoeIds)
            {
                videoList.Add(new YoutubeVideoProxy(videoId));
            }
            
            //watch video
            videoList.Watch("abcd");*/
            
            #endregion
            
            #region  FlyWeight => Structural

            /*var cropService = new CropService(new CropIconFactory());
            var crops = cropService.GetCrops();
            foreach (var crop in crops)
            {
                crop.Render();
            }  */ 

            #endregion
            
            #region  Faacade => Structural

            /*var orderService = new OrderService();
            orderService.Order(new OrderRequest());*/

            #endregion
            
            #region  Decorator => Structural

            /*bool encryptData = true, compressData = true, validate = true;
            IData cloudData = new CloudData("https://google.com/ai/llm-models");
            
            if (validate)
            {
                cloudData = new ValidationDecorator(cloudData);
            }

            if (encryptData)
            {
                 cloudData = new EncryptionDecorator(cloudData);
            }
            
            if (compressData)
            {
                cloudData = new CompressionDecorator(cloudData);
            }
            
            cloudData.Save("uqwhqjkqkjsaasasjkaskjkadsjkaskjadjkajk");*/

            #endregion
            
            #region  Prototype => Creational

            /*var circle = new Circle();
            circle.Draw();
            circle.Radius = 12;
            
            var rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Width = 12;
            rectangle.Height = 6;

            var shapeAction = new ShapeActions();
            var newCircle = shapeAction.Duplicate(circle);
            newCircle.Draw();
            
            var newRectangle = shapeAction.Duplicate(rectangle);
            newRectangle.Draw();   */ 

            #endregion
            
            #region  Factory => Creational

            /*
            var ordersCtrl = new OrdersController();
            ordersCtrl.GetOrder(33);*/

            #endregion
            
            #region  Abstract Factory => Creational

            Console.WriteLine("Choose loan type: 1 - Personal, 2 - Business");
            var choice = Console.ReadLine();

            ILoanProcessFactory factory = choice switch
            {
                "1" => new PersonalLoanFactory(),
                "2" => new BusinessLoanFactory(),
                _ => throw new Exception("Invalid choice")
            };

            var processor = new LoanProcessor(factory);
            processor.ProcessLoan();

            #endregion
        }
    }
}