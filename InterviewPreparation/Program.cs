using System;
using System.Collections.Generic;
using DesignPatterns.BehaviouralPatterns.Command;
using DesignPatterns.BehaviouralPatterns.Command.UndoableCommand;
using DesignPatterns.BehaviouralPatterns.Iterator;
using DesignPatterns.BehaviouralPatterns.Momento;
using DesignPatterns.BehaviouralPatterns.State;
using DesignPatterns.BehaviouralPatterns.Strategy;
using DesignPatterns.BehaviouralPatterns.Template.Strategy;
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

            var tea = new Tea();
            tea.Prepare();
            
            var camomile = new Camomile();
            camomile.Prepare();

            #endregion


        }
    }
}