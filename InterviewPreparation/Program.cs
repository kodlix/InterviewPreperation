using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.BehaviouralPatterns.Command;
using DesignPatterns.BehaviouralPatterns.Command.UndoableCommand;
using DesignPatterns.BehaviouralPatterns.Iterator;
using DesignPatterns.BehaviouralPatterns.Mediator.MediatorWithObserver;
using DesignPatterns.BehaviouralPatterns.Momento;
using DesignPatterns.BehaviouralPatterns.Observer;
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

            var postsDialogBox = new PostsDialogBox();
            postsDialogBox.SimulateUserInteraction();

            #endregion


        }

        private static string ReverseString(string input)
        {
            string reversedString = string.Empty;

            for (int i = input.Length -1; i >= 0; i--)
            {
                reversedString += input[i];
            }


            var dict = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
            }
            
            return reversedString;
        }


        private static IEnumerable<T> GetWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        private static bool IsExist<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}